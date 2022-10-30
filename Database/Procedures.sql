use BOOKSTOREMANAGE
go

--Thêm sách vào Kho hàng (Nhập)
create or alter procedure pro_addNewKindOfBookInBillInput(@idBill int,  @idBook int, @amount int)
as
begin
	insert into dbo.BOOK_BILLINPUT (idBillInput, idBook, amountInput)
	values (@idBill, @idBook, @amount)
end
go


--Thêm một đơn hàng mới (nhập)
create or alter procedure proc_addNewBillInput (@idBillInput int, @dateOfBill date, @total int, @idEmployee int)
as
begin
	insert into dbo.BILLINPUT(dateOfInput, total, idEmployee)
	values (@dateOfBill, @total, @idEmployee)
end
go

--Procedure cập nhật tổng thanh toán bill khi nhập sách về
create or alter procedure proc_updateBookInput (@idBillInput int,@dateOfInput date, @payBill int,@idEmployee int)
as
begin
	--Update lại tổng tiền hóa đơn nhập sách
	update dbo.BILLINPUT
	set total+=@payBill, dateOfInput=@dateOfInput,idEmployee=@idEmployee
	where BILLINPUT.idBillInput=@idBillInput
end
GO

-- Update data Author
create procedure proc_updateAuthor (@id int, @nameAuthor int, @phoneNumber varchar)
as
begin
	update Author 
	set 
		nameAuthor = @nameAuthor, 
		phoneNumber = @phoneNumber
	where idAuthor = @id
end
go

-- Update publisher
create procedure proc_updatePublisher (@id int, @name nvarchar, @address nvarchar, @phoneNumber varchar)
as
begin
	update PUBLISHER 
	set
		namePublisher = @name,
		addressPublisher = @address,
		phoneNumber = @phoneNumber
end
go

-- Update total in BillOutPut
create procedure proc_UpdateTotalPriceInBillOutput (@id int)
as
begin
	declare @value int
	set @value = (select dbo.func_totalPayCurrent(@id))
	update BILLOUTPUT set total = @value where idBillOutPut = @id
end
go


-- Update amount Voucher
create procedure proc_UpdateAmountVoucher (@idBill int)
as
begin
	declare @idVoucher int
	set @idVoucher = (select VOUCHER.idVoucher from BILLOUTPUT, VOUCHER where BILLOUTPUT.idBillOutPut = @idBill and BILLOUTPUT.idVoucher = VOUCHER.idVoucher)
	update VOUCHER set amount -= 1 where idVoucher = @idVoucher
end
go

-- Xem danh sách các Voucher còn điều kiện (Nằm trong thời hạn và còn số lượng mới hiển thị)
create or alter procedure proc_ShowListVoucher (@dateCurent date)
as
begin
	select * from VOUCHER
	where dateStart <= @dateCurent and dateEnd >= @dateCurent
		and amount >0
	order by amount
end
go

-- Xóa voucher
create or alter procedure proc_DeleteVoucer (@id int)
as
begin
	delete VOUCHER where idVoucher = @id
end
go

-- Xóa voucher không tồn tại (Đã hết hạn, hoặc số lượng = 0)


-- Tạo hóa đơn output

create or alter procedure proc_CrateBillOutput (@dateCreate date, @idCustomer int, @idEmployee int, @idVoucher int, @idBook int, @amount int)
as
begin
	insert into BILLOUTPUT (dateOfBill, total, idCus, idEmployee, idVoucher) values (@dateCreate, 0, @idCustomer, @idEmployee, @idVoucher)
end
go

-- Tạo BOOK - BILLOUTPUT
create or alter proc proc_AddBookToBill (@idBill int, @idBook int, @amount int)
as
begin
	insert into BOOK_BILLOUTPUT values (@idBill, @idBook, @amount)
end
go


----------------------------CUSTOMER------------------------
---Thêm khách hàng
create or alter proc proc_InsertCustomer (@name varchar(30), @address varchar(30), @phoneNumber varchar(20))
as
begin
	insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus)
	values (@name, @address, @phoneNumber, 0)
end
go



--Xóa khách hàng
Create or alter proc proc_DeleteCustomer (@id int)
as
begin
	delete CUSTOMER where idCus = @id
end
go

--- Cập nhật khách hàng
create procedure proc_UpdateCustomer (@id int, @name nvarchar(30), @address nvarchar(30), @phoneNumber varchar(20))
as
begin
	update CUSTOMER set nameCus = @name, addressCus = @address, phoneNumber = @phoneNumber
	where idCus = @id
	print N'Update thành công'

end
go


-------------------------------------------Cập nhật điểm của khách hàng---------------------------------------------------------
Create procedure proc_UpdateScore (@id int, @price int)
as
begin
	declare @score int, @scoreCus int 

	set @scoreCus = (select pointCus from CUSTOMER where idCus = @id)

	set @score = (select dbo.CalcScore (@price))
	
	set @scoreCus += @score

	update CUSTOMER set pointCus = @scoreCus where idCus = @id
end
go


select * from CUSTOMER
select * from TYPECUSTOMER
-- Tìm kiếm khách hàng




-----------------BOOK----------------------------------

---- Cập nhật số lượng sách trong kho

create procedure proc_updateAmountBook (@idBook int, @amount int)
as
begin
	update BOOK
	set amount += @amount
	where idBook = @idBook
end
go

--- Xóa sách ra khỏi kho

create procedure proc_deleteBook (@idBook int)
as
begin
	declare @amountBook int
	set @amountBook = dbo.returnAmountBook(@idBook)
	if @amountBook > 0 -- Nếu trong kho còn sách thì không được xóa
	begin
		print N'Không thể xóa sách'
	end
	if @amountBook = 0
	begin
		delete BOOK_AUTHOR where idBook = @idBook
		delete BOOK_CATEGORY where idBook = @idBook
		delete BOOK where idBook = @idBook
		print N'Đã Xóa Thành Công'
	end
end
go

-- Lấy thông tin sách 
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


-- Tìm kiếm
Create or alter proc SearchBook (@id int, @name nvarchar(50))
as
begin

	select A.idBook, nameBook, nameAuthor, nameCategory, namePublisher, priceExport, amount from 
	(select BOOK.idBook, BOOK.nameBook, STRING_AGG(nameCategory, ' - ') as nameCategory, namePublisher, BOOK.priceExport, BOOK.amount from BOOK, BOOK_CATEGORY, CATEGORY, PUBLISHER
	where	(BOOK.idBook = @id or nameBook = @name) and
			BOOK.idPublisher = PUBLISHER.idPublisher and
			Book.idBook = BOOK_CATEGORY.idBook and 
			BOOK_CATEGORY.idCategory = CATEGORY.idCategory
	group by BOOK.idBook, BOOK.nameBook, namePublisher, BOOK.priceExport, BOOK.amount)A join

	(select BOOK.idBook, STRING_AGG(nameAuthor, ' - ') as nameAuthor from BOOK, BOOK_AUTHOR, AUTHOR
	where	Book.idBook = BOOK_AUTHOR.idBook and 
			BOOK_AUTHOR.idAuthor = AUTHOR.idAuthor
	group by BOOK.idBook) B on A.idBook = B.idBook


end
go



-- Xóa sách khỏi kho (Cần phải chỉnh sửa --Xóa ở các bảng có khóa ngoại trc (Tạo transacion))

Create or alter proc DeleteBook (@id int)
as
begin
	delete BOOK where idBook = @id
end
go



----------------------------------------------Cập nhật thông tin sách

Create or alter proc UpdateBook (@id int, @name nvarchar(50), @price int)
as
begin
	update BOOK set nameBook = @name, priceExport = @price where idBook = @id

end
go


----------------------------------------------------------------------AUTHOR--------------------------
---Thêm author
Create or alter proc InsertAuthor (@name varchar(30), @phoneNumber varchar(10))
as
begin
	insert into AUTHOR (nameAuthor, phoneNumber) values (@name, @phoneNumber)
end
go
----- Sửa Author
Create or alter proc UpdateAuthor (@id int, @name varchar(30), @phoneNumber varchar(10))
as
begin
	update AUTHOR set nameAuthor = @name, phoneNumber = @phoneNumber where idAuthor = @id
end
go

----------------------------------------------------------------------Xóa Author
Create or alter proc DeleteAuthor (@id int)
as
begin
	delete AUTHOR where idAuthor = @id
end
go

--Tìm kiếm author 
Create or alter proc SearchAuthor (@id int, @name varchar (30))
as
begin
		select * from AUTHOR where idAuthor = @id or nameAuthor = @name
end
go

--select * from AUTHOR
--exec SearchAuthor null, N'nguyen van A'

----------------------------------------------------------------Account-------------------------------
-- Thêm tài khoản
create or alter proc InsertAccount(@name varchar(20), @pass varchar(30), @type bit, @idEmployee int)
as
begin
	Insert into ACCOUNT (nameAccount, pass, typeOfAcc, idEmployee) values (@name, @pass, @type, @idEmployee)
end
go

--- Xóa tài khoản
Create or alter proc DeleteAccount (@id int)
as
begin
	Delete ACCOUNT where idAccount = @id
end
go

-- Sửa tài khoản 
Create or alter proc UpdateAccount (@id int, @name varchar(20), @pass varchar(30))
as
begin
	update ACCOUNT set nameAccount = @name, pass = @pass where idAccount = @id
end
go

-- Tìm kiếm tài khoản
Create or alter proc SearchAccount (@id int, @name varchar(20))
as
begin
	select * from ACCOUNT where idAccount = @id or nameAccount = @name
end
go

------------------------------------------------------ Employee
-- thêm nhân viên
Create or alter proc InsertEmployee (@firstName nvarchar(10), @middleName nvarchar(10), @lastName nvarchar (10), 
										@sex nvarchar(10), @addEmp nvarchar(30), @phoneNumber varchar(10), @email varchar(50),
										@yearOfBirth date)
as
begin
	Insert into EMPLOYEE (firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth)
	values (@firstName, @middleName, @lastName, @sex, @addEmp, @phoneNumber, @email, @yearOfBirth)
end
go

--Sửa nhân viên
Create or alter proc UpdateEmployee (@id int, @firstName nvarchar(10), @middleName nvarchar(10), @lastName nvarchar (10), 
										@sex nvarchar(10), @addEmp nvarchar(30), @phoneNumber varchar(10), @email varchar(50),
										@yearOfBirth date)
as
begin
	Update EMPLOYEE set firstName = @firstName, middleName = @middleName, lastName = @lastName, sex = @sex,
						addEmp = @addEmp, phoneNumber = @phoneNumber, email = @email, yearOfBirth = @yearOfBirth
					where idEmployee = @id
end
go

-- Xóa nhân viên 
Create or alter proc DeleteEmployee (@id int)
as
begin
	Delete EMPLOYEE where idEmployee = @id
end
go

-----------------------------------------------------PUBLISHER---------------------------------------------------
---Thêm nhà xuất bản
Create or alter proc InsertPublisher (@name nvarchar(30), @addr nvarchar(30), @phoneNumber varchar(10))
as
begin
	insert into PUBLISHER (namePublisher, addressPublisher, phoneNumber)
	values (@name, @addr, @phoneNumber)
end
go

-- Xóa nhà xuât bản
Create or alter proc DeletePublisher (@id int)
as
begin
	delete PUBLISHER where idPublisher = @id
end
go

-- Sửa nhà xuất bản
Create or alter proc UpdatePublisher (@id int, @name nvarchar(30), @addr nvarchar(30), @phoneNumber varchar(10))
as
begin
	Update PUBLISHER set namePublisher = @name, addressPublisher = @addr, phoneNumber = @phoneNumber where idPublisher = @id
end
go

-- Tìm kiếm nhà xuất bản
Create or alter proc SearchPublisher (@id int, @name nvarchar (30))
as
begin
	Select * from PUBLISHER where idPublisher = @id or namePublisher = @name
end
go

-----------------------------------------BILLOUTPUT---------------------------------------
---- Tạo hóa đơn------
create or alter proc CreateBillOutput (@idCus int, @idEmp int, @date date)
as
begin
	insert into BILLOUTPUT (dateOfBill, idCus, idEmployee)
	values (@date, @idCus, @idEmp)
end
go


--- lấy data BILLOUTPUT

Create or alter proc GetAllBill
as
	select idBillOutPut, idCus, idEmployee from BILLOUTPUT
go

create or alter proc GetBill (@idBill int)
as
begin
	select idBillOutPut, dateOfBill, total, nameCus, pointCus, BILLOUTPUT.idVoucher from BILLOUTPUT, CUSTOMER 
	where idBillOutPut = @idBill and
			BILLOUTPUT.idCus = CUSTOMER.idCus
end
go

--exec GetBill 1

--- Lấy data BOOK_BILLOUTPUT
create or alter proc GetCart (@idBill int)
as
begin
	Select idBillOutput, BOOK_BILLOUTPUT.idBook, nameBook, BOOK.priceExport, BOOK_BILLOUTPUT.amountOutput from BOOK, BOOK_BILLOUTPUT
	where idBillOutput = @idBill and
			BOOK.idBook = BOOK_BILLOUTPUT.idBook
end
go

-- Cập nhật giá tiền phải trả trong bill
Create or alter proc UpdateTotalMoney (@idBill int)
as
begin
	declare @totalMoney int
	set @totalMoney = (select dbo.func_totalPayCurrent(@idBill))
	update BILLOUTPUT set total = @totalMoney where idBillOutPut = @idBill
end
go


--- Thêm vào giỏ hàng
Create or alter proc AddBookToCart(@idBill int, @idBook int, @amount int)
as
begin
	Insert into BOOK_BILLOUTPUT values (@idBill, @idBook, @amount)
	exec UpdateTotalMoney @idBill
end
go

---- Cập nhật số lượng sách trong giỏ hàng
Create or alter proc UpdateAmountBookInCart (@idBill int, @idBook int, @amount int)
as
begin
	update BOOK_BILLOUTPUT set amountOutput = @amount
	where idBillOutput = @idBill and idBook = @idBook
	
	exec UpdateTotalMoney @idBill
end
go

--- Xóa sách trong giỏ hàng
Create or alter proc DeleteBookFromCart(@idBill int, @idBook int)
as
begin
	delete BOOK_BILLOUTPUT where idBillOutput = @idBill and idBook = @idBook

	exec UpdateTotalMoney @idBill
	
end
go

-- Xem voucher
Create or alter proc GetVoucher (@date  date)
as
begin
	select * from VOUCHER
	where dateStart <= @date and
			dateEnd >= @date
end
go


-----Áp dụng voucher
Create or alter proc AddVoucher (@idBill int, @idVoucher int)
as
begin
	update BILLOUTPUT set @idVoucher = @idVoucher where idBillOutPut = @idBill
	exec UpdateTotalMoney @idBill
end
go

-- Bỏ áp dụng voucher 
Create or alter proc RemoveVoucher(@idBill int)
as
begin
	update BILLOUTPUT set idVoucher = null where idBillOutPut = @idBill
	exec UpdateTotalMoney @idBill
end
go


------------------------------------------------------- Xóa đơn -----------------------------------------------------
Create or alter proc RemoveBill (@idBill int)
as begin
	delete BOOK_BILLOUTPUT where idBillOutput = @idBill
	delete BILLOUTPUT where idBillOutPut = @idBill
end
go


------------------------------------------------------- Xuất đơn -------------------------------------------------------
Create or alter proc Export(@idBill int, @flag bit)
as
begin
	begin transaction
		save transaction Confirm
		declare @idCus int
		--- Cập nhật lại số sách trong kho

		--- Cập nhật lại điểm cho người dùng
		set @idCus = (select idCus from BILLOUTPUT where idBillOutPut = @idBill)
		exec Up
		--- Cập nhật lại số lượng voucher

		if (@flag = 0)
		begin 
			rollback transaction Confirm
			exec RemoveBill @idBill
		end

	end
	
end
go



-----------------------------------------------------------BOOK INPUT----------------------------------------------------------------------
------------------------------------------------ Thêm sách vào kho ---------------------------------------------------------------------
Create or alter proc AddBook (@nameBook nvarchar(20), @amount int, @priceImport int, @priceExport int, @idPublisher int)
as
begin
	Insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher)
	values (@nameBook, @amount, @priceImport, @priceExport, @idPublisher)
end
go

------------------------------------------------ Tạo hóa đơn Input ---------------------------------------------------------------------
Create or alter proc CreateBillInput (@date Datetime, @idEmployee int)
as
begin
	Insert into BILLINPUT (dateOfInput, idEmployee) values (@date, @idEmployee)

end
go

------------------------------------------------ Tạo bill nhập sách ---------------------------------------------------------------------
Create or alter proc CreateBookBillInput (@idBill int, @idBook int, @amount int)
as
begin
	Insert into BOOK_BILLINPUT (idBillInput, idBook, amountInput)
	values (@idBill, @idBook, @amount)
end
go

select * from BOOK
select * from BOOK_BILLINPUT
select * from BILLINPUT


select * from BOOK