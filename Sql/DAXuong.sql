USE master;
GO
CREATE DATABASE DAXuong;
GO
USE DAXuong;
GO
CREATE TABLE nhan_vien(
	ma_nv varchar(20) PRIMARY KEY,
	ten_nv nvarchar(40),
	sdt varchar(12),
	email varchar(50),
	Unique(sdt,email)
)
GO
CREATE TABLE dang_nhap(
	tai_khoan varchar(100) PRIMARY KEY,
	mat_khau varchar(50) NOT NULL,
	role varchar(10) NOT NULL,
	ma_nv varchar(20)
	foreign key (ma_nv)
	references nhan_vien(ma_nv)
)
GO   
CREATE TABLE hang_hoa(
	ma_hang_hoa varchar(20) PRIMARY KEY,
	ten nvarchar(50),
	mota nvarchar(200),
	noisx nvarchar(50)
)
GO
CREATE TABLE chitiet_hanghoa(
	id int identity primary key not null,
	ma_hang_hoa varchar(20),
	size nvarchar(5),
	mau_sac nvarchar(50),
	gia_ban float,
	gia_nhap float,
	hinh varchar(200),
	soluong int
	foreign key (ma_hang_hoa)
	references hang_hoa(ma_hang_hoa)
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
	ngay_lap date,
	trang_thai varchar(20),
	tongtien float,
	foreign key(ma_kh)
	references khach_hang(ma_kh),
	foreign key(ma_nv)
	references nhan_vien(ma_nv)
)
GO
CREATE TABLE chi_tiet_hoa_don(
	macthd int identity primary key not null,
	ma_hd varchar(20) not null,
	ma_chitiet_hanghoa int not null,
	so_luong int,
	dongia float,
	foreign key(ma_hd)
	references hoa_don(ma_hd),
	foreign key(ma_chitiet_hanghoa)
	references chitiet_hanghoa(id)
)
GO
INSERT INTO nhan_vien
VALUES  ('ADMIN','','',''),
        ('NV001',N'Nguyễn Thị Thúy Liễu','0378310473','lieuntt03@gmail.com'),
		('NV002',N'Hồ Thị Mộng Hoa','0398342473','hoahtm@gmail.com'),
	    ('NV003',N'Lê Hồng Ngọc Cúc','0318362634','cuclhn@gmail.com'),
        ('NV004',N'Bùi Thị Hằng Nga','0368373673','ngabth@gmail.com'),
        ('NV005',N'Võ Thị Ánh Mai','0394736748','maivta@gmail.com'),
		('NV006',N'Siêu Trộm','000000000','sieutrom01637@gmail.com'),
		('NV007',N'Ông chủ','1111111111','ledang01637@gmail.com')
 GO
INSERT INTO dang_nhap
VALUES ('admin','1','admin','NV007'),
	   ('dang','1','nhanvien','NV007'),
	   ('nhanvien','1','nhanvien','NV006')
GO
INSERT INTO hang_hoa
VALUES('HH001','GuGi',N'Áo Gugi nổi tiếng số 1 TG','VN'),
	  ('HH002','Audi',N'Quần sợi bông','VN'),
	  ('HH003','Nubacachi','Áo thun','Amerycan'),
	  ('HH004','Butagi','Quần sợi vải','Canada')
GO
INSERT INTO chitiet_hanghoa
VALUES ('HH001','XXL',N'Đỏ',9000000,4500000,'',30),
('HH002','XL',N'Đỏ',8000000,7500000,'',60),
('HH003','M',N'Đỏ',9600000,4500000,'',10),
('HH004','S',N'Đỏ',6000000,4900000,'',35)
GO
INSERT INTO khach_hang
VALUES ('KH001',N'Nguyễn Thị Số 1','038843979'),
	   ('KH002',N'Lê Thị Số 2',''),
	   ('KH003',N'Hồ Văn Số 3','093436374'),
	   ('KH004',N'Mai Thị Số 4','037478953'),
	   ('KH005',N'Lưu Huỳnh Số 5','')
GO