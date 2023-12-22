-- 1. Ý nghĩa: Danh sách nhân viên có TTX = 0 tại chi nhánh hiện tại, tức là chưa được chuyển đi
-- 2. Cú pháp:

CREATE VIEW view_danhSachNhanVienChuaBiChuyen
AS
SELECT MANV, HO, TEN, SOCMND, DIACHI, NGAYSINH, LUONG, TrangThaiXoa 
FROM NhanVien
WHERE TrangThaiXoa = 0;
GO

-- 3. Cú pháp kiểm tra:
SELECT * FROM view_danhSachNhanVienChuaBiChuyen