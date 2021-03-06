USE [master]
GO
/****** Object:  Database [QUANLYDIEM]    Script Date: 2017-06-02 3:39:15 PM ******/
CREATE DATABASE [QUANLYDIEM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYDIEM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\Backup\QUANLYDIEM.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYDIEM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\Backup\QUANLYDIEM_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYDIEM] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYDIEM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYDIEM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYDIEM] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYDIEM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYDIEM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYDIEM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYDIEM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYDIEM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYDIEM] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYDIEM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYDIEM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYDIEM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYDIEM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYDIEM]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatDiem]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CapNhatDiem](@malhp varchar(10))
as
begin
select s.MaSV, s.TenSV, Diem_01, Diem_02, Diem_07,m.TenMH
from SinhVien S, BangDiem B, LopHocPhan L, MonHoc M
where  s.MaSV = B.MaSV and L.MaLHP = B.MaLHP and m.MaMH = l.MaMH and l.MaLHP = @malhp

end

GO
/****** Object:  StoredProcedure [dbo].[getsinhvienma]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getsinhvienma](@ma char(10)) 
as
begin
select *from SinhVien where @ma = MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[GetTenLop_malop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetTenLop_malop](@malop varchar(10))
as
begin
select TenLop
from Lop where MaLop  =@malop
end

GO
/****** Object:  StoredProcedure [dbo].[GetTenMon_malhp]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetTenMon_malhp](@malhp varchar(10))
as
begin
select TenMH,HocKi,namhoc,TenGV
from LopHocPhan,MonHoc,LichGiangDay,GiangVien
where LopHocPhan.MaMH = MonHoc.MaMH and LopHocPhan.MaLHP = LichGiangDay.MaLHP and LichGiangDay.MaGV = GiangVien.MaGV and LopHocPhan.MaLHP = @malhp
end
GO
/****** Object:  StoredProcedure [dbo].[getthongtinsv]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getthongtinsv](@masv varchar(10),@hocki nvarchar(10), @namhoc varchar(20))
as
begin
select TenSV,dbo.TinhDiemTichLuy1(@masv) as'diemtichluy',dbo.TONGTCNO_MASV(@masv) as 'tcno',dbo.TinhDiemTichLuy_MaSV_HocKi_NamHoc(@masv,@hocki,@namhoc) as 'tbhk' 
from SinhVien
where MaSV = @masv

end
GO
/****** Object:  StoredProcedure [dbo].[KetQuaHoctap]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KetQuaHoctap](@masv varchar(10))
as
begin
select namhoc as 'Năm học',HocKi as 'Học Kì',sum(SoTC) as 'Tổng TC',dbo.TinhDiemTichLuy_MaSV_HocKi_NamHoc(@masv,HocKi,namhoc) as 'TB học kì',dbo.TONGTCNO_MASV_HocKi_NamHoc(@masv,HocKi,namhoc) as 'TC nợ'
from SinhVien S, BangDiem B, LopHocPhan L,MonHoc M
where S.MaSV = B.MaSV and B.MaLHP = L.MaLHP and l.MaMH = m.MaMH and S.MaSV = @masv 
group by namhoc,HocKi
order by namhoc desc
end
GO
/****** Object:  StoredProcedure [dbo].[loadgiangvien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadgiangvien]
as
begin
select MaGV,TenGV,GioiTinhGV,SDT,tenkhoa
from  GiangVien left join Khoa
on GiangVien.MaKhoa = khoa.makhoa
end


GO
/****** Object:  StoredProcedure [dbo].[loadlop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadlop]
 as
 begin
 select MaLop,TenLop,SoLuongSV,l.MaGV,g.TenGV
 from Lop l,GiangVien g
 where l.MaGV = g.MaGV
 end
GO
/****** Object:  StoredProcedure [dbo].[LoadSinhVien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadSinhVien]
as 
begin
select MaSV,TenSV,NgaySinh,GioiTinhSV,QueQuan,L.TenLop
from sinhvien S,Lop L where S.MaLop = L.MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[loadtenlop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadtenlop]
as
begin
select TenLop from Lop
end
GO
/****** Object:  StoredProcedure [dbo].[suadiem]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suadiem](@malhp varchar(10),@masv varchar(10),@diem_01 float,@diem_02 float,@diem_07 float)
as
begin
update BangDiem set Diem_01 = @diem_01,Diem_02 = @diem_02,Diem_07 = @diem_07
where MaLHP = @malhp and MaSV = @masv
end
GO
/****** Object:  StoredProcedure [dbo].[Suagv]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Suagv](@MaGV varchar(10),@tengv nvarchar(100), @gioitinhgv nvarchar(10),@SDT varchar(12),@Tenkhoa nvarchar(100))
as
declare @Makhoa varchar(10)
set @Makhoa = (select MaKhoa from Khoa where TenKhoa= @Tenkhoa )
begin
update GiangVien set TenGV = @tengv,GioiTinhGV = @gioitinhgv,SDT = @SDT,makhoa=@Makhoa where magv = @MaGV
end


GO
/****** Object:  StoredProcedure [dbo].[sualop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sualop](@malop varchar(10),@tenlop nvarchar(100),@soluongsv int, @magv varchar(10))
 as
 begin
 update lop set TenLop = @tenlop, SoLuongSV = @soluongsv,MaGV = @magv where @malop = MaLop
 end
GO
/****** Object:  StoredProcedure [dbo].[suasinhvien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suasinhvien](@masv varchar(10),@tensv nvarchar(100), @ngaysinh datetime, @gioitinh nvarchar(5), @quequan nvarchar(100), @tenlop nvarchar(100) )
as
begin
declare @malop char(10) 
set @malop  = (select malop from Lop where  TenLop = @tenlop)
update sinhvien set TenSV = @tensv, NgaySinh = @ngaysinh,GioiTinhSV = @gioitinh, QueQuan = @quequan, MaLop = @malop where MaSV = @masv

end
GO
/****** Object:  StoredProcedure [dbo].[ThemGiangVien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[ThemGiangVien](@MaGV varchar(10),@tengv nvarchar(100), @gioitinhgv nvarchar(10),@SDT varchar(12),@TenKhoa nvarchar(100) )
as
declare @makhoa varchar(10)
set @makhoa = (select Makhoa from Khoa where TenKhoa = @TenKhoa)
begin
if exists (select magv from GiangVien where MaGV = @MaGV)
print 'Giang vien da ton tai'
else
insert into GiangVien values(@MaGV,@tengv,@gioitinhgv,@SDT,@makhoa)
end

GO
/****** Object:  StoredProcedure [dbo].[Themlop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Themlop](@malop char(10),@tenlop varchar(100),@soluongsv int, @magv char(10))
 as
 begin
 if exists(select MaLop from Lop where MaLop = @malop)
 print 'Mã Lớp đã tồn tại!'
 else
 insert into Lop values(@malop,@tenlop,@soluongsv,@magv)
 end
GO
/****** Object:  StoredProcedure [dbo].[themsinhvien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themsinhvien](@masv varchar(10),@ten nvarchar(100),@ngaysinh datetime,@gioitinh nvarchar(5),@quequan nvarchar(100),@tenlop nvarchar(50))
as 

begin
declare @malop varchar(10)
set @malop = (select malop from Lop where  TenLop = @tenlop)
if @masv = any(select masv from SinhVien ) print 'Trung ma sinh vien'
else
if @tenlop = ''   print 'Nhap vao lop hoc!'
else
if not exists (select malop from Lop where  TenLop = @tenlop) print 'Lop hoc khong ton tai!'
else 

insert into SinhVien values(@masv,@ten,@ngaysinh,@gioitinh,@quequan,@malop)

end

GO
/****** Object:  StoredProcedure [dbo].[ThongKeDiem_lop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[ThongKeDiem_lop](@malop varchar(10))
 as 
 begin
 select s.MaSV as'Mã',s.TenSV as 'Họ Tên',s.NgaySinh as 'Ngày Sinh',dbo.TinhDiemTichLuy1(s.MaSV) as 'Điểm TB HK',dbo.TINHTONGTC_MASV (s.MaSV) as 'Tổng TC',dbo.TONGTCNO_MASV(MaSV) as 'TC Nợ'
 from SinhVien s,Lop l
 where s.MaLop = l.MaLop and l.MaLop = @malop
 order by dbo.TinhDiemTichLuy1(s.MaSV) desc
 end

GO
/****** Object:  StoredProcedure [dbo].[thongkediem_malhp]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[thongkediem_malhp](@malhp varchar(10))
 as
 begin
 select S.MaSV as 'Mã',S.TenSV as 'Họ Tên',b.Diem_01 as 'Điểm 0.1',b.Diem_02 as 'Điểm 0.2',b.Diem_07 as 'Điểm 0.7',round((Diem_01*0.1+Diem_02*0.2+Diem_07*0.7),1) as 'TB Hệ 10',
 (case 
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end) as 'TB Hệ 4' ,
 (case 
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 'D'
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 'D+'
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 'C'
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 'C+'
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 'B'
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 'B+'
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 'A'
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 'A+'
 else
	null
 end) as 'TB Hệ Chữ'
 from SinhVien S, BangDiem b, LopHocPhan l
 where s.MaSV = B.MaSV and l.MaLHP = b.MaLHP and l.MaLHP = @malhp
 end

GO
/****** Object:  StoredProcedure [dbo].[ThongKeDiem_MaSV]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThongKeDiem_MaSV](@maSV varchar(10))
as
begin
select BangDiem.MaLHP 'Mã Học Phần',MonHoc.SoTC as 'TC',MonHoc.TenMH as 'Môn',Diem_01 as 'Điểm 0.1',Diem_02 as 'Điểm 0.2' ,Diem_07 as 'Điểm 0.7',(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) as 'TB Hệ 10',
(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end) as 'TB Hệ 4' ,
(case 
 when Diem_07<=3.9 then 'F'
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 'F'
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 'D'
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 'D+'
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 'C'
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 'C+'
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 'B'
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 'B+'
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 'A'
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 'A+'
 else
	null
 end) as 'TB Hệ Chữ'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@maSV
end

GO
/****** Object:  StoredProcedure [dbo].[ThongKeDiem_masv_hk_namhoc]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThongKeDiem_masv_hk_namhoc](@masv varchar(10),@hocki nvarchar(10), @namhoc varchar(20))
 as
 begin
select BangDiem.MaLHP 'Mã Học Phần',MonHoc.SoTC as 'TC',MonHoc.TenMH as 'Môn',Diem_01 as 'Điểm 0.1',Diem_02 as 'Điểm 0.2' ,Diem_07 as 'Điểm 0.7',round( (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7),2) as 'TB Hệ 10',
(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end) as 'TB Hệ 4' ,
(case 
 when Diem_07<=3.9 then 'F'
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 'F'
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 'D'
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 'D+'
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 'C'
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 'C+'
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 'B'
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 'B+'
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 'A'
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 'A+'
 else
	null
 end) as 'TB Hệ Chữ'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@masv and lophocphan.namhoc = @namhoc and LopHocPhan.HocKi = @hocki
 end
GO
/****** Object:  StoredProcedure [dbo].[thongtinsv_bangdiem]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thongtinsv_bangdiem](@masv char(10))
as
begin
select SinhVien.MaSV,SinhVien.TenSV,dbo.TinhDiemTichLuy1(@masv) as'diemtichluy'
from SinhVien
where SinhVien.MaSV = @masv
end 

GO
/****** Object:  StoredProcedure [dbo].[try_in]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		create proc [dbo].[try_in]
		as
		begin
		print 'xin chào'
		end
GO
/****** Object:  StoredProcedure [dbo].[try_themsv]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[try_themsv](@ma varchar(10),@ten nvarchar(100),@ngaysinh date,@gioitinh nvarchar(5),@que nvarchar(100),@malop varchar(10))
		as
		begin
		if(@ten=null) begin print 'moi ban nhap ten' end
		else
		begin insert into SinhVien values(@ma,@ten,@ngaysinh,@gioitinh,@que,@malop) end
		end
GO
/****** Object:  StoredProcedure [dbo].[try_xoa]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[try_xoa](@ma varchar(10))
		as
		begin 
		delete SinhVien where MaSV = @ma
		end
GO
/****** Object:  StoredProcedure [dbo].[xembangdiem]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xembangdiem](@masv char(10))
as
begin
select m.MaMH,m.TenMH,l.MaLHP,b.Diem_01,b.Diem_02,b.Diem_07,(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) as 'Diem TB'
from BangDiem B, LopHocPhan L, MonHoc M,sinhvien S
where B.MaSV = s.MaSV and b.MaLHP = l.MaLHP and  m.MaMH = l.MaMH and  s.MaSV = @masv
end
GO
/****** Object:  StoredProcedure [dbo].[xemlichgiangday]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xemlichgiangday] (@magv char(10), @namhoc char(20),@hocki char(10))
 as
 begin
 select m.MaMH,m.TenMH,l.MaLHP,l.Thoigian,l.GiangDuong
 from GiangVien G, LichGiangDay Ld, LopHocPhan L, MonHoc M
 where g.MaGV = ld.MaGV and ld.MaLHP = l.MaLHP and m.MaMH = l.MaMH and g.MaGV = @magv and l.namhoc = @namhoc and l.HocKi = @hocki
 end

GO
/****** Object:  StoredProcedure [dbo].[xemthoikhoabieu]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[xemthoikhoabieu](@masv char(10))
as
begin
select m.MaMH,m.TenMH,SoTC,l.MaLHP,l.Thoigian,l.GiangDuong,HocKi,namhoc
from SinhVien S, BangDiem B, LopHocPhan L,MonHoc M
where S.MaSV = B.MaSV and B.MaLHP = L.MaLHP and l.MaMH = m.MaMH and S.MaSV = @masv
end


GO
/****** Object:  StoredProcedure [dbo].[xoagiangvien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoagiangvien](@magv char(10))
as
begin
delete GiangVien where MaGV = @magv
end
GO
/****** Object:  StoredProcedure [dbo].[xoalop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[xoalop](@malop char(10))
 as 
 begin
 delete lop where malop = @malop
 end

GO
/****** Object:  StoredProcedure [dbo].[XoaSinhVien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaSinhVien] (@masv char(10))
as
begin
delete SinhVien where @masv = MaSV
end
GO
/****** Object:  UserDefinedFunction [dbo].[TinhDiemTichLuy_MaSV_HocKi_NamHoc]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[TinhDiemTichLuy_MaSV_HocKi_NamHoc](@masv varchar(10),@hocki nvarchar(10),@namhoc varchar(20)) RETURNS float
as
begin
declare @Diemtichluy float
set @Diemtichluy = ( select ROUND(sum(di.Tong)/sum(di.SoTC),2)
from 
(select SinhVien.MaSV,BangDiem.MaLHP,MonHoc.TenMH,MonHoc.SoTC,Diem_01,Diem_02,Diem_07,(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) as 'TB Hệ 10',
(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end) as 'TB Hệ 4' ,
(case 
 when Diem_07<=3.9 then 'F'
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 'F'
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 'D'
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 'D+'
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 'C'
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 'C+'
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 'B'
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 'B+'
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 'A'
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 'A+'
 else
	null
 end) as 'TB Hệ Chữ',(SoTC*(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end)) as 'Tong'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@masv and namhoc = @namhoc and HocKi = @hocki ) as di)

return @Diemtichluy
end
GO
/****** Object:  UserDefinedFunction [dbo].[TinhDiemTichLuy1]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[TinhDiemTichLuy1](@masv varchar(10)) RETURNS float
as
begin
declare @Diemtichluy float
set @Diemtichluy = (select ROUND( sum(di.Tong)/sum(di.SoTC),2)
from 
(select SinhVien.MaSV,BangDiem.MaLHP,MonHoc.TenMH,MonHoc.SoTC,Diem_01,Diem_02,Diem_07,(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) as 'TB Hệ 10',
(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end) as 'TB Hệ 4' ,
(case 
 when Diem_07<=3.9 then 'F'
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 'F'
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 'D'
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 'D+'
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 'C'
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 'C+'
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 'B'
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 'B+'
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 'A'
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 'A+'
 else
	null
 end) as 'TB Hệ Chữ',(SoTC*(case 
 when Diem_07<=3.9 then 0.0
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then 0.0
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then 1.0
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then 1.5
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then 2.0
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then 2.5
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then 3.0
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then 3.5
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then 3.7
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then 4
 else
	null
 end)) as 'Tong'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@masv ) as di)

return @Diemtichluy
end
GO
/****** Object:  UserDefinedFunction [dbo].[TINHTONGTC_MASV]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  CREATE FUNCTION [dbo].[TINHTONGTC_MASV](@MASV VARCHAR(10)) RETURNS INT
  AS
  BEGIN
  DECLARE @TONGTC INT 
  SELECT @TONGTC =(SELECT sum(m.SoTC)
  FROM SINHVIEN S,BANGDIEM B,LOPHOCPHAN L,MONHOC M 
  WHERE S.MaSV = B.MaSV AND B.MaLHP = L.MaLHP AND L.MaMH = M.MaMH AND s.MaSV = @MASV )
  RETURN (@TONGTC)
  END 
GO
/****** Object:  UserDefinedFunction [dbo].[TONGTCNO_MASV]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
CREATE FUNCTION [dbo].[TONGTCNO_MASV](@MASV VARCHAR(10)) RETURNS INT 
	AS
	BEGIN
	DECLARE @TONGTCNO INT
	SELECT @TONGTCNO = ( select sum(di.[Số TC nợ])
	from
	(select 
(case 
 when Diem_07<=3.9 then SoTC
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then SoTC
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then null
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then null
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then null
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then null
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then null
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then null
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then null
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then null
 else
	SoTC
 end) as 'Số TC nợ'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@MASV )as di)

RETURN (@TONGTCNO)
	END
GO
/****** Object:  UserDefinedFunction [dbo].[TONGTCNO_MASV_HocKi_NamHoc]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[TONGTCNO_MASV_HocKi_NamHoc](@MASV VARCHAR(10),@hocki nvarchar(10),@namhoc varchar(20)) RETURNS INT 
	AS
	BEGIN
	DECLARE @TONGTCNO INT
	SELECT @TONGTCNO = ( select sum(di.[Số TC nợ])
	from
	(select 
(case 
 when Diem_07<=3.9 then SoTC
 when 0.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=3.9 then SoTC
 when 4.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=4.9 then null
 when 5.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=5.4 then null
 when 5.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7)  and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.4 then null
 when 6.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=6.9 then null
 when 7.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=7.9 then null
 when 8.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.4 then null
 when 8.5<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=8.9 then null
 when 9.0<=(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) and (Diem_01*0.1+Diem_02*0.2+Diem_07*0.7) <=10.0 then null
 else
	SoTC
 end) as 'Số TC nợ'
from BangDiem,SinhVien,LopHocPhan,MonHoc
where SinhVien.MaSV = BangDiem.MaSV and LopHocPhan.MaLHP = BangDiem .MaLHP and MonHoc.MaMH = LopHocPhan.MaMH and SinhVien.MaSV =@MASV and HocKi =@hocki and namhoc = @namhoc)as di)

RETURN (@TONGTCNO)
	END



GO
/****** Object:  UserDefinedFunction [dbo].[try_tinhdiemtb_mon]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[try_tinhdiemtb_mon](@ma varchar(10),@malhp varchar(10) ) returns float
		as
		begin
		declare @tb float
		select @tb = (select ROUND(Diem_01*0.1+Diem_02*0.2+Diem_07*0.7,2) from BangDiem b,SinhVien s where MaLHP = @malhp and s.MaSV = @ma and s.MaSV = b.MaSV) 
		return (@tb)
		end
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangDiem](
	[MaSV] [varchar](10) NOT NULL,
	[MaLHP] [varchar](10) NOT NULL,
	[Diem_01] [float] NULL,
	[Diem_02] [float] NULL,
	[Diem_07] [float] NULL,
 CONSTRAINT [PK__BangDiem__349CB1731B110B4E] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaLHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](100) NULL,
	[GioiTinhGV] [nvarchar](5) NULL,
	[SDT] [varchar](13) NULL,
	[MaKhoa] [varchar](10) NULL,
 CONSTRAINT [PK__GiangVie__2725AEF30214BAFD] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
	[Ma_CNKhoa] [varchar](10) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichGiangDay]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichGiangDay](
	[MaGV] [varchar](10) NOT NULL,
	[MaLHP] [varchar](10) NOT NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK__LichGian__349C179A1A7ECB47] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaLHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[SoLuongSV] [int] NULL,
	[MaKhoa] [varchar](10) NULL,
 CONSTRAINT [PK__Lop__3B98D2737DC7E07F] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[MaLHP] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NULL,
	[GiangDuong] [nvarchar](100) NULL,
	[HocKi] [nvarchar](10) NULL,
	[namhoc] [varchar](20) NULL,
	[ThoiGian] [nvarchar](100) NULL,
 CONSTRAINT [PK__LopHocPh__3B9B969077DB5D6A] PRIMARY KEY CLUSTERED 
(
	[MaLHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [varchar](10) NOT NULL,
	[TenMH] [nvarchar](100) NULL,
	[SoTC] [int] NULL,
 CONSTRAINT [PK__MonHoc__2725DFD9589157AB] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [varchar](10) NOT NULL,
	[TenSV] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinhSV] [nvarchar](5) NULL,
	[QueQuan] [nvarchar](100) NULL,
	[MaLop] [varchar](10) NULL,
 CONSTRAINT [PK__SinhVien__2725081ADD725975] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [varchar](30) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[Quyen] [varchar](20) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[try_xemsv_lop]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  function [dbo].[try_xemsv_lop](@malop varchar(10)) returns table 
		as
		return (select *from SinhVien where MaLop =@malop )
GO
/****** Object:  View [dbo].[bangao]    Script Date: 2017-06-02 3:39:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		create view [dbo].[bangao] as 
		select MaSV,TenSV from sinhvien
GO
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp001     ', 5, 7, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp002     ', 7, 7, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp003     ', 8, 9.5, 7)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp004     ', 8.5, 9, 10)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp005     ', 9, 7.5, 8)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp006     ', 7, 7, 7)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911  ', N'hp007     ', 8, 8, 7)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911', N'hp009', 6, 7, 8)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911', N'hp010', 8, 9, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150911', N'hp011', 8, 7, 8)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp001     ', 4, 4, 10)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp002     ', 7, 8.5, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp003     ', 8, 7, 6)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp004     ', 7, 9, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp005     ', 9, 7, 6)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150912  ', N'hp006     ', 6, 7, 7)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp001     ', 4, 4, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp002     ', 4, 4, 5)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp003     ', 8.5, 8, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp004     ', 9, 8, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp005     ', 9, 9, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp006     ', 6, 7, 7)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150913  ', N'hp007     ', 9, 9, 10)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp001', 7.5, 8.8, 8)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp002', 10, 10, 3.9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp003', 7, 8, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp004', 8, 6, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp005', NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150914', N'hp006', NULL, NULL, NULL)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150915', N'hp001', 9, 9, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150915', N'hp002', 7, 8, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150916', N'hp001', 9.5, 8.5, 8.5)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150918', N'hp001', 9, 9, 9)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150918', N'hp004', 7, 6, 8)
INSERT [dbo].[BangDiem] ([MaSV], [MaLHP], [Diem_01], [Diem_02], [Diem_07]) VALUES (N'14150919', N'hp001', 7, 8, 8)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv001     ', N'Đỗ Thị Mai Hường', N'Nữ', N'01669871222', N'KH001')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv002     ', N'Nguyen Viet Hung', N'Nam', N'01699123456 ', N'KH001')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv003     ', N'Nguyen Van Hong', N'Nam  ', N'01668327661  ', NULL)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv004     ', N'Đỗ Thị Mai Hường', N'Nữ', N'01688630991 ', N'KH001')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv005     ', N'Le Trong Nghia', N'Nam  ', N'0976942400   ', NULL)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv006     ', N'Vu Van Canh', N'Nữ', N'0984224423  ', N'KH001')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv007     ', N'Nguyen Thi lan Huong', N'Nu   ', N'0988432234   ', NULL)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv008     ', N'Nguyen Manh Hung', N'Nam  ', N'01668427788  ', NULL)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv009     ', N'Lưu Thị Linh', N'Nữ', N'0969696996  ', N'KH002')
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv010', N'Đỗ THị Thu Quảng', N'Nữ', NULL, NULL)
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [GioiTinhGV], [SDT], [MaKhoa]) VALUES (N'gv011', N'Nguy?n Hà Linh', N'N?', N'01668327661', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH001', N'Công Nghệ Thông Tin', N'gv001')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH002', N'Cơ Khí', N'gv009')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH003', N'Ngoại Ngữ', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH004', N'Vũ Khí', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH005', N'Động Lực', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH006', N'Hóa Lý Kỹ Thuật', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH007', N'Hàng Không Vũ Trụ', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH008', N'Vô Tuyến Điện Tử', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [Ma_CNKhoa]) VALUES (N'KH009', N'KT Điều Khiển', NULL)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv001     ', N'hp001     ', 60)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv001     ', N'hp004     ', 45)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv002     ', N'hp002     ', 30)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv003     ', N'hp005     ', 45)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv004     ', N'hp006     ', 45)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv005     ', N'hp003     ', 30)
INSERT [dbo].[LichGiangDay] ([MaGV], [MaLHP], [SoTiet]) VALUES (N'gv006     ', N'hp007     ', 45)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV], [MaKhoa]) VALUES (N'l001      ', N'TH13A', 8, N'KH001')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV], [MaKhoa]) VALUES (N'l002      ', N'TH13B', 7, N'KH001')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV], [MaKhoa]) VALUES (N'l003      ', N'TH13C', 7, N'KH001')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV], [MaKhoa]) VALUES (N'l004      ', N'TH14B', 7, N'KH001')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp001     ', N'mh001     ', N'H9303', N'HK 1', N'2016 - 2017', N'Thứ 2(4 - 6), Thứ 3(4 -5)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp002     ', N'mh003     ', N'H9303', N'HK 1', N'2016 - 2017', N'Thứ 3(1 - 3)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp003     ', N'mh004     ', N'H5505', N'HK 1', N'2016 - 2017', N'Thứ 5(7 -9)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp004     ', N'mh002     ', N'Phong May', N'HK 1', N'2016 - 2017', N'Thứ 4( full )')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp005     ', N'mh005     ', N'H9603', N'HK 1', N'2016 - 2017', N'Thứ 5(1 -3)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp006     ', N'mh006     ', N'H9303', N'HK 1', N'2016 - 2017', N'Thứ 5(4 - 6)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp007     ', N'mh007     ', N'H9303', N'HK 1', N'2016 - 2017', N'Thứ 6(1 - 3)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp009', N'mh008', N'S303', N'HK 1', N'2014 - 2015', N'Thứ 2(1 - 3)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp010', N'mh009', N'S502', N'HK 1', N'2014 - 2015', N'Thứ 2(4 - 6)')
INSERT [dbo].[LopHocPhan] ([MaLHP], [MaMH], [GiangDuong], [HocKi], [namhoc], [ThoiGian]) VALUES (N'hp011', N'mh010', N'S402', N'HK 2', N'2014 - 2015', N'Thứ 5(10 - 12)')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh001     ', N'Cơ Sở Dữ Liệu', 4)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh002     ', N'Thuc Tap CSDL', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh003     ', N'Ngon Ngu Lap Trinh 2', 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh004     ', N'Cau Truc May Tinh', 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh005     ', N'Toan Chuyen De', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh006     ', N'Ly Thuyet He Dieu Hanh', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh007     ', N'Dam Bao An Toan Thong Tin', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh008', N'Những Nguyên lý Cơ Bản CN MAC - LENNIN', 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh009', N'Vật Lý Đại Cương', 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC]) VALUES (N'mh010', N'Giải Tích 1', 4)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150911  ', N'Tạ Văn Nam', CAST(0xAC1F0B00 AS Date), N'Nam', N'Lien Mac - Me Linh - Ha Noi', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150912  ', N'Jason Staham', CAST(0xAC1F0B00 AS Date), N'Nam', N'Yen Nhan - Y Yen - Nam Dinh ', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150913  ', N'Tạ Việt Nam', CAST(0x5D1F0B00 AS Date), N'Nam', N'Mê Linh - Hà Nội', N'l002      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150914  ', N'huy ha phan', CAST(0xAC1F0B00 AS Date), N'Nữ', N'Lien Mac - Me Linh - Ha Noi', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150915  ', N'Nguyen Thi Linh', CAST(0x9F1B0B00 AS Date), N'Nam', N'Thai Binh', N'l003      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150916  ', N'Do Quảng', CAST(0x213C0B00 AS Date), N'Nam', N'', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150918  ', N'Ta Hai Nam', CAST(0x1F3C0B00 AS Date), N'Nam', N'ha noi', N'l003      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150919  ', N'Nguyen Thi Ha', CAST(0x213C0B00 AS Date), N'Nam', N'', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150920  ', N'Nguyen Duc Canh', CAST(0x851F0B00 AS Date), N'Nam', N'Y Yen - Nam Dinh', N'l002      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150921  ', N'Pham Van Hung', CAST(0xA01F0B00 AS Date), N'Nam', N'Nghe An', N'l004      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150922', N'Nguyễn Chiến', CAST(0x273C0B00 AS Date), N'Nữ', N'Ha Noi', N'l001      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'14150923', N'Lê Đức Thọ', CAST(0x273C0B00 AS Date), N'Nam', N'Thạch Đà', N'l002      ')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinhSV], [QueQuan], [MaLop]) VALUES (N'17', N'nam', NULL, NULL, NULL, NULL)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [Quyen]) VALUES (N'ad', N'ad', N'3')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [Quyen]) VALUES (N'gv', N'gv', N'2')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [Quyen]) VALUES (N'sv', N'sv', N'1')
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__MaLHP__239E4DCF] FOREIGN KEY([MaLHP])
REFERENCES [dbo].[LopHocPhan] ([MaLHP])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__MaLHP__239E4DCF]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK__BangDiem__MaSV__22AA2996] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK__BangDiem__MaSV__22AA2996]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_khoa]
GO
ALTER TABLE [dbo].[LichGiangDay]  WITH CHECK ADD  CONSTRAINT [FK_LichGiangDay_GiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[LichGiangDay] CHECK CONSTRAINT [FK_LichGiangDay_GiangVien]
GO
ALTER TABLE [dbo].[LichGiangDay]  WITH CHECK ADD  CONSTRAINT [FK_LichGiangDay_LopHocPhan] FOREIGN KEY([MaLHP])
REFERENCES [dbo].[LopHocPhan] ([MaLHP])
GO
ALTER TABLE [dbo].[LichGiangDay] CHECK CONSTRAINT [FK_LichGiangDay_LopHocPhan]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [FK__LopHocPhan__MaMH__1273C1CD] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [FK__LopHocPhan__MaMH__1273C1CD]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK__SinhVien__MaLop__1BFD2C07] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK__SinhVien__MaLop__1BFD2C07]
GO
USE [master]
GO
ALTER DATABASE [QUANLYDIEM] SET  READ_WRITE 
GO
