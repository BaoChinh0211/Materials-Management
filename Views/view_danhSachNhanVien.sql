-- 1. Ý nghĩa: Bảng ảo chứa danh sách nhân viên
-- 2. Cú pháp:
CREATE VIEW v_danhSachNhanVien
AS
SELECT MANV,  CONCAT(HO, ' ', TEN, ' - ', MANV)  AS HOTEN
FROM dbo.NhanVien
WHERE (TrangThaiXoa = 0) AND (NOT EXISTS
      (SELECT SUSER_SNAME(sid) AS Expr1
       FROM sys.sysusers
	   WHERE name = CAST(dbo.NhanVien.MANV AS NVARCHAR)))
GO

-- 3. Câu lệnh xem:
SELECT * FROM v_danhSachNhanVien
GO