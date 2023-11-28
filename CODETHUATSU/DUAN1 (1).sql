USE master;
GO
CREATE DATABASE DUAN1;
GO
USE DUAN1;
GO
CREATE TABLE dang_nhap(
	tai_khoan varchar(20) PRIMARY KEY,
	mat_khau varchar(50) NOT NULL,
	role varchar(10) NOT NULL
)
GO
CREATE TABLE kho_hang(
	ma_kho_hang varchar(20) PRIMARY KEY,
	dia_chi nvarchar(50),
)
GO
CREATE TABLE hang_hoa(
	ma_hang_hoa varchar(20) PRIMARY KEY,
	ten nvarchar(50),
	ngay_sx date,
	hsd date,
	gia float,
	hinh varchar(200)
)
GO
CREATE TABLE khohang_hanghoa(
	ma_kho_hang varchar(20),
	ma_hang_hoa varchar(20),
	ngay_nhap date,
	ngay_xuat date,
	so_luong int
	primary key (ma_kho_hang,ma_hang_hoa)
	foreign key (ma_kho_hang)
	references kho_hang(ma_kho_hang),
	foreign key (ma_hang_hoa)
	references hang_hoa(ma_hang_hoa)
)
GO
CREATE TABLE nhan_vien(
	ma_nv varchar(20) PRIMARY KEY,
	ten_nv nvarchar(40),
	sdt varchar(12)
)
GO
CREATE TABLE khach_hang(
	ma_kh varchar(20) PRIMARY KEY,
	ten_kh nvarchar(50),
	sdt varchar(12)
)
GO
CREATE TABLE hoa_don(
	ma_hd varchar(20) PRIMARY KEY,
	ma_kh varchar(20),
	ma_nv varchar(20),
	ma_hang_hoa varchar(20),
	ngay_lap date,
	so_luong int,
	thanh_tien float,
	trang_thai varchar(20)
	foreign key(ma_kh)
	references khach_hang(ma_kh),
	foreign key(ma_nv)
	references nhan_vien(ma_nv),
	foreign key(ma_hang_hoa)
	references hang_hoa(ma_hang_hoa),
)
GO
INSERT INTO hang_hoa
VALUES('HH001','GuGi','1-1-1999','1-1-2000',50000,''),
	  ('HH002','Audi','1-1-1999','1-1-2000',70000,'')
GO
INSERT INTO kho_hang
VALUES('KhoHang1','ABC/BCA'),
		('KhoHang2','AAA/BBB')
GO
INSERT INTO khohang_hanghoa
VALUES('KhoHang1','HH001','1-5-1999','2-5-1999',400),
('KhoHang2','HH002','1-5-1999','2-5-1999',400)
GO
INSERT INTO dang_nhap
VALUES ('Admin1','1','Admin'),
('Admin','1','Admin')
GO
select * from dang_nhap
