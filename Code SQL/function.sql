use BOOKSTOREMANAGE
go

-----------------------------------------Function phụ trợ--------------------------------------------------
--Hàm tính tổng tiền hóa đơn khi chưa áp dụng bất cứ voucher nào
create or alter function func_totalPayBeforeDiscount(@idBill varchar(8))
returns int
as
begin
	declare @totalBill int
	set @totalBill= (
	select sum(priceExport*amountOutput)
	from dbo.BOOK,dbo.BOOK_BILLOUTPUT
	where BOOK.idBook=BOOK_BILLOUTPUT.idBook and @idBill=BOOK_BILLOUTPUT.idBillOutput)
	return @totalBill
end
go
--Hàm kiểm tra voucher còn trong thời gian sử dụng hay không
create or alter function func_checkVoucherValidOrNot(@dateStart date,@dateEnd date,@dateCurrent date)
returns bit
as
begin
	declare @dayOfVoucher int, @dayCurrentSinceVoucher int
	set @dayOfVoucher=DATEDIFF(day,@dateEnd,@dateStart)
	set @dayCurrentSinceVoucher=DATEDIFF(day,@dateCurrent,@dateStart)
	if (@dayCurrentSinceVoucher < @dayOfVoucher)
		return 0
	return 1
end
go
go
--Hàm kiểm tra số điện thoại đúng định dạng
create or alter function func_checkPhone(@phoneNumber varchar(20))
returns bit
as
begin
	declare @firstChar varchar(2)
	set @firstChar=LEFT(@phoneNumber,1)
	if (ISNUMERIC(@phoneNumber)=0 or len(@phoneNumber)!=10 or @firstChar not like '0')
		return 0
	return 1
end
go
--create or alter function func_returnIDValue(@
--Tìm kiếm một Account
create or alter function func_searchAccount(@idAcc varchar(8), @userName varchar(20), @password varchar(30), @typeAcc bit, @idEmp varchar(8))
returns table
as
	return ( select *
	from dbo.ACCOUNT
	where ACCOUNT.idAccount=@idAcc and ACCOUNT.nameAccount like @userName+'%' and ACCOUNT.password like @password+'%' and ACCOUNT.typeOfAcc = typeOfAcc and ACCOUNT.idEmployee=@idEmp )
go
use BOOKSTOREMANAGE
go
create or alter proc GetBook
as
begin
	
	select A.idBook, nameBook, nameAuthor, nameCategory, namePublisher, priceExport, amount from 
	(select BOOK.idBook, BOOK.nameBook, STRING_AGG(nameCategory, ' - ') as nameCategory, namePublisher, BOOK.priceExport, BOOK.amount from BOOK, BOOK_CATEGORY, CATEGORY, PUBLISHER
	where	BOOK.idPublisher = PUBLISHER.idPublisher and
			Book.idBook = BOOK_CATEGORY.idBook and 
			BOOK_CATEGORY.idCategory = CATEGORY.idCategory
	group by BOOK.idBook, BOOK.nameBook, namePublisher, BOOK.priceExport, BOOK.amount)A join

	(select BOOK.idBook, STRING_AGG(nameAuthor, ' - ') as nameAuthor from BOOK, BOOK_AUTHOR, AUTHOR
	where	Book.idBook = BOOK_AUTHOR.idBook and 
			BOOK_AUTHOR.idAuthor = AUTHOR.idAuthor
	group by BOOK.idBook) B on A.idBook = B.idBook
	
end
go
--Trả về danh sách các thể loại của sách
create or alter function func_getAllCategoryOfBook(@idBook varchar(8))
returns table
as 
return (select distinct dbo.CATEGORY.nameCategory as TheLoai
from dbo.CATEGORY, dbo.BOOK_CATEGORY
where dbo.BOOK_CATEGORY.idBook=@idBook and dbo.CATEGORY.idCategory=dbo.BOOK_CATEGORY.idCategory)
go
--Trả về danh sách các tác giả của sách
create or alter function func_getAllAuthorOfBook(@idBook varchar(8))
returns table
as 
return (select distinct dbo.AUTHOR.nameAuthor as TacGia
from dbo.AUTHOR, dbo.BOOK_AUTHOR
where dbo.BOOK_AUTHOR.idBook=@idBook and dbo.AUTHOR.idAuthor=dbo.BOOK_AUTHOR.idAuthor)
go
select * from dbo.func_getAllAuthorOfBook(6)
go
--Trả về idCategory (Đầu vào là nameCategory)
create or alter function func_getIDCategory(@nameCategory nvarchar(20))
returns varchar(8)
as
begin
	declare @idCategory varchar(8)
	select @idCategory=CATEGORY.idCategory
	from dbo.CATEGORY
	where CATEGORY.nameCategory=@nameCategory

	return @idCategory
end
go
--Trả về idAuthor (Đầu vào là nameAuthor)
create or alter function func_getIDAuthor(@nameAuthor nvarchar(30))
returns varchar(8)
as
begin
	declare @idAuthor varchar(8)
	select @idAuthor=AUTHOR.idAuthor
	from dbo.AUTHOR
	where AUTHOR.nameAuthor=@nameAuthor

	return @idAuthor
end
go
--Kiểm tra trước khi thanh toán hóa đơn nhập
create or alter function func_checkInvoiceBillIn(@idBill varchar(8))
returns integer
as
begin
	declare @status bit, @total int
	select @status=dbo.BILLINPUT.sttus, @total=dbo.BILLINPUT.total
	from dbo.BILLINPUT
	where dbo.BILLINPUT.idBillInput=@idBill
	if(@total > 0 and @status = 0)
		return 1
	else if(@total > 0 and @status = 1)
		return 0
	return -1
end
go
--Kiểm tra trước khi thanh toán hóa đơn xuất
create or alter function func_checkInvoiceBillOut(@idBill varchar(8))
returns integer
as
begin
	declare @status bit, @total int
	select @status=dbo.BILLOUTPUT.sttus, @total=dbo.BILLOUTPUT.total
	from dbo.BILLOUTPUT
	where dbo.BILLOUTPUT.idBillOutput=@idBill
	if(@total > 0 and @status = 0)
		return 1
	else if(@total > 0 and @status = 1)
		return 0
	return -1
end
go
--Các hàm bổ trợ để thuận tiện cho việc lấy dữ liệu qua lại các form
