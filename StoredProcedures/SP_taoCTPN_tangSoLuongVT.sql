/* 1. Mục đích: Khi tạo một phiếu nhập mới thì tự động tạo các CTPN dựa trên MaSoDDH trong Phiếu nhập, 
   sau đó cập nhật số lượng vật tư */

-- 2. Cú pháp:
USE [QLVT]
GO
CREATE PROCEDURE [dbo].[sp_tangSoLuongVattu] @MAPN NCHAR(8), @MAVT NCHAR(4), @SOLUONG INT, @DONGIA FLOAT
AS
BEGIN
SET XACT_ABORT ON 
	BEGIN DISTRIBUTED TRANSACTION;
-- THÊM CÁC CHI TIẾT PHIẾU NHẬP
	INSERT INTO DBO.CTPN(MAPN, MAVT, SOLUONG, DONGIA) VALUES (@MAPN, @MAVT, @SOLUONG, @DONGIA)

-- Tăng số lượng vật tư
	EXEC sp_CapNhatSoLuongVatTu 'IMPORT', @MAVT, @SOLUONG
  COMMIT TRANSACTION;
END
GO

-- 3. Cú pháp kiểm tra:
EXEC [sp_tangSoLuongVattu] 'PN05', 'ML01', 4, 2000000
-- 4. Lưu ý:
/* Stored Procedures này sử dụng Giao tác, giả sử nếu thêm CTPN thất bại
hoặc có vấn đề khi cập nhật số lượng vật tư thì dữ liệu sẽ hoàn trả lại trước khi chạy sp */