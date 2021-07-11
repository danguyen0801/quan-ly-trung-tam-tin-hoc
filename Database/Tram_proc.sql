create procedure GetAllBangTotNghiep
as
select* from CHUNGCHICTDAOTAO

create procedure InsertBangTotNghiep
@MACHUNGCHI nvarchar(20),
@MAHV nvarchar(20),
@NGAYCAP date,
@XEPLOAI nvarchar(50),
@MaCT nvarchar(20)
as 
insert into CHUNGCHICTDAOTAO(MACHUNGCHI, MAHV, NGAYCAP, XEPLOAI, MACT)
values (@MACHUNGCHI, @MAHV, @NGAYCAP, @XEPLOAI, @MaCT)

create procedure GetAllChungChiTinHoc
as
select* from CHUNGCHITINHOC

create procedure InsertChungChiTinHoc
@MACHUNGCHI nvarchar(20),
@TENCHUNGCHI nvarchar(20),
@MAHV nvarchar(20),
@NGAYCAP date,
@XEPLOAI nvarchar(50),
@MANHOMHP nvarchar(20)
as 
insert into CHUNGCHITINHOC(MACHUNGCHI, TENCHUNGCHI, MAHV, NGAYCAP, XEPLOAI, MANHOMHP)
values (@MACHUNGCHI, @TENCHUNGCHI, @MAHV, @NGAYCAP, @XEPLOAI, @MANHOMHP)

create procedure GetAllLopHocPhan
as
select* from LOPHOCPHAN

create procedure InsertLichThi
@MALICHTHI nvarchar(20),
@MALOPHP nvarchar(20),
@PHONGTHI nvarchar(20),
@THOIGIANTHI date,
@MaNV nvarchar(20)
as 
insert into LICHTHI(MALICHTHI, MALOPHP, PHONGTHI, THOIGIANTHI, MANV)
values (@MALICHTHI, @MALOPHP, @PHONGTHI, @THOIGIANTHI, @MaNV)