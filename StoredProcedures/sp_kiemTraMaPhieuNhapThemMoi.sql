-- 1. ý nghĩa: kiểm tra mã phiếu nhập thêm mới có tồn tại trên hệ thống hay chưa
-- 2. Cú pháp:
CREATE PROCEDURE [dbo].[sp_kiemTraMaPhieuNhapThemMoi] @MAPN NCHAR(8)
AS
-- Kiểm tra ở phân mảnh hiện tại
	IF  EXISTS(SELECT MAPN FROM  PhieuNhap WHERE MAPN = @MAPN)
		BEGIN
   			RETURN 1;
		END
	ELSE
-- Kiểm tra ở phân mảnh gốc
    IF EXISTS(SELECT MAPN FROM LINK0.QLVT.DBO.PhieuNhap WHERE MAPN = @MAPN)
		BEGIN
			RETURN 1;
		END
    ELSE 
-- Kiểm tra ở phân mảnh còn lại
    IF EXISTS(SELECT MAPN FROM LINK1.QLVT.DBO.PhieuNhap WHERE MAPN = @MAPN)
		BEGIN
			RETURN 1;
		END
	ELSE
		RETURN 0
GO
-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = sp_kiemTraMaPhieuNhapThemMoi 'PN01'
SELECT @RESULT
