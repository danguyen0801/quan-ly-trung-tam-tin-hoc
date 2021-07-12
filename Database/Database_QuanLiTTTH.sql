/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2019                    */
/* Created on:     5/26/2021 11:36:16 PM                        */
/*==============================================================*/

create database QUANLITRUNGTAMTINHOC
go

use QUANLITRUNGTAMTINHOC
go


/*==============================================================*/
/* Table: CHUONGTRINHDAOTAO                                     */
/*==============================================================*/
create table CHUONGTRINHDAOTAO 
(
   MACT                 nvarchar(20)                   not null,
   MOTA                 nvarchar(100)                  null,
   constraint PK_CHUONGTRINHDAOTAO primary key (MACT)
);

/*==============================================================*/
/* Table: HOCVIEN                                               */
/*==============================================================*/
create table HOCVIEN 
(
   MAHV                 nvarchar(20)                     not null,
   HOTENHV              nvarchar(50)                     null,
   GIOITINH             nvarchar(10)                     null,
   SDT					nvarchar(10)					 null,
   EMAIL				nvarchar(50)					 null,
   NGAYSINH				date							 null,
   DIEMTHITOTNGHIEP		int								 null,
   constraint PK_HOCVIEN primary key (MAHV)
);
/*==============================================================*/
/* Table: GIANGVIEN                                             */
/*==============================================================*/
create table GIANGVIEN 
(
   MAGV						nvarchar(20)                    not null,
   TENGV					nvarchar(50)					null,
   GIOITINH					nvarchar(10)					null,
   TRINHDO					nvarchar(50)					null,
   NGAYSINH					date							null,
   SODIENTHOAI				nvarchar(10)					null,
   constraint PK_GIANGVIEN primary key clustered (MAGV)
);

/*==============================================================*/
/* Table: NVGIAOVU                                              */
/*==============================================================*/
create table NVGIAOVU 
(
   MANV                 nvarchar(20)                       not null,
   TENNV				nvarchar(50)					   null,
   SDT					nvarchar(10)					   null,
   EMAIL				nvarchar(50)					   null,
   constraint PK_NVGIAOVU primary key (MANV)
);

/*==============================================================*/
/* Table: LOPCHUYENDE										    */
/*==============================================================*/
create table LOPCHUYENDE
(
   MALOPCD					nvarchar(20)                    not null,
   MACD						nvarchar(20)					not null,
   TENLOPCD					nvarchar(100)					null,
   MAGV						nvarchar(20)					null,
   SISO						int								null,
   THOIGIANHOC				date							null,
   constraint PK_LOPCHUYENDE primary key clustered (MALOPCD)
);

/*==============================================================*/
/* Table: DKCHUYENDE                                            */
/*==============================================================*/
create table DKCHUYENDE
(
   MAHV						nvarchar(20)					not null,
   MALOPCD					nvarchar(20)                    not null,
   THOIGIANDK				date							null,
   constraint PK_DKCHUYENDE primary key clustered (MAHV, MALOPCD)
);

/*==============================================================*/
/* Table: NHOMCHUYENDE                                          */
/*==============================================================*/
create table NHOMCHUYENDE
(
   MANHOMCD					nvarchar(20)				not null,
   TENNHOMCD				nvarchar(20)                null,
   MACT						nvarchar(20)				null,
   constraint PK_NHOMCHUYENDE primary key clustered (MANHOMCD)
);

/*==============================================================*/
/* Table: CHUYENDE                                              */
/*==============================================================*/
create table CHUYENDE
(
   MACD						nvarchar(20)				not null,
   TENCD					nvarchar(100)                not null,
   MANHOMCD					nvarchar(20)				null,
   GIATIEN					int							null,
   constraint PK_CHUYENDE primary key clustered (MACD)
);

/*==============================================================*/
/* Table: LOPHOCPHAN									        */
/*==============================================================*/
create table LOPHOCPHAN
(
   MALOPHP					nvarchar(20)                not null,
   MAMONHOC					nvarchar(20)				not null,
   TENLOPHP					nvarchar(100)				null,
   MAGV						nvarchar(20)				null,
   SISO						int							null,
   THOIGIANHOC				date						null,
   constraint PK_LOPHOCPHAN primary key clustered (MALOPHP)
);

/*==============================================================*/
/* Table: DKHP												    */
/*==============================================================*/
create table DKHP
(
   MAHV						nvarchar(20)				not null,
   MALOPHP		            nvarchar(20)                not null,
   THOIGIANDK				date						null,
   constraint PK_DKHP primary key clustered (MAHV, MALOPHP)
);

/*==============================================================*/
/* Table: NHOMHP	                                            */
/*==============================================================*/
create table NHOMHP
(
   MANHOMHP             nvarchar(20)                       not null,
   TENNHOMHP            nvarchar(20)                       null,
   MACT					nvarchar(20)					   null,
   constraint PK_NHOMHP primary key (MANHOMHP)
);

/*==============================================================*/
/* Table: MONHOC                                                */
/*==============================================================*/
create table MONHOC 
(
   MAMONHOC             nvarchar(20)                       not null,
   MANHOMHP             nvarchar(20)                       not null,
   TENMONHOC            nvarchar(100)                       null,
   HINHTHUCDAOTAO		nvarchar(50)					   null,
   GIATIEN              int								   null,
   constraint PK_MONHOC primary key (MAMONHOC)
);

/*==============================================================*/
/* Table: PHIEUHOCPHI										    */
/*==============================================================*/
create table PHIEUHOCPHI
(
   MAPHIEU					nvarchar(20)				not null,
   MAHV						nvarchar(20)				not null,
   MANV						nvarchar(20)                null,
   TONGTIEN					int							null,
   constraint PK_PHIEUHOCPHI primary key clustered (MAPHIEU)
);

/*==============================================================*/
/* Table: LICHTHI                                              */
/*==============================================================*/
create table LICHTHI 
(
   MALICHTHI           nvarchar(20)                     not null,
   MALOPHP			   nvarchar(20)						null,
   PHONGTHI            nvarchar(20)                     null,
   THOIGIANTHI         date								null,
   MANV		           nvarchar(20)                     not null,
   constraint PK_BANGDIEM primary key (MALICHTHI)
);
/*==============================================================*/
/* Table: BANGDIEM                                              */
/*==============================================================*/
create table BANGDIEM 
(
   MAHV					nvarchar(20)                    not null,
   MAMONHOC             nvarchar(20)                    not null,
   DIEM					int								null,
   ISPASS				bit			                    null,
   SOLANTHI				int								null,
   constraint PK_BANGDIEM1 primary key (MAHV, MAMONHOC)
);

/*==============================================================*/
/* Table: CHUNGCHITINHOC                                        */
/*==============================================================*/
create table CHUNGCHITINHOC 
(
   MACHUNGCHI            nvarchar(20)                     not null,
   TENCHUNGCHI           nvarchar(20)                     null,
   MAHV					 nvarchar(20)                     null,
   NGAYCAP               date                             null,
   XEPLOAI               nvarchar(50)                     null,
   MANHOMHP				 nvarchar(20)                     null,
   constraint PK_CHUNGCHITINHOC primary key (MACHUNGCHI)
);

/*==============================================================*/
/* Table: CHUNGCHICTDAOTAO                                      */
/*==============================================================*/
create table CHUNGCHICTDAOTAO 
(
   MACHUNGCHI            nvarchar(20)                     not null,
   MAHV					 nvarchar(20)                     null,
   NGAYCAP               date                             null,
   XEPLOAI               nvarchar(50)                     null,
   MACT					 nvarchar(20)					  null,
   constraint PK_CHUNGCHICTDAOTAO primary key (MACHUNGCHI)
);

alter table LOPCHUYENDE
   add constraint FK_LOPCD_GV foreign key (MAGV)
      references GIANGVIEN (MAGV)

alter table LOPHOCPHAN
   add constraint FK_LOPHP_GV foreign key (MAGV)
      references GIANGVIEN (MAGV)      
  
alter table DKCHUYENDE
   add constraint FK_DKCD_HV foreign key (MAHV)
      references HOCVIEN (MAHV)

alter table DKCHUYENDE
   add constraint FK_DKCD_LOPCD foreign key (MALOPCD)
      references LOPCHUYENDE (MALOPCD)

alter table DKHP
   add constraint FK_DKHP_HV foreign key (MAHV)
      references HOCVIEN (MAHV)

alter table DKHP
   add constraint FK_DKHP_LOPHP foreign key (MALOPHP)
      references LOPHOCPHAN (MALOPHP)

alter table LOPCHUYENDE
   add constraint FK_LOPCD_CD foreign key (MACD)
      references CHUYENDE (MACD)

alter table CHUYENDE
   add constraint FK_CD_NHOMCD foreign key (MANHOMCD)
      references NHOMCHUYENDE (MANHOMCD)

alter table NHOMCHUYENDE
   add constraint FK_NHOMCD_CTDT foreign key (MACT)
      references CHUONGTRINHDAOTAO (MACT)

alter table LOPHOCPHAN
   add constraint FK_LOPHP_MH foreign key (MAMONHOC)
      references MONHOC (MAMONHOC)

alter table LICHTHI
   add constraint FK_LT_LOPHP foreign key (MALOPHP)
      references LOPHOCPHAN (MALOPHP)

alter table MONHOC
   add constraint FK_MH_NHOMHP foreign key (MANHOMHP)
      references NHOMHP (MANHOMHP)

alter table NHOMHP
   add constraint FK_NHOMHP_CTDT foreign key (MACT)
      references CHUONGTRINHDAOTAO (MACT)

alter table CHUNGCHITINHOC
   add constraint FK_CCTH_HV foreign key (MAHV)
      references HOCVIEN (MAHV)

alter table CHUNGCHITINHOC
   add constraint FK_CCTH_NHOMHP foreign key (MANHOMHP)
      references NHOMHP (MANHOMHP)

alter table CHUNGCHICTDAOTAO
   add constraint FK_CTDT_HV foreign key (MAHV)
      references HOCVIEN (MAHV)


alter table CHUNGCHITINHOC
   add constraint FK_CCTH_HV foreign key (MAHV)
      references HOCVIEN (MAHV)


alter table CHUNGCHICTDAOTAO
   add constraint FK_CCCT_CTDT foreign key (MACT)
      references CHUONGTRINHDAOTAO (MACT)

alter table BANGDIEM
   add constraint FK_BANGDIEM_HV foreign key (MAHV)
      references HOCVIEN (MAHV)

alter table BANGDIEM
   add constraint FK_BANGDIEM_MH foreign key (MAMONHOC)
      references MONHOC (MAMONHOC)

alter table PHIEUHOCPHI
   add constraint FK_PHIEUHP_HV foreign key (MAHV)
      references HOCVIEN (MAHV)


alter table PHIEUHOCPHI
   add constraint FK_PHIEUHP_NV foreign key (MANV)
      references NVGIAOVU (MANV)

alter table LICHTHI
   add constraint FK_LT_NV foreign key (MANV)
      references NVGIAOVU (MANV)


create proc sp_ThoiKhoaBieu(@MaHV nvarchar(20))
as
begin
	select N'Mã HV' = hv.MAHV, N'Mã Môn Học' = mh.MAMONHOC, N'Tên Môn Học'=mh.TENMONHOC,N'Mã Lớp' = lhp.MALOPHP,N'Sĩ Số' = lhp.SISO, N'TG Bắt Đầu' = lhp.THOIGIANHOC
	from HOCVIEN hv, DKHP dkhp, LOPHOCPHAN lhp, MONHOC mh
	where hv.MAHV = dkhp.MAHV and dkhp.MALOPHP = lhp.MALOPHP and lhp.MAMONHOC= mh.MAMONHOC and @MaHV = hv.MAHV 
	union
	select hv.MAHV, cd.MACD, cd.TENCD, lcd.MALOPCD, lcd.SISO, lcd.THOIGIANHOC
	from HOCVIEN hv
	join DKCHUYENDE dkcd on hv.MAHV=dkcd.MAHV
	join LOPCHUYENDE lcd on dkcd.MALOPCD=lcd.MALOPCD
	join CHUYENDE cd on lcd.MACD = cd.MACD
	where hv.MAHV = @MaHV;
end

create proc sp_ThongTinCaNhan(@MaHV nvarchar(20))
as
	select * from HOCVIEN where @MaHV = MAHV


create proc sp_XemLichThi (@MaHV nvarchar(20))
as
begin
	select N'Mã HV' = hv.MAHV, N'Mã Lịch Thi' = lt.MALICHTHI, N'Mã Lớp' = dkhp.MALOPHP, N'Tên Môn Học' = mh.TENMONHOC, N'Phòng Thi' = lt.PHONGTHI,N'Thời Gian Thi' =  lt.THOIGIANTHI
	from HOCVIEN hv, LICHTHI lt, DKHP dkhp, LOPHOCPHAN lhp, MONHOC mh
	where hv.MAHV=dkhp.MAHV and dkhp.MALOPHP= lhp.MALOPHP and lhp.MALOPHP = lt.MALOPHP and lhp.MAMONHOC = mh.MAMONHOC and @MaHV = hv.MAHV 
end

create proc sp_XemDiemThi(@MaHV nvarchar(20))
as
begin
	select N'Mã HV' = hv.MAHV, N'Tên Môn Học' = mh.TENMONHOC, N'Điểm' =bd.DIEM, N'IsPass' = bd.ISPASS, N'Số lần thi' =bd.SOLANTHI 
	from HOCVIEN hv, BANGDIEM bd, MONHOC mh
	where hv.MAHV = bd.MAHV and bd.MAMONHOC = mh.MAMONHOC and @MaHV = hv.MAHV 
end

create proc sp_TinhHocPhi(@MaHV nvarchar(20))
as
begin
	declare @price1 int, @price2 int, @price int 
	select @price1= sum(cd.GIATIEN)
	from PHIEUHOCPHI php 
	join HOCVIEN hv on hv.MAHV=php.MAHV
	join DKCHUYENDE dk on dk.MAHV=hv.MAHV
	join LOPCHUYENDE lcd on lcd.MALOPCD = dk.MALOPCD
	join CHUYENDE cd on cd.MACD=lcd.MACD
	where  hv.MAHV = @MaHV;
	select @price2= sum(mh.GIATIEN )
	from PHIEUHOCPHI php 
	join HOCVIEN hv on hv.MAHV=php.MAHV
	join DKHP dk on dk.MAHV=hv.MAHV
	join LOPHOCPHAN lhp on lhp.MALOPHP = dk.MALOPHP
	join MONHOC mh on mh.MAMONHOC=lhp.MAMONHOC
	where hv.MAHV = @MaHV;
	set @price = @price1 +@price2;
	Update PHIEUHOCPHI set TONGTIEN = @price where  MAHV = @MaHV;
end
create proc sp_XemHocPhi(@MaHV nvarchar(20))
as
begin
	exec sp_TinhHocPhi @MaHV;
	select N'Mã HV' = hv.MAHV,N'Tên HV' =hv.HoTenHV,N'Tên Môn Học' = cd.TENCD, N'Gía Tiền'=cd.GIATIEN, N'Tổng Học Phí' = php.TongTien
	from PHIEUHOCPHI php 
	join HOCVIEN hv on hv.MAHV=php.MAHV
	join DKCHUYENDE dk on dk.MAHV=hv.MAHV
	join LOPCHUYENDE lcd on lcd.MALOPCD = dk.MALOPCD
	join CHUYENDE cd on cd.MACD=lcd.MACD
	where  hv.MAHV = @MaHV
	union
	select hv.MAHV, hv.HOTENHV, mh.TENMONHOC, mh.GIATIEN, php.TongTien
	from PHIEUHOCPHI php 
	join HOCVIEN hv on hv.MAHV=php.MAHV
	join DKHP dk on dk.MAHV=hv.MAHV
	join LOPHOCPHAN lhp on lhp.MALOPHP = dk.MALOPHP
	join MONHOC mh on mh.MAMONHOC=lhp.MAMONHOC
	where hv.MAHV = @MaHV;
end

create proc sp_SuaThongTinCaNhan
	@MaHV nvarchar(20),
	@TenHV nvarchar(50),
	@GioiTinh nvarchar(10),                     
	@SDT nvarchar(10),	
	@Email nvarchar(50),	
	@NgaySinh date,
	@DiemThiTN	int	
as
begin
update HOCVIEN
set HOTENHV= @TenHV,
GIOITINH = @GioiTinh,
SDT = @SDT,
EMAIL = @Email,
NGAYSINH = @NgaySinh,
DIEMTHITOTNGHIEP = @DiemThiTN
where MAHV = @MaHV
end


