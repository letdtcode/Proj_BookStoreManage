
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
--Check xem ID sách này có trong đơn hàng chưa. Trả về true nếu đã tồn tại trong đơn hàng, trả về false nếu chưa tồn tại
create or alter function func_checkBookIsInBill(@idBill varchar(8), @idBook varchar(8))
returns bit
as
begin
	if exists(select * 
				from dbo.BOOK_BILLOUTPUT 
				where BOOK_BILLOUTPUT.idBillOutput=@idBill and BOOK_BILLOUTPUT.idBook=@idBook)
			return 1
	return 0		
end
go
--Lấy thông tin chi tiết hóa đơn xuất
create or alter function func_getDataOfBillExport(@idBill varchar(8))
returns table
as 
	return ( select BOOK_BILLOUTPUT.idBook as N'ID', BOOK.nameBook as N'Tên Sách', BOOK_BILLOUTPUT.amountOutput as N'Số lượng'
			from dbo.BOOK_BILLOUTPUT, dbo.BOOK
			where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill and dbo.BOOK_BILLOUTPUT.idBook=BOOK.idBook )
go
--Lấy thông tin chi tiết hóa đơn nhập
create or alter function func_getDataOfBillImport(@idBill varchar(8))
returns table
as 
	return ( select BOOK_BILLINPUT.idBook as N'ID', BOOK.nameBook as N'Tên Sách', BOOK_BILLINPUT.amountInput as N'Số lượng'
			from dbo.BOOK_BILLINPUT, dbo.BOOK
			where dbo.BOOK_BILLINPUT.idBillInput=@idBill and dbo.BOOK_BILLINPUT.idBook=BOOK.idBook )
go
select * from dbo.func_getDataOfBillImport('HDN3')
-----
--Hàm trả về tên khách hàng (đầu vào là mã Bill)
create or alter function func_getNameCusOfBillOutPut(@idBill varchar(8))
returns varchar(30)
begin
return (select dbo.CUSTOMER.nameCus
from dbo.CUSTOMER, dbo.BILLOUTPUT
where dbo.CUSTOMER.idCus=dbo.BILLOUTPUT.idCus and dbo.BILLOUTPUT.idBillOutPut=@idBill)
end
go
--Hàm trả về tên nhân viên (đầu vào là mã Bill)
create or alter function func_getNameEmpOfBillOutPut(@idBill varchar(8))
returns varchar(30)
begin
return (select CONCAT(dbo.EMPLOYEE.firstName,dbo.EMPLOYEE.middleName,dbo.EMPLOYEE.lastName)
from dbo.EMPLOYEE, dbo.BILLOUTPUT
where dbo.EMPLOYEE.idEmployee=dbo.BILLOUTPUT.idEmployee and dbo.BILLOUTPUT.idBillOutPut=@idBill)
end
go
select dbo.func_getNameEmpOfBillOutPut('HDX1')
go
--Hàm trả về giá bán của 1 loại sách, đầu vào là idBook
create or alter function func_getPriceExportOfBook(@idBook varchar(8))
returns int
begin
return (select dbo.BOOK.priceExport
from dbo.BOOK
where dbo.BOOK.idBook=@idBook)
end
go
----------------------------------------------CHỨC NĂNG XEM CHI TIẾT ĐƠN HÀNG XUất---------------
--Trả về tên sách
create or alter function func_getNameBookById(@idBook varchar(8))
returns varchar(20)
begin
return (select dbo.BOOK.nameBook
from dbo.BOOK
where dbo.BOOK.idBook=@idBook)
end
go
--Trả về số lượng sách trong kho
create or alter function func_getAmountBookById(@idBook varchar(8))
returns int
begin
return (select dbo.BOOK.amount
from dbo.BOOK
where dbo.BOOK.idBook=@idBook)
end
go
--Tính tổng tiền hóa đơn xuất
create or alter function func_returnToTalOfBillOutput(@idBill varchar(8))
returns int
begin
if not exists(select * from dbo.BOOK_BILLOUTPUT where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill)
return 0
return (select sum(Q.TotalBook) 
	from (select dbo.BOOK_BILLOUTPUT.amountOutput*dbo.BOOK.priceExport as TotalBook from dbo.BOOK_BILLOUTPUT, dbo.BOOK where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill and dbo.BOOK.idBook=dbo.BOOK_BILLOUTPUT.idBook) as Q)
end
go
Select dbo.func_returnToTalOfBillOutput('BILL1')
--Tính tổng tiền hóa đơn nhập
--thiếu điều kiện nên null (note)
create or alter function func_returnToTalOfBillInput(@idBill varchar(8))
returns int
begin
if not exists(select * from dbo.BOOK_BILLINPUT where dbo.BOOK_BILLINPUT.idBillInput=@idBill)
return 0
return (select sum(Q.TotalBook) 
	from (select dbo.BOOK_BILLINPUT.amountInput*dbo.BOOK.priceImport as TotalBook from dbo.BOOK_BILLINPUT, dbo.BOOK where dbo.BOOK_BILLINPUT.idBillInput=@idBill and dbo.BOOK.idBook=dbo.BOOK_BILLINPUT.idBook) as Q)
end
go
select dbo.func_returnToTalOfBillInput('HDN3')
go
----------------------------------------------Dũng thêm-------------------------------------------
---Hàm trả về mã nhân viên, tên nhân viên khi đăng nhập
create or alter function func_getIdEmployee (@user varchar(20), @password varchar(30))
returns @table table (
	idEmp varchar(8),
	nameEmp nvarchar (40),
	idRole bit
	)
as
begin
	declare @idEmp varchar(8), @firstName nvarchar(10), @middleName nvarchar(10), @lastName nvarchar (10), @name nvarchar (40), @idRole bit
	select @idEmp = ACCOUNT.idEmployee,
	@middleName = middleName,
	@firstName = firstName,
	@lastName = lastName,
	@idRole = typeOfAcc
	from ACCOUNT, EMPLOYEE 
	where  nameAccount=@user and
			password = @password and
			ACCOUNT.idEmployee = EMPLOYEE.idEmployee

			
	set @name = @firstName + ' ' + @middleName + ' ' + @lastName
	insert into @table values (@idEmp, @name, @idRole)
	return
end
go