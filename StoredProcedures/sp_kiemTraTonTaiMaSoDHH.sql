-- 1. Mục đích: kiểm tra mã đơn đặt hàng @MaDDH có tồn tại trong bảng dbo.[Dathang] chưa --
-- 2. Cú pháp:
USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[sp_checkMaDDH]    Script Date: 19/08/2023 8:28:10 SA ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_checkMaDDH]
  @MADDH NCHAR(8)
AS
-- Kiểm tra ở phân mảnh hiện tại
	IF  EXISTS(SELECT MasoDDH FROM  DatHang WHERE MasoDDH = @MADDH)
		BEGIN
   			RETURN 1;
		END
	ELSE
-- Kiểm tra ở phân mảnh gốc
    IF EXISTS(SELECT MasoDDH FROM LINK0.QLVT.DBO.DatHang WHERE MasoDDH = @MADDH)
		BEGIN
			RETURN 1;
		END
    ELSE 
-- Kiểm tra ở phân mảnh còn lại
    IF EXISTS(SELECT MasoDDH FROM LINK1.QLVT.DBO.DatHang WHERE MasoDDH = @MADDH)
		BEGIN
			RETURN 1;
		END
	ELSE
		RETURN 0

-- 3. Câu lệnh kiểm tra:
	-- Kiểm tra mã đơn hàng MDDH01:
DECLARE @RESULT INT
EXEC @RESULT = sp_checkMaDDH 'MDDH01'
SELECT @RESULT