-- 1. Ý nghĩa: Danh sách vật tư chưa có trong CTDDH có Mã số DDH là @MADDH --
-- 2. Cú pháp:
CREATE PROCEDURE sp_danhSachVatTuChuaCoCTDDH @MADDH nchar(8)
AS
	SELECT v.MAVT, v.TENVT, v.DVT, v.SOLUONGTON
	FROM Vattu v
	WHERE v.MAVT NOT IN (SELECT ct.MAVT 
						FROM CTDDH ct 
						WHERE ct.MasoDDH = @MADDH)
GO

--DROP PROC sp_danhSachVatTuChuaCoCTDDH
-- 3. Câu lệnh kiểm tra kết quả;
EXEC sp_danhSachVatTuChuaCoCTDDH 'MDDH04'