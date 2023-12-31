-- 1. Ý nghĩa: Phục vụ cho chức năng hoàn tác sau khi đã điều chuyển một nhân viên sang chi nhánh mới
-- 2. Cú pháp:
USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[sp_hoanTacChuyenChiNhanh]    Script Date: 25/08/2023 11:28:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_hoanTacChuyenChiNhanh]
@MANV int,
@MACNCU nchar(10),
@MACNM nchar(10)
AS
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRANSACTION
	-- Xóa nhân viên ở chi nhánh mới
		DELETE LINK0.QLVT.DBO.NhanVien
		WHERE MANV = (SELECT MAX(MANV) FROM LINK0.QLVT.DBO.NhanVien) AND MACN = @MACNM
	-- Cập nhật trạng thái nhân viên ở chi nhánh cũ
		UPDATE LINK0.QLVT.DBO.NhanVien
		SET TrangThaiXoa = 0
		WHERE MANV = @MANV AND MACN = @MACNCU
	COMMIT TRAN;
END
