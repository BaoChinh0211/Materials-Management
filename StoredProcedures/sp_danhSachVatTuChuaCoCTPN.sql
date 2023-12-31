USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[sp_VTNotInCTPN]    Script Date: 19/08/2023 11:07:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_VTNotInCTPN] @MasoDDH nchar(8)
AS
SELECT ct.MasoDDH, ct.MAVT, vt.TENVT, ct.SOLUONG, ct.DONGIA
FROM  CTDDH ct, Vattu vt
WHERE ct.MasoDDH = @MasoDDH 
	AND ct.MAVT NOT IN (SELECT MAVT
						FROM CTPN ctpn, PhieuNhap pn
						WHERE pn.MasoDDH = @MasoDDH 
							AND ctpn.MAPN = pn.MAPN) 
							AND ct.MAVT = vt.MAVT