use BOOKSTOREMANAGE
go
-----------------------------------------Function phụ trợ--------------------------------------------------
--Hàm kiểm tra voucher còn trong thời gian sử dụng hay không và 
create or alter function func_checkVoucherValidOrNot(@dateStart date, @dateEnd date, @dateCurrent date)
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
--Hàm kiểm tra số điện thoại đúng định dạng (đúng 10 chữ số và có số 0 đầu tiên)
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

--Tìm kiếm một Account
create or alter function func_searchAccount(@idAcc int, @userName varchar(20), @password varchar(30), @typeAcc bit, @idEmp int)
returns table
as
	return ( select *
	from dbo.ACCOUNT
	where ACCOUNT.idAccount=@idAcc and
			ACCOUNT.nameAccount like @userName+'%' and 
			ACCOUNT.password like @password+'%' and 
			ACCOUNT.typeOfAcc = typeOfAcc and 
			ACCOUNT.idEmployee=@idEmp )
go
--Trả về danh sách các thể loại của sách
create or alter function func_getAllCategoryOfBook(@idBook int)
returns table
as 
return (select distinct dbo.CATEGORY.nameCategory as TheLoai
from dbo.CATEGORY, dbo.BOOK_CATEGORY
where dbo.BOOK_CATEGORY.idBook=@idBook and dbo.CATEGORY.idCategory=dbo.BOOK_CATEGORY.idCategory)
go
--Trả về danh sách các tác giả của sách
create or alter function func_getAllAuthorOfBook(@idBook int)
returns table
as 
return (select distinct dbo.AUTHOR.nameAuthor as TacGia
from dbo.AUTHOR, dbo.BOOK_AUTHOR
where dbo.BOOK_AUTHOR.idBook=@idBook and dbo.AUTHOR.idAuthor=dbo.BOOK_AUTHOR.idAuthor)
go

--Trả về idCategory (Đầu vào là nameCategory)
create or alter function func_getIDCategory(@nameCategory nvarchar(20))
returns int
as
begin
	declare @idCategory int
	select @idCategory=CATEGORY.idCategory
	from dbo.CATEGORY
	where CATEGORY.nameCategory=@nameCategory

	return @idCategory
end
go
--Trả về idAuthor (Đầu vào là nameAuthor)
create or alter function func_getIDAuthor(@nameAuthor nvarchar(30))
returns int
as
begin
	declare @idAuthor int
	select @idAuthor=AUTHOR.idAuthor
	from dbo.AUTHOR
	where AUTHOR.nameAuthor=@nameAuthor

	return @idAuthor
end
go

--Check xem ID sách này có trong đơn hàng chưa. Trả về true nếu đã tồn tại trong đơn hàng, trả về false nếu chưa tồn tại
create or alter function func_checkBookIsInBill(@idBill int, @idBook int)
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
create or alter function func_getDataOfBillExport(@idBill int)
returns table
as 
	return ( select BOOK_BILLOUTPUT.idBook as N'ID', BOOK.nameBook as N'Tên Sách', BOOK_BILLOUTPUT.amountOutput as N'Số lượng'
			from dbo.BOOK_BILLOUTPUT, dbo.BOOK
			where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill and dbo.BOOK_BILLOUTPUT.idBook=BOOK.idBook )
go
--Lấy thông tin chi tiết hóa đơn nhập
create or alter function func_getDataOfBillImport(@idBill int)
returns table
as 
	return ( select BOOK_BILLINPUT.idBook as N'ID', BOOK.nameBook as N'Tên Sách', BOOK_BILLINPUT.amountInput as N'Số lượng'
			from dbo.BOOK_BILLINPUT, dbo.BOOK
			where dbo.BOOK_BILLINPUT.idBillInput=@idBill and dbo.BOOK_BILLINPUT.idBook=BOOK.idBook )
go

--Hàm trả về tên khách hàng (đầu vào là mã Bill)
create or alter function func_getNameCusOfBillOutPut(@idBill int)
returns varchar(30)
begin
	return (select dbo.CUSTOMER.nameCus
	from dbo.CUSTOMER, dbo.BILLOUTPUT
	where dbo.CUSTOMER.idCus=dbo.BILLOUTPUT.idCus and dbo.BILLOUTPUT.idBillOutPut=@idBill)
end
go
--Hàm trả về tên nhân viên (đầu vào là mã Bill)
create or alter function func_getNameEmpOfBillOutPut(@idBill int)
returns varchar(30)
begin
	return (select CONCAT(dbo.EMPLOYEE.firstName,dbo.EMPLOYEE.middleName,dbo.EMPLOYEE.lastName)
	from dbo.EMPLOYEE, dbo.BILLOUTPUT
	where dbo.EMPLOYEE.idEmployee=dbo.BILLOUTPUT.idEmployee and dbo.BILLOUTPUT.idBillOutPut=@idBill)
end
go

----------------------------------------------CHỨC NĂNG XEM CHI TIẾT ĐƠN HÀNG XUất---------------
--Trả về tên sách
create or alter function func_getNameBookById(@idBook int)
returns varchar(20)
begin
	return (select dbo.BOOK.nameBook
	from dbo.BOOK
	where dbo.BOOK.idBook=@idBook)
end
go
--Trả về số lượng sách trong kho
create or alter function func_getAmountBookById(@idBook int)
returns int
begin
	return (select dbo.BOOK.amount
	from dbo.BOOK
	where dbo.BOOK.idBook=@idBook)
end
go
--Tính tổng tiền hóa đơn xuất
create or alter function func_returnToTalOfBillOutput(@idBill int)
returns int
begin
	if not exists(select * from dbo.BOOK_BILLOUTPUT where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill)
	return 0
	return (select sum(Q.TotalBook) 
		from (select dbo.BOOK_BILLOUTPUT.amountOutput*dbo.BOOK.priceExport as TotalBook from dbo.BOOK_BILLOUTPUT, dbo.BOOK where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill and dbo.BOOK.idBook=dbo.BOOK_BILLOUTPUT.idBook) as Q)
end
go
--Tính tổng tiền hóa đơn nhập
create or alter function func_returnToTalOfBillInput(@idBill int)
returns int
begin
	if not exists(select * from dbo.BOOK_BILLINPUT where dbo.BOOK_BILLINPUT.idBillInput=@idBill)
	return 0
	return (select sum(Q.TotalBook) 
		from (select dbo.BOOK_BILLINPUT.amountInput*dbo.BOOK.priceImport as TotalBook from dbo.BOOK_BILLINPUT, dbo.BOOK where dbo.BOOK_BILLINPUT.idBillInput=@idBill and dbo.BOOK.idBook=dbo.BOOK_BILLINPUT.idBook) as Q)
end
go
----------------------------------------------Dũng thêm-------------------------------------------
---Hàm trả về mã nhân viên, tên nhân viên khi đăng nhập
create or alter function func_getIdEmployee (@user varchar(20), @password varchar(30))
returns @table table (
	idEmp int,
	nameEmp nvarchar (40),
	idRole bit
	)
as
begin
	declare @idEmp int, @firstName nvarchar(10), @middleName nvarchar(10), @lastName nvarchar (10), @name nvarchar (40), @idRole bit
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
--Hàm trả về giá trị phần trăm giảm của thẻ VIP
create or alter function func_getValueDiscountOfTypeCustomer(@idCustomer int)
returns int
as
begin
	declare @discountOfTypeCus int
	select @discountOfTypeCus=dbo.TYPECUSTOMER.valueTypeCus
	from dbo.TYPECUSTOMER, dbo.CUSTOMER
	where dbo.CUSTOMER.idCus=@idCustomer and dbo.CUSTOMER.idTypeCus=dbo.TYPECUSTOMER.idTypeCus
	return @discountOfTypeCus
end
go
------- Hàm tìm kiếm account
Create or alter function func_searchAccount (@idAccount int, @username varchar(20))
returns table
as
	return (select * from ACCOUNT 
			where nameAccount = @username or
					idAccount = @idAccount)
go

--- Hàm tìm kiếm author
Create or alter function func_searchAuthor (@idAuthor int, @nameAuthor nvarchar(30))
returns table
as
	return (
		select * from AUTHOR
		where idAuthor = @idAuthor or
				nameAuthor = @nameAuthor
	)
go
---Hàm tìm kiếm thể loại
create or alter function func_searchCategory (@idCategory int, @nameCategory nvarchar(20))
returns table
as
	return (
		select * from CATEGORY
		where idCategory = @idCategory or
				nameCategory = @nameCategory
	)
go
-- Hàm tìm kiếm Nhân viên
Create or alter function func_searchEmployee (@idEmployee int, @nameEmployee nvarchar (40))
returns table
as
	return (
		select idEmployee, firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth
		from EMPLOYEE
		where idEmployee = @idEmployee or
				(firstName + ' ' + middleName + ' '+lastName = @nameEmployee)
	)
go


--- Hàm tìm kiếm sách
--Hàm tìm kiếm khách hàng
Create or alter function func_searchCustomer (@idCustomer int, @nameCustomer nvarchar(40))
returns table
as
	return (
		select * from CUSTOMER
		where idCus =@idCustomer or
				nameCus = @nameCustomer
	)
go

--- Hàm tìm kiếm nhà xuất bản
Create or alter function func_searchPublisher (@idPublisher int, @namePublisher nvarchar(80))
returns table
as
	return (
		select * from PUBLISHER
		where idPublisher =@idPublisher or
				namePublisher = @namePublisher
	)
go

--- Hàm tìm kiếm hóa đơn xuất
Create or alter function func_searchReceiptExport (@idBill int)
returns table
as
	return (
		select * from BILLOUTPUT where idBillOutPut = @idBill
	)
go

--- Hàm tìm kiếm voucher
Create or alter function func_searchVoucher(@idVoucher int)
returns table
as
	return (
		select * from VOUCHER where idVoucher = @idVoucher
	)
go


--- Hàm Tìm kiếm loại khách hàng
Create or alter function func_searchTypeCustomer(@id int, @name nvarchar(30))
returns table
as
	return (
		select * from TYPECUSTOMER
		where idTypeCus = @id or
				nameTypeCus = nameTypeCus
	)
go

--- Hàm tìm kiếm hóa đơn Nhập hàng
Create or alter function func_searchReceiptImport(@idBill int)
returns table
as
	return (
		select * from BILLINPUT where idBillInput = @idBill
	)
go
