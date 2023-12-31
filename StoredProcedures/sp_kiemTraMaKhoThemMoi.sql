-- 1. Mục đích: Kiểm tra mã kho khi thêm mới đã tồn tại trên hệ thống chưa, nếu có trả về 1, nếu chưa trả về 0.
-- 2. Cú pháp:
USE [QLVT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_kiemTraMaKhoThemMoi]
  @MAKHO NCHAR(4)
AS
	IF  EXISTS(SELECT MAKHO FROM  Kho WHERE MAKHO = @MAKHO)
		BEGIN
   			RETURN 1;
		END
	ELSE
    IF EXISTS(SELECT MAKHO FROM LINK0.QLVT.DBO.Kho WHERE MAKHO = @MAKHO)
		BEGIN
			RETURN 1;
		END
    ELSE 
    IF EXISTS(SELECT MAKHO FROM LINK1.QLVT.DBO.Kho WHERE MAKHO = @MAKHO)
		BEGIN
			RETURN 1;
		END
	IF EXISTS(SELECT MAKHO FROM LINK2.QLVT.DBO.Kho WHERE MAKHO = @MAKHO)
		BEGIN
			RETURN 1;
		END
	ELSE
		RETURN 0;
GO

-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraMaKhoThemMoi] K1N1
SELECT @RESULT