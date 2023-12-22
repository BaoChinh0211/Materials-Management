-- 1. Ý Nghĩa: Bảng ảo trả về danh sách phân mảnh
-- 2. Cú pháp:
CREATE VIEW v_danhSachPhanManh
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM dbo.sysmergepublications 
AS PUBS INNER JOIN dbo.sysmergesubscriptions 
AS SUBS ON PUBS.pubid = SUBS.pubid 
	AND PUBS.publisher <> SUBS.subscriber_server 
	AND PUBS.description <> N'Chi nhánh Tìm kiếm'
GO

-- 3. Câu lệnh xem view:
SELECT * FROM v_danhSachPhanManh
GO