create trigger dklhp on DKHP for insert as
begin
declare @n int,@m int
set @n=(select mh.Giatien from MONHOC mh join LOPHOCPHAN lhp on mh.Mamonhoc=lhp.mamonhoc where lhp.Malophp=(select malophp from inserted))
set @m=(select php.tongtien from phieuhocphi php where php.MaHV=(select maHV from inserted))
set @m=@m+@n
update PHIEUHOCPHI set Tongtien=@m where mahv=(select mahv from inserted)
end

create trigger dklcd on DKCHUYENDE for insert as
begin
declare @n int,@m int
set @n=(select cd.Giatien from CHUYENDE cd join LOPCHUYENDE lcd on cd.Macd=cd.macd where lcd.Malopcd=(select malopcd from inserted))
set @m=(select php.tongtien from phieuhocphi php where php.MaHV=(select maHV from inserted))
set @m=@m+@n
update PHIEUHOCPHI set Tongtien=@m where mahv=(select mahv from inserted)
end