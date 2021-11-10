CREATE DATABASE QLST
GO

USE QLST
GO


CREATE TABLE KhachHang(
        MaKH nvarchar (20) PRIMARY KEY,
		TenKH nvarchar (50) null,
		NgaySinh date null,
		DiaChi nvarchar (70) null,
		Sdt nvarchar (10) null,

)


CREATE TABLE ChucVu(
       MaCV nvarchar (20) PRIMARY KEY,
	   TenCV nvarchar (40) null,

)
GO


CREATE TABLE PhieuGiaoCa(
        MaPGC nvarchar (20)  PRIMARY KEY,
		Ca    nvarchar(20) null,

)
GO


CREATE TABLE QuayThuNgan(
        MaQTN nvarchar (20) PRIMARY KEY,
		TenQTN nvarchar (40) null,

)
GO


CREATE TABLE NhanVien(
       MaNV nvarchar (20) PRIMARY KEY,
	   TenNV nvarchar (50) null,
	   NgaySinh date null,
	   GioiTinh nvarchar (10) null,
	   DiaChi nvarchar (50) null,
	   Sdt nvarchar (10) null,
	   TenDangNhap nvarchar (40) not null,
	   MatKhau nvarchar (40) not null,

	   MaCV nvarchar (20) not null,
	   MaQTN nvarchar (20) not null,
	   
	   FOREIGN KEY (MaCV) REFERENCES Chucvu(MaCV),
	   FOREIGN KEY (MaQTN) REFERENCES Quaythungan(MaQTN),
)
GO

	

CREATE TABLE HoaDon(
       MaHD nvarchar (20) PRIMARY KEY,
	   NgayTao date not null,
	   TongTien float not null,
	   MaNV nvarchar (20) not null,
	   MaKH nvarchar (20) not null,
	   
	   FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	   FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
)
GO

CREATE TABLE KhoHang(
         MaK nvarchar (20) PRIMARY KEY,
		 Tenk nvarchar (50) null,
		 DiaDiem nvarchar (50) null,

)
GO


CREATE TABLE QuayHang(
      MaQH nvarchar (20) PRIMARY KEY,
	  Tenqh nvarchar (50) null,

)
GO


CREATE TABLE PhieuThongKe(
            MaPTK nvarchar (20) PRIMARY KEY,
			Ngaylap date not null,
			MaNV nvarchar (20) not null,
			MaK nvarchar (20) not null,

			FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
			FOREIGN KEY (MaK) REFERENCES KhoHang(MaK),
) 
GO


CREATE TABLE HangHoa(
           MaHH nvarchar (20) PRIMARY KEY,
		   TenHH nvarchar (50) null,
		   Loai  nvarchar (50) null,
		   DonGia float null,
		   ĐVT nvarchar (20) null,
		   SoLuong int null,
		   MaQH nvarchar (20),
		   MaPTK nvarchar (20),

		   FOREIGN KEY (MaQH) REFERENCES QuayHang(MaQH),
		   FOREIGN KEY (MaPTK) REFERENCES PhieuThongKe(MaPTK),
	 
) 
GO


CREATE TABLE ChiTietPGC(
       MaNV nvarchar (20) not null,
	   MaPGC nvarchar (20) not null,
	   Ngay date,
       PRIMARY KEY (MaNV, MaPGC),
  	   FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	   FOREIGN KEY (MaPGC) REFERENCES PhieuGiaoCa(MaPGC),

)
GO


CREATE TABLE NhaCungCap(
         MaNCC nvarchar (20) PRIMARY KEY,
		 TenNCC nvarchar (50) null,
		 DiaDiem nvarchar (60) null,
		 SĐT nvarchar (10) null,

)
GO

CREATE TABLE PhieuNhap(
      MaPN nvarchar (20) PRIMARY KEY,
	  NgayNhap date null,
	  MaNCC nvarchar (20) not null,
	  MaK nvarchar (20) not null,

	  FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
	  FOREIGN KEY (MaK) REFERENCES KhoHang(MaK),
)
GO



CREATE TABLE ChitietHD(
    MaHD nvarchar (20) not null,
	MaHH nvarchar (20) not null,

	DonGia int null,
	SoLuong int null,
	PRIMARY KEY (MaHD, MaHH),
	FOREIGN KEY (MaHD) REFERENCES Hoadon(MaHD),
	FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH),
)
GO

CREATE TABLE ChitietPN(
           MaPN nvarchar (20) not null,
		   MaHH nvarchar (20) not null,
		   DonGia float null,
		   SoLuong int null,
		   PRIMARY KEY (MaPN, MaHH),
		   FOREIGN KEY (MaPN) REFERENCES Phieunhap(MaPN),
		   FOREIGN KEY (MaHH) REFERENCES HangHoa (MaHH),
) 
GO


INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH001',N'Phan Thị Anh',CAST(N'1998-12-01' AS Date),N'Quận 9, TP.HCM','0935852875');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH002',N'Phan Thị Bá',CAST(N'2003-12-01' AS Date),N'Quận 9, TP.HCM','0935852845');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH003',N'Phan Thị Chiêu',CAST(N'2001-12-01' AS Date),N'Quận 9, TP.HCM','0935852898');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH004',N'Phan Thị Diệu',CAST(N'2002-12-01' AS Date),N'Quận 8, TP.HCM','0935852098');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH005',N'Phan Thị Hà',CAST(N'1997-12-01' AS Date),N'Quận 8, TP.HCM','0935852094');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH006',N'Phan Thị Khó',CAST(N'1976-12-01' AS Date),N'Quận 8, TP.HCM','0935852834');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH007',N'Phan Thị Bao',CAST(N'2000-12-01' AS Date),N'Quận 8, TP.HCM','0935852867');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH008',N'Phan Thị Bắp',CAST(N'1954-12-01' AS Date),N'Quận 9, TP.HCM','0935852812');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH009',N'Nguyễn Công Thành',CAST(N'2010-12-01' AS Date),N'Quận 9, TP.HCM','09358528764');
INSERT KhachHang(MaKH,TenKH,NgaySinh,DiaChi,Sdt)VALUES ('KH010',N'Nguyễn Công Hào',CAST(N'2005-12-01' AS Date),N'Quận 9, TP.HCM','09358528098');
GO

INSERT ChucVu(MaCV,TenCV)VALUES ('QL',N'Quản lý');
INSERT ChucVu(MaCV,TenCV)VALUES ('NV','Nhân viên');
GO


---------- Bảng quầy thu ngân  ----------
INSERT QuayThuNgan(MaQTN, TenQTN)VALUES ('QTN001',N'Quầy thu ngân 1');
INSERT QuayThuNgan(MaQTN, TenQTN)VALUES ('QTN002',N'Quầy thu ngân 2');
INSERT QuayThuNgan(MaQTN, TenQTN)VALUES ('QTN003',N'Quầy thu ngân 3');
INSERT QuayThuNgan(MaQTN, TenQTN)VALUES ('QTN004',N'Quầy thu ngân 4');
GO



INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV001',N'Nguyễn Công Chí',CAST(N'2001-05-01' AS Date),'Nam',N'Quận 9, TP.HCM','0328655347','chi123','12345','QL','QTN001');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV002',N'Bùi Văn Tân',CAST(N'2000-06-04' AS Date),'Nam',N'Quận 9, TP.HCM','0328655347','tan123','12345','NV','QTN001');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV003',N'Võ Văn Trí',CAST(N'1998-07-08' AS Date),'Nam',N'Quận Thủ Đức, TP.HCM','0328655347','tri123','12346','NV','QTN002');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV004',N'Huỳnh Xuân Lãm',CAST(N'1998-08-06' AS Date),'Nam',N'Quận 9, TP.HCM','0328655347','lam123','12347','NV','QTN002');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV005',N'Hồ Ngọc Thống',CAST(N'2002-09-12' AS Date),'Nam',N'Quận Thủ Đức, TP.HCM','0328655347','thong123','12348','NV','QTN003');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV006',N'Nguyễn Thị Hồng',CAST(N'2001-05-16' AS Date),N'Nữ',N'Quận 9, TP.HCM','0328655347','hong123','12349','NV','QTN004');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV007',N'Ngô Văn Thứ',CAST(N'2001-05-18' AS Date),'Nam',N'Quận Thủ Đức, TP.HCM','0328655347','thu123','123410','NV','QTN004');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV008',N'Võ Thành Long',CAST(N'2001-06-10' AS Date),'Nam',N'Quận Thủ Đức, TP.HCM','0328655347','long123','123411','NV','QTN003');
INSERT NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,Sdt,TenDangNhap,MatKhau,MaCV,MaQTN)VALUES ('NV009',N'Bùi Tấn Hồng',CAST(N'2001-05-25' AS Date),'Nam',N'Quận 9, TP.HCM','0328655347','hong123','123412','NV','QTN004');
GO






INSERT PhieuGiaoCa(MaPGC,Ca)VALUES ('PGC001','6:00 - 11:00');
INSERT PhieuGiaoCa(MaPGC,Ca)VALUES ('PGC002','11:00 - 17:00');
INSERT PhieuGiaoCa(MaPGC,Ca)VALUES ('PGC003','17:00 - 22:00');
GO



INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV001',CAST(N'2021-10-10' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV002',CAST(N'2021-10-10' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV003',CAST(N'2021-10-10' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV004',CAST(N'2021-10-16' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV005',CAST(N'2021-10-16' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV006',CAST(N'2021-10-16' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV007',CAST(N'2021-10-17' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV008',CAST(N'2021-10-17' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV009',CAST(N'2021-10-17' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV001',CAST(N'2021-10-18' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV002',CAST(N'2021-10-18' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC003','NV003',CAST(N'2021-10-18' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV004',CAST(N'2021-10-19' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV005',CAST(N'2021-10-19' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC002','NV006',CAST(N'2021-10-19' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV007',CAST(N'2021-10-20' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV008',CAST(N'2021-10-20' AS Date));
INSERT ChitietPGC(MaPGC,MaNV,Ngay)VALUES ('PGC001','NV009',CAST(N'2021-10-20' AS Date));
GO




INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD001',CAST(N'2021-10-19' AS Date),18000,'NV001','KH001');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD002',CAST(N'2021-10-18' AS Date),12000,'NV002','KH003');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD003',CAST(N'2021-10-21' AS Date),29000,'NV003','KH007');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD004',CAST(N'2021-10-17' AS Date),29000,'NV004','KH009');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD005',CAST(N'2021-10-21' AS Date),60000,'NV005','KH002');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD006',CAST(N'2021-10-22' AS Date),30000,'NV006','KH010');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD007',CAST(N'2021-10-22' AS Date),14000,'NV007','KH004');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD008',CAST(N'2021-10-21' AS Date),28000,'NV008','KH005');
INSERT Hoadon(MaHD,NgayTao,TongTien,MaNV,MaKH)VALUES ('HD009',CAST(N'2021-10-21' AS Date),12000,'NV009','KH006');
GO


INSERT KhoHang(MaK,Tenk,DiaDiem)VALUES ('KHOH001',N'Kho hàng 1',N'223/45 Quận 9, TP.HCM');
INSERT KhoHang(MaK,Tenk,DiaDiem)VALUES ('KHOH002',N'Kho hàng 2',N'223/46 Quận 9, TP.HCM');
INSERT KhoHang(MaK,Tenk,DiaDiem)VALUES ('KHOH003',N'Kho hàng 3',N'223/47 Quận 9, TP.HCM');
INSERT KhoHang(MaK,Tenk,DiaDiem)VALUES ('KHOH004',N'Kho hàng 4',N'223/48 Quận 9, TP.HCM');
INSERT KhoHang(MaK,Tenk,DiaDiem)VALUES ('KHOH005',N'Kho hàng 5',N'223/49 Quận 9, TP.HCM');
GO



INSERT QuayHang(MaQH,Tenqh)VALUES ('QH001',N'Quầy hàng A1');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH002',N'Quầy hàng A2');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH003',N'Quầy hàng A3');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH004',N'Quầy hàng A4');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH005',N'Quầy hàng B1');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH006',N'Quầy hàng B2');
INSERT QuayHang(MaQH,Tenqh)VALUES ('QH007',N'Quầy hàng B3');
GO



INSERT PhieuThongKe(MaPTK,Ngaylap,MaNV,MaK)VALUES ('PTK001',CAST (N'2021-10-24' AS Date),'NV001','KHOH001');


INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH001',N'Sữa chua',N'Đồ ăn lạnh',6000,N'Hộp',300,'QH001','PTK001');
INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH002',N'Kem',N'Đồ ăn lạnh',3000,N'Cây',400,'QH001','PTK001');
INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH003',N'Nước mắm',N'Gia vị',29000,N'Chai',500,'QH002','PTK001');
INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH004',N'Bột canh',N'Gia vị',14000,N'Bịch',400,'QH002','PTK001');
INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH005',N'Xì dầu',N'Gia vị',12000,N'Chai',300,'QH002','PTK001');
INSERT HangHoa(MaHH,TenHH,Loai,DonGia,ĐVT,SoLuong,MaQH,MaPTK)VALUES ('HH006',N'Bột nêm',N'Gia vị',7000,N'Bịch',400,'QH002','PTK001');
GO


INSERT NhaCungCap(MaNCC,TenNCC,DiaDiem,SĐT)VALUES('NCC001',N'Nguyễn Cẩm Giang',N'An Chấn, Tuy An, Phú Yên','039876521');
GO


INSERT PhieuNhap(MaPN,NgayNhap,MaNCC,MaK)VALUES ('PN001',CAST(N'2021-10-19' AS Date),'NCC001','KHOH001');
GO


INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD001','HH001',6000,3);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD002','HH001',6000,2);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD003','HH003',29000,1);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD004','HH003',29000,1);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD005','HH001',6000,10);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD006','HH002',3000,10);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD007','HH004',14000,1);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD008','HH004',14000,2);
INSERT ChitietHD(MaHD,MaHH,DonGia,SoLuong)VALUES ('HD009','HH005',12000,1);
GO

INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH001',4000,310);
INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH002',1000,410);
INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH003',24000,502);
INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH004',10000,403);
INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH005',8000,301);
INSERT ChitietPN(MaPN,MaHH,DonGia,SoLuong)VALUES ('PN001','HH006',4000,410);
GO






















































-- test

----------- Câu lệnh query ------------
select *
from NhanVien

select *
from Hoadon

select * 
from HangHoa


select MaNV as [Mã nhân viên],TenNV as [Tên nhân viên],GioiTinh as [Giới tính],NgaySinh as [Ngày sinh],DiaChi as [Địa chỉ],Sdt as [Số điện thoại],MaCV as [Chức vụ], NhanVien.MaQTN as [Mã quầy thu ngân] from NhanVien,Quaythungan where NhanVien.MaQTN = Quaythungan.MaQTN


select *
from Hoadon inner join Chitiethd on Hoadon.MaHD = Chitiethd.MaHD;


alter table HangHoa alter column DonGia int;






--------- Thêm cột trong sql ----------
alter table NhanVien add MaPGC int;
alter table HangHoa add MaPTK int not null;





--------- Xóa bảng trong sql ----------
drop table Chucvu
drop table NhanVien
drop table PhieuGiaoCa
drop table KhachHang



--------- Xóa dữ liệu trong bảng ------------
delete from Chucvu
delete from NhanVien
delete from HangHoa


--------- Sửa cột trong sql ----------------
alter table Chitiethd alter column DonGia float;


--------- Xóa hàng trong sql --------------
delete from KhoHang where DiaDiem = N'223/46 Quận 9, TP.HCM';