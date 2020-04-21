use QuanLyThuVien
go
-- Thêm, sửa, xóa thông tin tác giả, tìm kiếm tác giả
-- Thêm thông tin tác giả
   insert into dbo.TACGIA(MaTacGia,TenTacGia)  values ( '18587',N'Thanh Hải')
   create proc ThemTacGia(@matg int, @tentg nvarchar(100))
   as 
   begin 
       if not exists (select *from TACGIA where MaTacGia=@matg)
	   begin 
	    insert into TACGIA(MaTacGia,TenTacGia) values(@matg,@tentg)
		end
   end
   execute dbo.ThemTacGia '18587' , N'Thanh Hải'

-- Sửa thông tin tác giả
update TACGIA set TenTacGia =N'Thanh Hải' where MaTacGia='18586'
create proc updateTG
(@maTg int,
@tentg nvarchar(100))
as 
begin 
 if exists (select *from TACGIA where MaTacGia=@maTg)
 begin
    update TACGIA set @tentg ='Thanh Hải'
	where MaTacGia = '11856'
 end
end

-- Xóa thông tin tác giả
-- Tìm kiếm thông tin tác giả
-- Thêm sửa xóa thông tin nxb, tìm kiếm nxb.
-- Thêm thông tin NXB
INSERT INTO NXB (MaNXB,TenNXB,DiaChiNXB,SDT_NXB) VALUES ('572',N'NXB ABC','39 Hàng Muối, Q. Hoàn Kiếm, Hà Nội','39710715');
create proc ThemNXB
(@maNXB int ,
@TenNXB nvarchar(100),
@addNXB nvarchar(200),
@sdtNXB int)
as
begin 
  if not exists (select *from NXB where MaNXB=@maNXB)
    begin
	 insert into NXB(MaNXB,TenNXB,DiaChiNXB,SDT_NXB) values (@maNXB,@TenNXB,@addNXB,@sdtNXB)
	end 
end
execute ThemNXB '572',N'NXB ABC','39 Hàng Muối, Q. Hoàn Kiếm, Hà Nội','39710715'

-- Sửa thông tin NXB
update NXB set TenNXB = 'NXB ABC' , SDT_NXB='92478657' where MaNXB='571'
create proc updateNXB
(@maNXB int,
@tenNXB nvarchar(100),
@addNXB nvarchar (200),
@sdtNXB int)
as
begin 
  if exists (select *from NXB where MaNXB=@maNXB)
  begin
     update NXB set TenNXB = @tenNXB , SDT_NXB=@sdtNXB
	  where MaNXB='571'
  end
 end
-- Xóa thông tin NXB
 DELETE FROM NXB
WHERE TenNXB = 'NXB Phụ Nữ' 
create proc deleteNXB
(@maNXB int,
@tenNXB nvarchar(100),
@addNXB nvarchar (200),
@sdtNXB int)
as
begin
 if exists (select *from NXB where MaNXB=@maNXB)
 begin
    delete NXB where TenNXB='NXB Phụ Nữ'
 end
end


-- Tìm kiếm NXB mà có địa chỉ ở Hà Nội
select *from NXB where DiaChiNXB like '%Hà Nội%'

-- Thêm sửa xóa thông tin thể loại, tìm kiếm thể loại.
-- Thêm thể loại 
INSERT INTO THELOAI (MaKeSach,TenTheLoai) VALUES ('1114',N'Truyện Ngắn');
create proc themTheLoai
(@makesach int, @Tentheloai nvarchar(100))
as
begin
   if exists (select *from KESACH,THELOAI where KESACH.MaKeSach = @makesach and THELOAI.MaKeSach=@makesach)
   begin
     INSERT INTO THELOAI (MaKeSach,TenTheLoai) VALUES (@makesach,@Tentheloai)
   end
end
exec themTheLoai '1114',N'Truyện Ngắn'
-- Sửa thể loại
update THELOAI set TenTheLoai=N'Truyện ngắn' where MaKeSach='1114'
create proc updateTHELOAI
(@makesach int,
@tentheloai nvarchar(100))
as
begin 
    if exists (select *from KESACH,THELOAI where KESACH.MaKeSach = @makesach and THELOAI.MaKeSach=@makesach)
	begin
	  update THELOAI set TenTheLoai=@tentheloai where MaKeSach='1114'
	end
end
-- Xóa thể loại
-- Tìm kiếm thể loại
-- Thêm sửa xóa thông tin đầu sách, tìm kiếm đầu sách.
-- Thêm thông tin đầu sách
INSERT INTO DAUSACH (MaDauSach,TenDauSach,MaNXB) VALUES ('114',N'Có Một Cô Gái Thầm Yêu Anh ','552');
create proc themDauSach
(@maDausach int,
@Tendausach nvarchar(100),
@maNXB int)
as
begin 
   if not exists (select *from DAUSACH where MaDauSach=@maDausach)
   begin
    if  exists (select *from NXB where MaNXB=@maNXB)
	begin
	  INSERT INTO DAUSACH (MaDauSach,TenDauSach,MaNXB) VALUES (@maDausach,@Tendausach,@maNXB)
	end
   end
 end

-- Sửa thông tin đầu sách
update DAUSACH set TenDauSach=N'Có Một Cô Gái Thầm Yêu Anh' where MaDauSach ='114'
create proc updateDausach 
(@maDausach int,
@Tendausach nvarchar(100),
@maNXB int)
as
begin
   
end
-- Xóa thông tin đầu sách
-- Tìm kiếm đầu sách
-- Thêm sửa xóa thông tin cuốn sách, tìm kiếm cuốn sách
-- Thêm thông tin cuốn sách
INSERT INTO CUONSACH (MaCuonSach,TenSach,SoTrang,TinhTrangCuonSach,MaDauSach,MaKeSach)
 VALUES ('10001151',N'Lập trình hướng đối tượng','324',N'Chưa mượn','109','1115');
 create proc themCuonSach
 (@macuonsach int ,
 @Tensach nvarchar(100),
 @page int,
 @tinhtrang nvarchar(50),
 @madausach int,
 @makesach int)
 as
 begin 
  if not exists (select *from CUONSACH where MaCuonSach=@macuonsach)
  begin
     if exists (select *from DAUSACH where MaDauSach=@madausach)
	 begin 
	    if exists (select *from KESACH where MaKeSach=@makesach)
		  begin 
INSERT INTO CUONSACH (MaCuonSach,TenSach,SoTrang,TinhTrangCuonSach,MaDauSach,MaKeSach)
 VALUES (@macuonsach,@Tensach.@page,@tinhtrang,@madausach,@makesach)
 		  end
	 end
  end
 end
-- Sửa thông tin cuốn sách
-- Xóa thông tin cuốn sách
-- Tìm kiếm cuốn sách 
-- Xuất ra tên tác giả và tên cuốn sách có số trang >=200

select tg.TenTacGia,cs.TenSach from TACGIA as tg, CUONSACH as cs ,DAUSACH as ds, SACH_TACGIA as s_tg
where cs.MaDauSach=ds.MaDauSach 
and ds.MaDauSach=s_tg.MaDauSach
and s_tg.MaTacGia=tg.MaTacGia
group by TenTacGia,TenSach 
having MIN(cs.SoTrang)>=200
-- thống kê tên tác giả có nhiều hơn 1 cuốn sách 

-- thống kê số lượng sách của mỗi NXB 
select nxb.TenNXB ,count(*) as soluong from NXB as nxb, DAUSACH as ds, CUONSACH as cs
where cs.MaDauSach=ds.MaDauSach
and ds.MaNXB=nxb.MaNXB
group by TenNXB
-- thống kê số lượng sách của mỗi đầu sách
SELECT TenDauSach, COUNT(*) AS Soluong FROM DAUSACH, CUONSACH 
where CUONSACH.MaDauSach = DAUSACH.MaDauSach
GROUP BY DAUSACH.TenDauSach
