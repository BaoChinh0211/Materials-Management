-- 1. Mục đích: Kiểm tra điều kiện để xóa CTDDH
-- 2. Cú pháp:
USE QLVT
GO

CREATE PROCEDURE sp_kiemTraDieuKienXoaCTDDH @MaSoDDH nchar(8), @MaVatTu nchar(4)
AS
	IF EXISTS (SELECT 1
				FROM CTPN ct, PhieuNhap pn
				WHERE pn.MasoDDH = @MaSoDDH
					AND pn.MAPN = ct.MAPN
					AND ct.MAVT = @MaVatTu)
		RETURN 1
	ELSE
		RETURN 0;
GO

-- 3. Câu lệnh kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = sp_kiemTraDieuKienXoaCTDDH 'MDDH15', 'TV02'
SELECT @RESULT
