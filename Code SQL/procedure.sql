use BOOKSTOREMANAGE
go
-----------------------------PROCEDURE-------------------------

--PROCEDURE THÊM, SỬA, XÓA ACCOUNT
--Thêm một account mới
create or alter procedure proc_addNewAccount
@idAccount varchar(8),
@nameAccount varchar(20),
@password varchar(30),
@typeOfAcc bit,
@idEmployee varchar(8)
as
begin
	insert into dbo.ACCOUNT 
		(
	idAccount,
	nameAccount,
	password,
	typeOfAcc,
	idEmployee
		)
	values
		(
	@idAccount,
	@nameAccount,
	@password,
	@typeOfAcc,
	@idEmployee
		)
end
go
--Chỉnh sửa một Account
create or alter procedure proc_updateAccount
@idAccount varchar(8),
@nameAccount varchar(20),
@password varchar(30),
@typeOfAcc bit,
@idEmployee varchar(8)
as
begin
	update dbo.ACCOUNT
	set ACCOUNT.nameAccount=@nameAccount, ACCOUNT.password=@password, ACCOUNT.typeOfAcc=@typeOfAcc, ACCOUNT.idEmployee=@idEmployee
	where ACCOUNT.idAccount=@idAccount
end
go
--Xóa một Account
create or alter procedure proc_DeleteAccount
@idAccount varchar(8)
as
begin
	delete from dbo.ACCOUNT
	where dbo.ACCOUNT.idAccount=@idAccount
end
go
--Tìm kiếm account
--create or alter procedure proc_searchAccount
--@idAccount varchar(8),
--@userName varchar(20),
--@password varchar(30),
--@typeAcc bit,
--@idEmployee varchar(8)
--as
--begin
--select * 
--from dbo.ACCOUNT
--where 

--end
--go
--CHưa
-- Đổi mật khẩu account
--create or alter procedure proc_changepassAcc
--@acc_name varchar(30),
--@password_old varchar(30),
--@password_new varchar(30),
--@password_confirm varchar(30)
--as
--begin 
--	declare @acc_passwd varchar(30), @status varchar(150)
--	if exists(select *from dbo.ACCOUNT where ACCOUNT.nameAccount = @acc_name and ACCOUNT.pass = @password_old)
--	begin 
--		if(@password_old != @password_new)
--		begin 
--			if(@password_new = @password_confirm)
--			begin
--				update dbo.ACCOUNT set ACCOUNT.pass=@password_new
--				where ACCOUNT.nameAccount = @acc_name
--				set @status = 'Thay đổi mật khẩu thành công!!'
--			end
--			else
--			begin
--				set @status = 'Xác nhận mật khẩu không chính xác!!'
--			end
--		end
--		else
--		begin
--			set @status = 'New password must be different from the old password'
--		end
--	end
--	else
--	begin
--		set @status = 'Mật khẩu không chính xác!'
--	end
--	select @status as status

--end
--go
----Kiểm tra đăng nhập
--create or alter procedure proc_checklogin
--@acc_name varchar(30),
--@password varchar(30)
--as
--begin
--	declare @status nvarchar(50), @role varchar(30)
--	if exists (select * from dbo.ACCOUNT where ACCOUNT.nameAccount = @acc_name and ACCOUNT.pass = @password)
--	begin
--		set @role = (select typeOfAcc from dbo.ACCOUNT where ACCOUNT.nameAccount = @acc_name)
--		set @status = 'Đăng nhập thành công!';
--	end
--	else
--		set @status = 'Sai thông tin đăng nhập!!';
--	select @status as status, @role as role
--end
--go

--PROCEDURE THÊM, SỬA, XÓA AUTHOR
--Thêm một Author
create or alter procedure proc_addNewAuthor
@idAuthor varchar(8),
@nameAuthor nvarchar(30),
@phoneNumber varchar(10)
as
begin
	insert into dbo.AUTHOR
		(
	idAuthor,
	nameAuthor,
	phoneNumber
		)
	values
		(
	@idAuthor,
	@nameAuthor,
	@phoneNumber
		)
end
go


--Chỉnh sửa một Author
create or alter procedure proc_updateAuthor
@idAuthor varchar(8),
@nameAuthor nvarchar(30),
@phoneNumber varchar(10)
as
begin
	update dbo.AUTHOR
	set AUTHOR.nameAuthor=@nameAuthor, AUTHOR.phoneNumber=@phoneNumber
	where dbo.AUTHOR.idAuthor=@idAuthor
end
go
--Xóa một Author
create or alter procedure proc_DeleteAuthor
@idAuthor varchar(8)
as
begin
	delete from dbo.AUTHOR
	where dbo.AUTHOR.idAuthor=@idAuthor
end
go
--PROCEDURE THÊM, SỬA, XÓA BOOK
--Thêm một Book
create or alter procedure proc_addNewBook
@idBook varchar(8),
@nameBook nvarchar(20),
@urlImage image,
@amount int,
@priceImport int,
@priceExport int,
@idPublisher varchar(8)
as
begin
	insert into dbo.BOOK
		(
	idBook,
	nameBook,
	urlImage,
	amount,
	priceImport,
	priceExport,
	idPublisher
		)
	values
		(
	@idBook,
	@nameBook,
	@urlImage,
	@amount,
	@priceImport,
	@priceExport,
	@idPublisher
		)
end
go
--Chỉnh sửa một Book
create or alter procedure proc_updateBook
@idBook varchar(8),
@nameBook nvarchar(20),
@urlImage image,
@amount int,
@priceImport int,
@priceExport int,
@idPublisher varchar(8)
as
begin
	update dbo.BOOK
	set BOOK.nameBook=@nameBook, BOOK.urlImage=@urlImage, BOOK.amount=@amount, BOOK.priceImport=@priceImport, BOOK.priceExport=@priceExport, BOOK.idPublisher=@idPublisher
	where dbo.BOOK.idBook=@idBook
end
go
--Xóa một Book
create or alter procedure proc_DeleteBook
@idBook varchar(8)
as
begin
	delete from dbo.BOOK
	where dbo.BOOK.idBook=@idBook
end
go
--PROCEDURE THÊM, SỬA, XÓA BOOK_AUTHOR
--Thêm tên tác giả cho sách
create or alter procedure proc_addNewBookAuthor
@idBook varchar(8),
@idAuthor varchar(8)
as
begin
	insert into dbo.BOOK_AUTHOR
		(
	idBook,
	idAuthor
		)
	values
		(
	@idBook,
	@idAuthor
		)
end
go
--Chỉnh sửa tên tác giả cho sách
create or alter procedure proc_updateBookAuthor
@idBook varchar(8),
@idAuthor varchar(8),
@idNewAuthor varchar(8) 
as
begin
	update dbo.BOOK_AUTHOR
	set idAuthor=@idNewAuthor
	where dbo.BOOK_AUTHOR.idBook=@idBook
end
go
--Xóa bộ sách-tác giả
create or alter procedure proc_deleteBookAuthor
@idBook varchar(8),
@idAuthor varchar(8)
as
begin
	delete from dbo.BOOK_AUTHOR
	where dbo.BOOK_AUTHOR.idBook=@idBook and dbo.BOOK_AUTHOR.idAuthor=@idAuthor
end
go
--PROCEDURE THÊM, SỬA, XÓA BOOK_CATEGORY
--Thêm thể loại cho sách
create or alter procedure proc_addNewBookCategory
@idBook varchar(8),
@idCategory varchar(8)
as
begin
	insert into dbo.BOOK_CATEGORY
		(
	idBook,
	idCategory
		)
	values
		(
	@idBook,
	@idCategory
		)
end
go
--Chỉnh sửa thể loại cho sách
create or alter procedure proc_updateBookCategory
@idBook varchar(8),
@idCategory varchar(8), 
@idNewBook varchar(8),
@idNewCategory varchar(8)
as
begin
	if (@idNewCategory is null and @idNewBook is not null)
	begin
		update dbo.BOOK_CATEGORY
		set idBook=@idNewBook
		where dbo.BOOK_CATEGORY.idCategory=@idCategory and dbo.BOOK_CATEGORY.idBook=@idBook
	end
	else if (@idNewBook is null and @idNewCategory is not null)
	begin
		update dbo.BOOK_CATEGORY
		set idCategory=@idNewCategory
		where dbo.BOOK_CATEGORY.idCategory=@idCategory and dbo.BOOK_CATEGORY.idBook=@idBook
	end
	else
	begin
		update dbo.BOOK_CATEGORY
		set idBook=@idNewBook, idCategory=@idNewCategory
		where dbo.BOOK_CATEGORY.idCategory=@idCategory and dbo.BOOK_CATEGORY.idBook=@idBook
	end
end
go
--Xóa bộ sách-thể loại
create or alter procedure proc_deleteBookCategory
@idBook varchar(8),
@idCategory varchar(8)
as
begin
	delete from dbo.BOOK_CATEGORY
	where dbo.BOOK_CATEGORY.idBook=@idBook and dbo.BOOK_CATEGORY.idCategory=@idCategory
end
go
--PROCEDURE THÊM, SỬA, XÓA CATEGORY
--Thêm một thể loại mới 
create or alter procedure proc_addNewCategory
@idCategory varchar(8),
@nameCategory nvarchar(20),
@describleCategory nvarchar(50)
as
begin
	insert into dbo.CATEGORY
		(
	idCategory,
	nameCategory,
	describeCategory
		)
	values
		(
	@idCategory,
	@nameCategory,
	@describleCategory
		)
end
go
--Chỉnh sửa một thể loại
create or alter procedure proc_updateCategory
@idCategory varchar(8),
@nameCategory nvarchar(20),
@describleCategory nvarchar(50)
as
begin
	update dbo.CATEGORY
	set nameCategory=@nameCategory, describeCategory=@describleCategory
	where dbo.CATEGORY.idCategory=@idCategory
end
go
--Xóa một thể loại
create or alter procedure proc_deleteCategory
@idCategory varchar(8)
as
begin
	delete from dbo.CATEGORY
	where dbo.CATEGORY.idCategory=@idCategory
end
go
--PROCEDURE CUSTOMER
--Thêm một Customer
create or alter procedure proc_addNewCustomer
@idCustomer varchar(8),
@nameCus nvarchar(30),
@addressCus nvarchar(30),
@phoneNumber varchar(20),
@idTypeCus varchar(8)
as
begin
	insert into dbo.CUSTOMER
		(
	idCus,
	nameCus,
	addressCus,
	phoneNumber,
	idTypeCus
		)
	values
		(
	@idCustomer,
	@nameCus,
	@addressCus,
	@phoneNumber,
	@idTypeCus
		)
end
go
--Chỉnh sửa một Customer
create or alter procedure proc_updateCustomer
@idCus varchar(8),
@nameCus nvarchar(30),
@addressCus nvarchar(30),
@phoneNumber varchar(20),
@idTypeCus varchar(8)
as
begin
	update dbo.CUSTOMER
	set nameCus=@nameCus, addressCus=@addressCus, phoneNumber=@phoneNumber, idTypeCus=@idTypeCus
	where dbo.CUSTOMER.idCus=@idCus
end
go
--Xóa một Customer
create or alter procedure proc_deleteCustomer
@idCus varchar(8)
as
begin
	delete from dbo.CUSTOMER
	where dbo.CUSTOMER.idCus=@idCus
end
go

--PROCEDURE EMPLOYEE
--Thêm một Employee
create or alter procedure proc_addNewEmployee
@idEmployee varchar(8),
@firstName nvarchar(10),
@middleName nvarchar(10),
@lastName nvarchar(10),
@sex nvarchar(5),
@addEmp nvarchar(30),
@phoneNumber varchar(10),
@email varchar(50),
@yearOfBirth date
as
begin
	insert into dbo.EMPLOYEE
		(
	idEmployee,
	firstName,
	middleName,
	lastName,
	sex,
	addEmp,
	phoneNumber,
	email,
	yearOfBirth
		)
	values
		(
	@idEmployee,
	@firstName,
	@middleName,
	@lastName,
	@sex,
	@addEmp,
	@phoneNumber,
	@email,
	@yearOfBirth
		)
end
go
--Chỉnh sửa một Employee
create or alter procedure proc_updateEmployee
@idEmployee varchar(8),
@firstName nvarchar(10),
@middleName nvarchar(10),
@lastName nvarchar(10),
@sex nvarchar(5),
@addEmp nvarchar(30),
@phoneNumber varchar(10),
@email varchar(50),
@yearOfBirth date
as
begin
	update dbo.EMPLOYEE
	set firstName=@firstName, middleName=@middleName, lastName=@lastName, sex=@sex, addEmp=@addEmp, phoneNumber=@phoneNumber, email=@email, yearOfBirth=@yearOfBirth
	where dbo.EMPLOYEE.idEmployee=@idEmployee
end
go
--Xóa một Employee
create or alter procedure proc_deleteEmployee
@idEmployee varchar(8)
as
begin
	delete from dbo.EMPLOYEE
	where dbo.EMPLOYEE.idEmployee=@idEmployee
end
go
--PROCEDURE PUBLISHER
--Thêm một Publisher
create or alter procedure proc_addNewPublisher
@idPublisher varchar(8),
@namePublisher nvarchar(30),
@addPublisher nvarchar(30),
@phoneNumber varchar(10)
as
begin
	insert into dbo.PUBLISHER
		(
	idPublisher,
	namePublisher,
	addressPublisher,
	phoneNumber
		)
	values
		(
	@idPublisher,
	@namePublisher,
	@addPublisher,
	@phoneNumber
		)
end
go
--Chỉnh sửa một Publisher
create or alter procedure proc_updatePublisher
@idPublisher varchar(8),
@namePublisher nvarchar(30),
@addPublisher nvarchar(30),
@phoneNumber varchar(10)
as
begin
	update dbo.PUBLISHER
	set namePublisher=@namePublisher, addressPublisher=@addPublisher, phoneNumber=@phoneNumber
	where dbo.PUBLISHER.idPublisher=@idPublisher
end
go
--Xóa một Publisher
create or alter procedure proc_deletePublisher
@idPublisher varchar(8)
as
begin
	delete from dbo.PUBLISHER
	where dbo.PUBLISHER.idPublisher=@idPublisher
end
go
--PROCEDURE TYPECUSTOMER
--Thêm một TypeCustomer
create or alter procedure proc_addNewTypeCustomer
@idTypeCustomer varchar(8),
@nameTypeCus nvarchar(30),
@pointMark int,
@valueTypeCus int
as
begin
	insert into dbo.TYPECUSTOMER
		(
	idTypeCus,
	nameTypeCus,
	pointMark,
	valueTypeCus
		)
	values
		(
	@idTypeCustomer,
	@nameTypeCus,
	@pointMark,
	@valueTypeCus
		)
end
go
--Chỉnh sửa một Type Customer
create or alter procedure proc_updateTypeCustomer
@idTypeCus varchar(8),
@nameTypeCus nvarchar(30),
@pointMark int,
@valueTypeCus int
as
begin
	update dbo.TYPECUSTOMER
	set nameTypeCus=@nameTypeCus, pointMark=@pointMark, valueTypeCus=@valueTypeCus
	where dbo.TYPECUSTOMER.idTypeCus=@idTypeCus
end
go
--Xóa một TypeCustomer
create or alter procedure proc_deleteTypeCustomer
@idTypeCus varchar(8)
as
begin
	delete from dbo.TYPECUSTOMER
	where dbo.TYPECUSTOMER.idTypeCus=@idTypeCus
end
go
--PROCEDURE VOUCHER
--Thêm một Voucher
create or alter procedure proc_addNewVoucher
@idVoucher varchar(8),
@valueVoucher int,
@nameOfEvent nvarchar(40),
@dateStart date,
@dateEnd date,
@amount int
as
begin
	insert into dbo.VOUCHER
		(
	idVoucher,
	valueVoucher,
	nameOfEventVoucher,
	dateStart,
	dateEnd,
	amount
		)
	values
		(
	@idVoucher,
	@valueVoucher,
	@nameOfEvent,
	@dateStart,
	@dateEnd,
	@amount
		)
end
go
--Chỉnh sửa một Voucher
create or alter procedure proc_updateVoucher
@idVoucher varchar(8),
@valueVoucher int,
@nameOfEvent nvarchar(40),
@dateStart date,
@dateEnd date,
@amount int
as
begin
	update dbo.VOUCHER
	set valueVoucher=@valueVoucher, nameOfEventVoucher=@nameOfEvent, dateStart=@dateStart, dateEnd=@dateEnd, amount=@amount
	where dbo.VOUCHER.idVoucher=@idVoucher
end
go
--Xóa một Voucher
create or alter procedure proc_deleteVoucher
@idVoucher varchar(8)
as
begin
	delete from dbo.VOUCHER
	where dbo.VOUCHER.idVoucher=@idVoucher
end
go
--PROCEDURE THÊM SỬA XÓA BILLINPUT
--Thêm một BillInput
create or alter procedure proc_addNewBillInput
@idBillInput varchar(8),
@dateOfInput date,
@idEmployee varchar(8)
as
begin
	insert into dbo.BILLINPUT
		(
	idBillInput,
	dateOfInput,
	idEmployee
		)
	values
		(
	@idBillInput,
	@dateOfInput,
	@idEmployee
		)
end
go
--Sửa một BillInput
create or alter procedure proc_updateBillInput
@idBillInput varchar(8),
@dateOfInput date,
@idEmployee varchar(8)
as
begin
	update dbo.BILLINPUT
	set dateOfInput=@dateOfInput,idEmployee=@idEmployee
	where dbo.BILLINPUT.idBillInput=@idBillInput
end
go
--Xóa một BillInput
create or alter procedure proc_deleteBillInput
@idBillInput varchar(8)
as
begin
	delete from dbo.BILLINPUT
	where dbo.BILLINPUT.idBillInput=@idBillInput
end
go
--Xuất hóa đơn BillInput
create or alter procedure proc_invoiceBillInput
@idBillInput varchar(8)
as
begin
	if(dbo.func_checkInvoiceBillIn(@idBillInput)=0)
		raiserror(N'Hóa đơn đã được xuất!',16,1)
	else if(dbo.func_checkInvoiceBillIn(@idBillInput)=-1)
		raiserror(N'Tổng tiền hóa đơn phải lớn hơn 0',16,1)
	else
	begin
			update dbo.BILLINPUT
			set dbo.BILLINPUT.sttus=1
			where dbo.BILLINPUT.idBillInput=@idBillInput
	end
end
go
--PROCEDURE THÊM SỬA XÓA BILLOUTPUT
--Thêm một BillOutput
create or alter procedure proc_addNewBillOutput
@idBillOutput varchar(8),
@dateOfOutput date,
@idCus varchar(8),
@idEmployee varchar(8)
as
begin
	insert into dbo.BILLOUTPUT
		(
	idBillOutPut,
	dateOfBill,
	idCus,
	idEmployee
		)
	values
		(
	@idBillOutput,
	@dateOfOutput,
	@idCus,
	@idEmployee
		)
end
go
--Sửa một BillOutput
create or alter procedure proc_updateBillOutput
@idBillOutput varchar(8),
@dateOfBill date,
@idCus varchar(8),
@idEmployee varchar(8)
as
begin
	update dbo.BILLOUTPUT
	set dateOfBill=@dateOfBill, idCus=@idCus, idEmployee=@idEmployee
	where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
end
go
--Xóa một BillOuput
create or alter procedure proc_deleteBillOutput
@idBillOutput varchar(8)
as
begin
	delete from dbo.BILLOUTPUT
	where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
end
go
--Xuất hóa đơn BillOutput
create or alter procedure proc_invoiceBillOutput
@idBillOutput varchar(8)
as
begin
	if(dbo.func_checkInvoiceBillOut(@idBillOutput)=0)
		raiserror(N'Hóa đơn đã được xuất!',16,1)
	else if(dbo.func_checkInvoiceBillOut(@idBillOutput)=-1)
		raiserror(N'Tổng tiền hóa đơn phải lớn hơn 0',16,1)
	else
	begin
			update dbo.BILLOUTPUT
			set dbo.BILLOUTPUT.sttus=1
			where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
	end
end
go
--PROCEDURE THÊM SỬA XÓA BOOK_BILLINPUT
--Thêm một BOOK_BILLINPUT
create or alter procedure proc_addNewBookBillInput
@idBillInput varchar(8),
@idBook varchar(8),
@amountInput int
as
begin
	insert into dbo.BOOK_BILLINPUT
		(
	idBillInput,
	idBook,
	amountInput
		)
	values
		(
	@idBillInput,
	@idBook,
	@amountInput
		)
end
go
--Sửa một BOOK_BILLINPUT
create or alter procedure proc_updateBookBillInput
@idBillInput varchar(8),
@idBook varchar(8),
@idnewBillInput varchar(8),
@idnewBook varchar(8),
@amount int
as
begin
	if (@idnewBillInput is null and @idnewBook is not null)
	begin
		update dbo.BOOK_BILLINPUT
		set idBook=@idNewBook
		where dbo.BOOK_BILLINPUT.idBook=@idBook and dbo.BOOK_BILLINPUT.idBillInput=@idBillInput
	end
	else if (@idNewBook is null and @idnewBillInput is not null)
	begin
		update dbo.BOOK_BILLINPUT
		set idBillInput=@idnewBillInput
		where dbo.BOOK_BILLINPUT.idBook=@idBook and dbo.BOOK_BILLINPUT.idBillInput=@idBillInput
	end
	else
	begin
		update dbo.BOOK_BILLINPUT
		set idBook=@idnewBook, idBillInput=@idnewBillInput
		where dbo.BOOK_BILLINPUT.idBook=@idBook and dbo.BOOK_BILLINPUT.idBillInput=@idBillInput
	end
end
go
--Xóa một BOOK_BILLINPUT
create or alter procedure proc_deleteBookBillInput
@idBillInput varchar(8),
@idBook varchar(8)
as
begin
	delete from dbo.BOOK_BILLINPUT
	where dbo.BOOK_BILLINPUT.idBillInput=@idBillInput and dbo.BOOK_BILLINPUT.idBook=@idBook
end
go
--PROCEDURE THÊM SỬA XÓA BOOK_BILLOUTPUT
--Thêm một BOOK_BILLOUTPUT
create or alter procedure proc_addNewBookBillOutput
@idBillOutput varchar(8),
@idBook varchar(8)
as
begin
	insert into dbo.BOOK_BILLOUTPUT
		(
	idBillOutput,
	idBook
		)
	values
		(
	@idBillOutput,
	@idBook
		)
end
go
--Sửa một BOOK_BILLOUTPUT
create or alter procedure proc_updateBookBillOutput
@idBillOutput varchar(8),
@idBook varchar(8),
@idnewBillOutput varchar(8),
@idnewBook varchar(8),
@amount int
as
begin
	if (@idnewBillOutput is null and @idnewBook is not null)
	begin
		update dbo.BOOK_BILLOUTPUT
		set idBook=@idNewBook
		where dbo.BOOK_BILLOUTPUT.idBook=@idBook and dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput
	end
	else if (@idNewBook is null and @idnewBillOutput is not null)
	begin
		update dbo.BOOK_BILLOUTPUT
		set idBillOutput=@idnewBillOutput
		where dbo.BOOK_BILLOUTPUT.idBook=@idBook and dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput
	end
	else
	begin
		update dbo.BOOK_BILLOUTPUT
		set idBook=@idnewBook, idBillOutput=@idnewBillOutput
		where dbo.BOOK_BILLOUTPUT.idBook=@idBook and dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput
	end
end
go
--Xóa một BOOK_BILLOUTPUT
create or alter procedure proc_deleteBookBillOutput
@idBillOutput varchar(8),
@idBook varchar(8)
as
begin
	delete from dbo.BOOK_BILLOUTPUT
	where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput and dbo.BOOK_BILLOUTPUT.idBook=@idBook
end
go
