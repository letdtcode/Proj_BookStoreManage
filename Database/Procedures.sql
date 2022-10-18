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
create or alter procedure proc_UpdateCustomer (@id int, @name nvarchar(30), @address nvarchar(30), @phoneNumber varchar(20))
as
begin
	update CUSTOMER set nameCus = @name, addressCus = @address, phoneNumber = @phoneNumber
	where idCus = @id
	print N'Update thành công'

end
go

--select * from CUSTOMER
--exec UpdateCustomer 4, N'AAA', 'GL', '0123456787'

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

-- Tìm kiếm thông tin của sách trong kho


-----------------------AUTHOR--------------------------
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

---Xóa Author
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

select * from AUTHOR
exec SearchAuthor null, N'nguyen van A'

-------------

