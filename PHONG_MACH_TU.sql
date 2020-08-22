CREATE DATABASE PHONG_MACH_TU
GO
USE PHONG_MACH_TU
create table LOAI_BENH(
	Loai_benh nvarchar(50),
	ID_loai_benh int not null identity primary key
)
create table DON_VI_TINH(
	Don_vi_tinh nvarchar(10),
	ID_don_vi_tinh int not null identity primary key
)
create table CACH_DUNG(
	Cach_dung nvarchar(50),
	ID_cach_dung int not null identity primary key
)
CREATE TABLE THUOC(
	Ten_thuoc nvarchar (20) not null,
	ID_thuoc int not null identity primary key,
	ID_don_vi_tinh int,
	ID_cach_dung int,
	Gia_don_vi float not null
)
create table PHIEU_KHAM_BENH(
	ID_phieu_kham_benh int not null identity primary key,
	ID_benh_nhan int not null,
	Ngay date,
	Trieu_chung nvarchar(100),
	ID_loai_benh int
)
create table DON_THUOC(
	ID_thuoc int not null,
	ID_phieu_kham_benh int not null,
	So_luong int not null,
	constraint PK_DON_THUOC primary key (ID_thuoc,ID_phieu_kham_benh)
)
create table BENH_NHAN(
	Ho_ten nvarchar(50) not null,
	ID_benh_nhan int not null identity primary key,
	Gioi_tinh nvarchar(10),
	Nam_sinh int,
	Dia_chi nvarchar(100)
)
create table QUY_DINH(
	Loai varchar(20) not null primary key,
	So_luong int not null
)
create table USERS(
	Ho_ten nvarchar(50) not null,
	Ten_dang_nhap nchar(20) not null primary key,
	Mat_khau nvarchar(10) not null,
	La_chu_phong_mach bit not null
)
go
use PHONG_MACH_TU
alter table THUOC add constraint FK_THUOC_DON_VI_TINH foreign key (ID_don_vi_tinh) references DON_VI_TINH(ID_don_vi_tinh)
alter table THUOC add constraint FK_THUOC_CACH_DUNG foreign key (ID_cach_dung) references CACH_DUNG(ID_cach_dung)
alter table PHIEU_KHAM_BENH add constraint FK_PHIEU_KHAM_BENH_BENH_NHAN foreign key (ID_benh_nhan) references BENH_NHAN(ID_benh_nhan)
alter table PHIEU_KHAM_BENH add constraint FK_PHIEU_KHAM_BENH_LOAI_BENH foreign key (ID_loai_benh) references LOAI_BENH(ID_loai_benh)
alter table DON_THUOC add constraint FK_DON_THUOC_THUOC foreign key (ID_thuoc) references THUOC(ID_thuoc)
alter table DON_THUOC add constraint FK_DON_THUOC_PHIEU_KHAM_BENH foreign key (ID_phieu_kham_benh) references PHIEU_KHAM_BENH(ID_phieu_kham_benh)
go
use PHONG_MACH_TU
insert into DON_VI_TINH(Don_vi_tinh) values (N'Chai')
insert into DON_VI_TINH(Don_vi_tinh) values (N'Viên')
insert into CACH_DUNG(Cach_dung) values (N'1')
insert into CACH_DUNG(Cach_dung) values (N'2')
insert into CACH_DUNG(Cach_dung) values (N'3')
insert into CACH_DUNG(Cach_dung) values (N'4')
insert into LOAI_BENH(Loai_benh) values (N'Trĩ')
insert into LOAI_BENH(Loai_benh) values (N'Cảm')
insert into LOAI_BENH(Loai_benh) values (N'Tiêu chảy')
insert into LOAI_BENH(Loai_benh) values (N'Đau đầu')
insert into LOAI_BENH(Loai_benh) values (N'Corona')
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 1',1,3,100.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 2',1,1,30.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 3',2,2,70.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 4',1,4,80.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 5',2,2,60.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 6',2,4,120.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 7',1,3,100.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 8',1,2,90.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 9',2,1,40.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 10',1,1,20.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 11',2,4,60.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 12',2,4,110.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 13',2,2,110.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 14',2,3,150.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 15',1,1,90.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 16',1,3,20.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 17',1,1,60.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 18',2,2,70.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 19',1,3,80.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 20',1,3,80.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 21',2,2,100.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 22',1,4,80.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 23',1,2,50.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 24',2,1,30.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 25',1,3,60.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 26',2,4,70.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 27',2,3,90.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 28',2,1,60.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 29',2,3,80.0)
insert into THUOC(Ten_thuoc, ID_don_vi_tinh, ID_cach_dung, Gia_don_vi) values (N'Thuốc 30',2,2,100.0)
insert into USERS values (N'Nguyễn Văn A','nva','thichanpho',0)
insert into USERS values (N'Nguyễn Thị B','admin','password',1)
insert into USERS values (N'Trần Thị C','ntc','thichancom',0)
insert into QUY_DINH values ('Benh_nhan',40)
insert into QUY_DINH values ('Don_vi_tinh',2)
insert into QUY_DINH values ('Cach_dung',4)
insert into QUY_DINH values ('Loai_benh',5)
insert into QUY_DINH values ('Thuoc',30)
go
