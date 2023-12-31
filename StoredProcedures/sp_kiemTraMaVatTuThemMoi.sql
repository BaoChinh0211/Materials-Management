-- 1. Mục đích: Kiểm tra mã vật tư khi thêm mới đã tồn tại trên hệ thống chưa, nếu có trả về 1, nếu chưa trả về 0.
-- 2. Cú pháp:

USE [QLVT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_kiemTraMaVatTuThemMoi] @MaVT nchar(4)
AS
	IF EXISTS (SELECT 1 FROM DBO.Vattu WHERE MAVT = @MaVT)
	BEGIN
		RETURN 1;
	END
RETURN 0;
GO

-- 3. Cú pháp kiểm tra:
DECLARE @RESULT INT
EXEC @RESULT = [sp_kiemTraMaVatTuThemMoi] 'ML01'
SELECT @RESULT
