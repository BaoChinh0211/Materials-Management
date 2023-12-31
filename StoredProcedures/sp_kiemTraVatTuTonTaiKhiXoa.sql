-- 1. Mục đích: Kiểm tra mã vật tư khi xóa có tồn tại trên hệ thống chưa, cả trên phân mảnh hiện tại và phân mảnh còn lại
				-- nếu có tồn tại thì trả về 1, nếu chưa thì trả về 0.
-- 2. Cú pháp:
USE [QLVT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_kiemTraVatTuTonTaiKhiXoa] @MaVT nchar(4)
AS
	IF EXISTS ( SELECT 1 
				FROM LINK1.QLVT.DBO.CTDDH d
				WHERE d.MAVT = @MaVT)		
		OR EXISTS ( SELECT 1 
					FROM LINK1.QLVT.DBO.CTPN N
					WHERE N.MAVT = @MaVT)
		OR EXISTS ( SELECT 1 
					FROM LINK1.QLVT.DBO.CTPX X
					WHERE X.MAVT = @MaVT)
		BEGIN
		RETURN 1
		END
	RETURN 0
GO
-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraVatTuTonTaiKhiXoa] 'MU01'
SELECT @RESULT
