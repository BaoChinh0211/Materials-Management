-- 1. Mục đích: Kiểm tra mã nhân viên khi thêm mới đã tồn tại trên hệ thống chưa, nếu có trả về 1, nếu chưa trả về 0.
-- 2. Cú pháp:

USE [QLVT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kiemTraMaNhanVienThemMoi]
  @MANV INT
AS
	IF  EXISTS(SELECT MANV FROM  NhanVien WHERE MANV = @MANV)
		BEGIN
   			RETURN 1;
		END
	ELSE
    IF EXISTS(SELECT MANV FROM LINK0.QLVT.DBO.NhanVien WHERE MANV =@MANV)
		BEGIN
			RETURN 1;
		END
    ELSE 
    IF EXISTS(SELECT MANV FROM LINK1.QLVT.DBO.NhanVien WHERE MANV =@MANV)
		BEGIN
			RETURN 1;
		END
	IF EXISTS(SELECT MANV FROM LINK2.QLVT.DBO.NhanVien WHERE MANV =@MANV)
		BEGIN
			RETURN 1;
		END
	ELSE
		RETURN 0;
GO
-- 3. Cú pháp kiểm tra:
	-- Kiểm tra nhân viên có mã là 1.
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraMaNhanVienThemMoi] 1
SELECT @RESULT