-- 1. Ý nghĩa: Báo cáo Danh sách các đơn đặt hàng chưa có phiếu nhập
-- 2. Cú pháp:
CREATE VIEW view_danhSachDDHChuaCoPhieuNhap
AS
SELECT dh.MasoDDH, NGAY, NhaCC, TENKHO, HO + ' ' + TEN AS HOTENNHANVIEN, TENVT, SOLUONG, DONGIA
FROM (SELECT MasoDDH, NGAY, NhaCC, MAKHO, MANV FROM DatHang) dh,
	(SELECT MANV,HO,TEN FROM NhanVien) nv,
	(SELECT MasoDDH, MAVT,SOLUONG,DONGIA FROM CTDDH) ct,
	(SELECT MAVT, TENVT FROM Vattu) vt,
	(SELECT MAKHO, TENKHO FROM Kho) k
WHERE dh.MasoDDH = ct.MasoDDH
	AND dh.MANV = nv.MANV
	AND dh.MAKHO = k.MAKHO
	AND ct.MAVT = vt.MAVT
	AND dh.MasoDDH NOT IN (SELECT MasoDDH
							FROM PhieuNhap)
GO
-- 3. Cú pháp kiểm tra:
SELECT * FROM view_danhSachDDHChuaCoPhieuNhap