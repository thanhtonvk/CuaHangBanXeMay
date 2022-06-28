use master
go
create database QuanLyCuaHangXeMay
go
use QuanLyCuaHangXeMay
go
create table TaiKhoan
(
    TenDangNhap nvarchar(20) primary key,
    MatKhau     nvarchar(20) not null,
    LoaiTK      nvarchar(10)
)
go
insert into TaiKhoan values('admin','admin','admin')
go
create table LoaiSanPham
(
    MaLoai  int identity primary key,
    TenLoai nvarchar(50)
)
go
create table DaiLy
(
    MaDL   int identity primary key,
    TenDL  nvarchar(50),
    SDT    char(10),
    DiaChi nvarchar(100)
)
go
create table NhanVien
(
    MaNV   int identity primary key,
    TenNV  nvarchar(50),
    SDT    char(10),
    DiaChi nvarchar(50),
)
go
create table SanPham
(
    MaSP   int identity primary key,
    TenSP  nvarchar(50),
    MaLoai int not null,
    NgaySX date,
    ThongSoKyThuat  nvarchar(max),
    SoLo   int,
    DonGia int
)

go

create table HoaDonBan
(
    MaHD     int identity primary key,
    NgayBan  date,
    TenKhach nvarchar(50),
    SDT      char(10),
    DiaChi   nvarchar(100),
    MaNV     int not null,
    TongTien int
)
go

create table ChiTietHDB
(
ID int identity primary key,
    MaHD      int not null,
    MaSP      int not null,
    GiaBan    int,
    SoLuong   int,
    ThanhTien int
)
go
create table HoaDonNhap
(
    MaHD     int identity primary key,
    NgayNhap date,
    MaDL     int,
    TongTien int
)

go
create table ChiTietHDN
(
ID int identity primary key,
    MaHD      int not null,
    MaSP      int not null,
    GiaNhap   int,
    SoLuong   int,
    ThanhTien int
)
go
create proc GetHoaDonNhap
as
begin
    select HoaDonNhap.MaHD, NgayNhap, DaiLy.TenDL, SUM(ChiTietHDN.GiaNhap * ChiTietHDN.SoLuong) [Tổng tiền]
    from HoaDonNhap,
         ChiTietHDN,
         DaiLy
    where HoaDonNhap.MaHD = ChiTietHDN.MaHD
      and HoaDonNhap.MaDL = DaiLy.MaDL
    group by HoaDonNhap.MaHD, NgayNhap, DaiLy.TenDL
end
go
create proc GetChiTietHoaDonNhap @MaHD int
as
begin
    select ChiTietHDN.ID, ChiTietHDN.MaSP, ChiTietHDN.SoLuong, ChiTietHDN.GiaNhap, ChiTietHDN.GiaNhap * ChiTietHDN.SoLuong[Thành tiền]
    from HoaDonNhap,
         ChiTietHDN
    where HoaDonNhap.MaHD = ChiTietHDN.MaHD
      and HoaDonNhap.MaHD = @MaHD
end
go
create proc GetHoaDonBan
as
begin
    select HoaDonBan.MaHD,
         
           NgayBan,
           TenKhach,
           HoaDonBan.SDT,
           HoaDonBan.DiaChi,
           NhanVien.TenNV,
           SUM(ChiTietHDB.SoLuong * ChiTietHDB.GiaBan) [Tổng tiền]
    from HoaDonBan,
         ChiTietHDB,
         NhanVien
    where HoaDonBan.MaHD = ChiTietHDB.MaHD
      and NhanVien.MaNV = HoaDonBan.MaNV
    group by HoaDonBan.MaHD, NgayBan, TenKhach, HoaDonBan.SDT, HoaDonBan.DiaChi, NhanVien.TenNV
end
go
create proc getChiTietHoaDonBan @MaHD int
as
begin
    select ChiTietHDB.ID,SanPham.TenSP, ChiTietHDB.SoLuong, ChiTietHDB.GiaBan, ChiTietHDB.GiaBan * ChiTietHDB.SoLuong[Thành tiền]
    from HoaDonBan,
         ChiTietHDB,
         SanPham
    where HoaDonBan.MaHD = ChiTietHDB.MaHD
      and ChiTietHDB.MaSP = SanPham.MaSP
      and HoaDonBan.MaHD = @MaHD
end 

go
create proc ThongKeTheoNgay
as
begin
    select NgayBan,Sum(GiaBan*SoLuong)[TongTien] from HoaDonBan,ChiTietHDB where HoaDonBan.MaHD = ChiTietHDB.MaHD group by NgayBan
end
go
create proc ThongKeSPBanChay
as
begin
    select top 5 SanPham.TenSP,SanPham.DonGia,Sum(ChiTietHDB.SoLuong)[SoLuongBan] 
    from HoaDonBan,ChiTietHDB,SanPham 
    where HoaDonBan.MaHD = ChiTietHDB.MaHD and SanPham.MaSP = ChiTietHDB.MaSP
    group by SanPham.TenSP,SanPham.DonGia

end

select * from ChiTietHDB
select * from HoaDonBan