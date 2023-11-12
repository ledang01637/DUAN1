USE master;
GO
CREATE DATABASE DUAN1;
GO
USE DUAN1;
GO
CREATE TABLE dang_nhap(
	tai_khoan varchar(20) PRIMARY KEY,
	mat_khau varchar(20) NOT NULL,
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