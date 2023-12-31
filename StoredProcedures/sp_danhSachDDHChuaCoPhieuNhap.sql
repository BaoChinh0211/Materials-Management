USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[sp_danhSachDDHChuaCoPhieuNhap]    Script Date: 26/08/2023 7:52:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_danhSachDDHChuaCoPhieuNhap]
AS
SELECT dh.MasoDDH, NGAY, NhaCC, HO + ' ' + TEN AS HOTENNHANVIEN, TENVT, SOLUONG, DONGIA
FROM (SELECT MasoDDH, NGAY, NhaCC, MANV FROM DatHang) dh,
	(SELECT MANV,HO,TEN FROM NhanVien) nv,
	(SELECT MasoDDH, MAVT,SOLUONG,DONGIA FROM CTDDH) ct,
	(SELECT MAVT, TENVT FROM Vattu) vt
WHERE dh.MasoDDH = ct.MasoDDH
	AND dh.MANV = nv.MANV
	AND ct.MAVT = vt.MAVT
	AND dh.MasoDDH NOT IN (SELECT MasoDDH
							FROM PhieuNhap)
go
exec [sp_danhSachDDHChuaCoPhieuNhap]
