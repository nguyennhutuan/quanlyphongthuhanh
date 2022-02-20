create database LTMT1_K10_N1_NguyenNhuTuan_QLPTH
use LTMT1_K10_N1_NguyenNhuTuan_QLPTH

create table phongmay
(
	sophong nchar(4) primary key,
	nguoiql nvarchar(50) not null,
	somay int not null
)
insert into phongmay values('p205', N'Bùi Thị Hòa', 40)
insert into phongmay values('p305', N'Trần Viết Cường', 40)
insert into phongmay values('p203', N'Đỗ Văn Uy', 40)

create table thuchanh
(
	sophong nchar(4) foreign key references phongmay(sophong),
	mamh char(4) foreign key references monhoc(mamh),
	ngayth date not null,
	buoith nchar(10) not null,
	giaovienth nvarchar(50) not null
)
insert into thuchanh values('p205', 'mh01', 03-11-2021, N'sáng', N'Trần Viết Cường')
insert into thuchanh values('p305', 'mh02', 01-11-2021, N'sáng', N'Bùi Thị Hòa')
insert into thuchanh values('p203', 'mh03', 10-11-2021, N'chiều', N'Đỗ Văn Uy')

create table monhoc
(
	mamh char(4) primary key,
	tenmh nvarchar(40) not null,
	sodvht int not null
)
insert into monhoc values('mh01', N'cơ sở dữ liệu', 2)
insert into monhoc values('mh02', N'lập trình ứng dụng', 2)
insert into monhoc values('mh03', N'cấu trúc dữ liệu và giải thuật', 2)
