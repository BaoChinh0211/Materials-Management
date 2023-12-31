-- 1. Mục đích: Kiểm tra mã số Đơn đặt hàng khi thêm mới đã tồn tại trên hệ thống chưa, nếu có trả về 1, nếu chưa trả về 0.
-- 2. Cú pháp:

USE [QLVT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_kiemTraMaSoDHHThemMoi] @MADDH NCHAR(8)
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
GO
-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraMaSoDHHThemMoi] 'MDDH01'
SELECT @RESULT