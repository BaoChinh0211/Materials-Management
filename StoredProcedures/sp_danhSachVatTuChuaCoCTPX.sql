-- 1. Ý nghĩa: Danh sách vật tư chưa có Chi tiết Phiếu xuất
-- 2. Cú pháp:
CREATE PROCEDURE [dbo].[sp_danhSachVatTuChuaCoCTPX] @MAPX nchar(8)
AS
	SELECT *
	FROM Vattu v
	WHERE v.MAVT NOT IN (SELECT ct.MAVT 
						FROM CTPX ct 
						WHERE ct.MAPX = @MAPX)
-- 3. Cú pháp kiểm tra:
EXEC [sp_danhSachVatTuChuaCoCTPX] 'PX01'
SELECT * FROM CTPX
SELECT * FROM Vattu