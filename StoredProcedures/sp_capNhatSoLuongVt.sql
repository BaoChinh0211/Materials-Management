-- 1. Ý nghĩa: cập nhật số lượng vật tư bị biến động. Nếu lập phiếu nhập thì tăng số lượng vật tư. Nếu lập phiếu xuât thì giảm số lượng vật tư
-- 2. Cú pháp:
USE QLVT
GO

CREATE PROCEDURE sp_CapNhatSoLuongVatTu
	@CHEDO NVARCHAR(6),
	@MAVT NCHAR(4),
	@SOLUONG INT
AS
BEGIN
	-- Xuất vật tư -> Giảm số lượng
	IF( @CHEDO = 'EXPORT')
	BEGIN
		IF( EXISTS(SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT))
			BEGIN
				UPDATE DBO.Vattu
				SET SOLUONGTON = SOLUONGTON - @SOLUONG
				WHERE MAVT = @MAVT
			END
	END

	-- Nhập vật tư -> Tăng số lượng
	IF( @CHEDO = 'IMPORT')
	BEGIN
		IF( EXISTS(SELECT * FROM DBO.Vattu AS VT WHERE VT.MAVT = @MAVT) )
			BEGIN
				UPDATE dbo.Vattu
				SET SOLUONGTON = SOLUONGTON + @SOLUONG
				WHERE MAVT = @MAVT
			END
	END
END
-- 3. Câu lệnh thử nghiệm:
EXEC sp_CapNhatSoLuongVatTu 'IMPORT','ML01', 130
EXEC sp_CapNhatSoLuongVatTu 'EXPORT','MS01', 50