-- 1. Ý nghĩa: Kiểm tra mã phiếu nhập thêm mới có tồn tại trên hệ thống chưa?
-- 2. Cú pháp:
CREATE PROCEDURE [dbo].[sp_kiemTraMaPhieuXuatThemMoi] @MAPX NCHAR(8)
AS
-- Kiểm tra ở phân mảnh hiện tại
	IF  EXISTS(SELECT MAPX FROM  PhieuXuat WHERE MAPX = @MAPX)
		BEGIN
   			RETURN 1;
		END
	ELSE
-- Kiểm tra ở phân mảnh gốc
    IF EXISTS(SELECT MAPX FROM LINK0.QLVT.DBO.PhieuXuat WHERE MAPX = @MAPX)
		BEGIN
			RETURN 1;
		END
    ELSE 
-- Kiểm tra ở phân mảnh còn lại
    IF EXISTS(SELECT MAPX FROM LINK1.QLVT.DBO.PhieuXuat WHERE MAPX = @MAPX)
		BEGIN
			RETURN 1;
		END
	ELSE
		RETURN 0
GO
-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraMaPhieuXuatThemMoi] 'PX01'
SELECT @RESULT