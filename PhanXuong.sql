--tạo database và các bảng
CREATE DATABASE PhanXuong
go
use PhanXuong
go
if EXISTS (select * from sysobjects where name='tNuocSX')
drop table tNuocSX
go
create TABLE tNuocSX
(
	manuoc char(6) not null PRIMARY key,
	tennuoc nvarchar(30)
)
if EXISTS (select * from sysobjects where name='tXe')
drop table tXe
go
create TABLE tXe
(
	maxe char(4) not null PRIMARY key,
	tenxe nvarchar(30),
	ghichu nvarchar(30)
)
if EXISTS (select * from sysobjects where name='tTho')
drop table tTho
go
create TABLE tTho
(
	matho char(4) not null PRIMARY key,
	tentho nvarchar(30),
	bactho nvarchar(20)
)
if exists (SELECT * from sysobjects where name='tPhuKien')
drop TABLE tPhuKien
go
CREATE TABLE tPhuKien
(
	mapk char(4) not null PRIMARY key,
	tenpk nvarchar(40),
	manuoc char(6),
	dongia float,
	soluongtontai int,
	ghichu nvarchar(40)
FOREIGN key (manuoc) REFERENCES tNuocSX (manuoc)
)
if EXISTS (select * from sysobjects where name='tThanhPhan')
drop table tThanhPhan
go
create TABLE tThanhPhan
(
	mathanhphan char(4) not null primary key,
	maxe char(4),
	mapk char(4),
	donvitinh nvarchar(10) DEFAULT 'Cái',
	soluong int
	foreign key (maxe) REFERENCES tXe (maxe),
	FOREIGN key (mapk) REFERENCES tPhuKien (mapk)
)
if EXISTS (select * from sysobjects where name='tPhanCong')
drop table tPhanCong
go
create TABLE tPhanCong
(
	maphancong char(4) not null primary key,
	matho char(4),
	maxe char(4)
	FOREIGN key (matho) REFERENCES tTho (matho),
	FOREIGN key (maxe) REFERENCES tXe (maxe)
)
--thêm dữ liệu vào các bảng
insert into tNuocSX values ('EURO01',N'France'),
('ASIA01',N'Japan'),
('ASIA02',N'Việt Nam')
INSERT into tXe VALUES ('AU11',N'Audi Logale',N'thuế giá trị tăng cao'),
('VI10',N'Vinfast Lux 2.0',N'xe nội'),
('GE09',N'Volkahaghen',N'xe nhập khẩu')
insert into tTho values ('MS01',N'Nguyễn Văn Kiều',N'Diamond'),
('MS02',N'Albert Chel',N'Master'),
('MS03',N'Du Hiểu Ký',N'Platinum')
Insert into tPhuKien values ('PK10',N'lốp xe','EURO01',25000000,10,N'Lốp xe nhập từ Châu Âu'),
('PK12',N'đèn xe','ASIA01',15500000,2,N'đèn xe jin Nhật Bản'),
('PK11',N'mâm xe','EURO01',100000000,14,N'mâm xe độ')
INSERT into tPhanCong values ('PC01','MS01','VI10'),
('PC02','MS02','VI10'),
('PC03','MS03','GE09')
Insert into tThanhPhan VALUES ('TP01','GE09','PK10',N'cái',2),
('TP02','VI10','PK12',N'cái',4),
('TP03','VI10','PK11',N'cái',4)