use BOOKSTOREMANAGE
go

-----------------------------------------Function phụ trợ--------------------------------------------------
--Hàm tính tổng tiền hóa đơn khi chưa áp dụng bất cứ voucher nào
create or alter function func_totalPayBeforeDiscount(@idBill int)
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
create or alter function func_searchAccount(@idAcc int, @userName varchar(20), @password varchar(30), @typeAcc bit, @idEmp int)
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
go
exec GetBook