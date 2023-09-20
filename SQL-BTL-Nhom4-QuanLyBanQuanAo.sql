USE master
GO
CREATE DATABASE BTL_Nhom4_QuanLyBanQuanAo
GO
USE BTL_Nhom4_QuanLyBanQuanAo
GO
CREATE TABLE NhanVien
(
	MaNhanVien CHAR(10) PRIMARY KEY,
	TenNhanVien VARCHAR(20),
	SoDienThoai CHAR(10) UNIQUE,
	NamSinh INT,
	GioiTinh CHAR(10),
	DiaChi VARCHAR(20),
	MaChucVu CHAR(10),
	MatKhau VARCHAR(20) DEFAULT '123'
)

CREATE TABLE ChucVu
(
	MaChucVu CHAR(10) PRIMARY KEY,
	TenChucVu VARCHAR(20)
)

CREATE TABLE KhachHang
(
	MaKhachHang INT IDENTITY(1, 1) PRIMARY KEY,
	TenKhachHang VARCHAR(20),
	SoDienThoai CHAR(10) UNIQUE
)

CREATE TABLE GioiTinh
(
	GioiTinh CHAR(10) PRIMARY KEY
)

CREATE TABLE HangHoa
(
	MaHangHoa CHAR(10),
	KichThuoc INT,
	GiaNhap FLOAT,
	TenHangHoa VARCHAR(20),
	MaLoaiHangHoa CHAR(10),
	GiaBan FLOAT,
	SoLuong INT,
	GhiChu VARCHAR(50),
	PRIMARY KEY (MaHangHoa, KichThuoc, GiaNhap)
)

CREATE TABLE LoaiHangHoa
(
	MaLoaiHangHoa CHAR(10) PRIMARY KEY,
	TenLoaiHangHoa VARCHAR(20)
)

CREATE TABLE KichThuoc
(
	KichThuoc INT PRIMARY KEY
)

CREATE TABLE GiaoDich
(
	MaGiaoDich INT IDENTITY(1, 1) PRIMARY KEY,
	SoTien FLOAT,
	NoiDung VARCHAR(50)
)

CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY(1, 1) PRIMARY KEY,
	MaGiaoDich INT,
	MaKhachHang INT,
	MaNhanVien CHAR(10),
	ThoiGian DATE
)

CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon INT,
	MaHoaDon INT,
	MaHangHoa CHAR(10),
	KichThuoc INT,
	GiaBan FLOAT,
	SoLuong INT,
	ThanhTien FLOAT,
	PRIMARY KEY (MaChiTietHoaDon, MaHoaDon)
)

CREATE TABLE DoanhSo
(
	MaGiaoDich INT PRIMARY KEY,
	VonBanDau FLOAT,
	VonHienTai FLOAT,
	DoanhSo FLOAT
)

CREATE TABLE LuongNhanVien
(
	MaNhanVien CHAR(10),
	ThoiGian DATE,
	MaGiaoDich INT,
	LuongCoBan FLOAT,
	DoanhSo FLOAT,
	TongLuong FLOAT,
	PRIMARY KEY (MaNhanVien, ThoiGian)
)

ALTER TABLE NhanVien ADD FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
GO
ALTER TABLE NhanVien ADD FOREIGN KEY (GioiTinh) REFERENCES GioiTinh(GioiTinh)
GO
ALTER TABLE HangHoa ADD FOREIGN KEY (MaLoaiHangHoa) REFERENCES LoaiHangHoa(MaLoaiHangHoa)
GO
ALTER TABLE HangHoa ADD FOREIGN KEY (KichThuoc) REFERENCES KichThuoc(KichThuoc)
GO
ALTER TABLE HoaDon ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)
GO
ALTER TABLE HoaDon ADD FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
GO
ALTER TABLE HoaDon ADD FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO
ALTER TABLE ChiTietHoaDon ADD FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
GO
ALTER TABLE LuongNhanVien ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)
GO
ALTER TABLE DoanhSo ADD FOREIGN KEY (MaGiaoDich) REFERENCES GiaoDich(MaGiaoDich)

GO
INSERT INTO GioiTinh
VALUES
	('Nam'),
	('Nu');
GO
INSERT INTO ChucVu
VALUES
	('ADMIN', 'Admin'),
	('NV', 'Nhan vien');
GO
INSERT INTO KichThuoc
VALUES
	('36'),
	('37'),
	('38'),
	('39'),
	('40'),
	('41'),
	('42');
GO
INSERT INTO LoaiHangHoa
VALUES
	('Q', 'Quan'),
	('A', 'Ao');
GO
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh, DiaChi, MaChucVu)
VALUES
	('admin', 'admin', '0123456789', '2001', 'Nam', 'Thanh Hoa', 'ADMIN'),
	('NV001', 'Van', '0123456788', '2001', 'Nam', 'Thanh Hoa', 'NV'),
	('NV002', 'Thuong', '0123456787', '2002', 'Nam', 'Hoa Binh', 'NV');
GO
INSERT INTO GiaoDich (SoTien, NoiDung) 
VALUES
	('100000000', 'them von ban dau');
GO
INSERT INTO DoanhSo(MaGiaoDich, VonBanDau, VonHienTai, DoanhSo) 
VALUES
	('1', '100000000', '100000000', '0');
GO

