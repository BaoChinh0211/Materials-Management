-- 1. Mục đích: Kiểm tra số lượng vật tư trong chi tiết phiếu nhập có lớn hơn số lượng trong chi tiết đơn đặt hàng không
-- 2. Cú pháp:

CREATE PROC sp_soSanhSoLuongCTPN_CTDDH @MaDDH nchar(8), @MaVT nchar(4), @soLuong int
AS
	IF EXISTS (SELECT 1
				FROM dbo.DatHang dh, dbo.CTDDH ct
				WHERE dh.MasoDDH = @MaDDH AND dh.MasoDDH = ct.MasoDDH AND ct.SOLUONG < @soLuong)
		RETURN 1
	ELSE
		RETURN 0
GO

-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = sp_soSanhSoLuongCTPN_CTDDH 'MDDH14', 'MS01', 1
SELECT @RESULT