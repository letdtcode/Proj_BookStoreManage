use BOOKSTOREMANAGE
go
-----------------------------PROCEDURE-------------------------
--PROCEDURE THÊM, SỬA, XÓA ACCOUNT
--Thêm một account mới
create or alter procedure proc_addNewAccount (@idAccount varchar(8) , @nameAccount varchar(20), @password varchar(30), @typeOfAcc bit, @idEmployee varchar(8))
as
begin
	begin transaction addNewAcc
	begin try
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
	--tạo quyền cho user vừa thêm
	exec proc_createUser @nameAccount, @password
	commit transaction addNewAcc
	end try
	begin catch
		print (error_message())
		rollback transaction addNewAcc
	end catch
end
go
--Chỉnh sửa một Account
create or alter procedure proc_updateAccount
@idAccount varchar(8) ,
@nameAccount varchar(20),
@password varchar(30)
as
begin
	begin transaction updateAcc
	begin try
		exec proc_updateUser @nameAccount, @password
		--Chỉ thay đổi mật khẩu
		update dbo.ACCOUNT
		set ACCOUNT.password=@password
		where ACCOUNT.idAccount=@idAccount
		commit transaction udpateAcc
	end try
	begin catch
		print (error_message())
		rollback transaction updateAcc
	end catch
end
go

--Xóa một Account
create or alter procedure proc_DeleteAccount (@idAccount varchar(8) )
as
begin
	declare @username nvarchar (20)
	set @username = (select ACCOUNT.nameAccount from ACCOUNT where idAccount = @idAccount)
	begin transaction deleteAcc
	begin try
		-- Xóa user khỏi hệ thống
		delete dbo.ACCOUNT
		where dbo.ACCOUNT.idAccount=@idAccount

		exec proc_deleteUser @username

		commit transaction deleteAcc
	end try
	begin catch
		print error_message()
		rollback transaction deleteAcc
	end catch
end
go
--PROCEDURE THÊM, SỬA, XÓA AUTHOR
--Thêm một Author
create or alter procedure proc_addNewAuthor
@idAuthor varchar(8) ,
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
@idAuthor varchar(8) ,
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
@idBook varchar(8) ,
@nameBook nvarchar(20),
@urlImage image,
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
	priceImport,
	priceExport,
	idPublisher
		)
	values
		(
	@idBook,
	@nameBook,
	@urlImage,
	@priceImport,
	@priceExport,
	@idPublisher
		)
end
go
--Chỉnh sửa một Book
create or alter procedure proc_updateBook
@idBook varchar(8) ,
@nameBook nvarchar(20),
@urlImage image,
@priceImport int,
@priceExport int,
@idPublisher varchar(8) 
as
begin
	update dbo.BOOK
	set BOOK.nameBook=@nameBook, BOOK.urlImage=@urlImage, BOOK.priceImport=@priceImport, BOOK.priceExport=@priceExport, BOOK.idPublisher=@idPublisher
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
@idBook varchar(8) ,
@nameAuthor nvarchar(30)
as
begin
	declare @idAuthor varchar(8) 
	select @idAuthor=dbo.func_getIDAuthor(@nameAuthor)
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
@idBook varchar(8) ,
@nameAuthor nvarchar(30),
@nameNewAuthor nvarchar(30) 
as
begin
	declare @idAuthor varchar(8) , @idNewAuthor varchar(8) 
	select @idAuthor=dbo.func_getIDAuthor(@nameAuthor), @idNewAuthor=dbo.func_getIDAuthor(@nameNewAuthor)

	update dbo.BOOK_AUTHOR
	set idAuthor=@idNewAuthor
	where dbo.BOOK_AUTHOR.idAuthor=@idAuthor and dbo.BOOK_AUTHOR.idBook=@idBook
end
go
--Xóa bộ sách-tác giả
create or alter procedure proc_deleteBookAuthor
@idBook varchar(8) ,
@nameAuthor nvarchar(30)
as
begin
	declare @idAuthor varchar(8) 
	select @idAuthor=dbo.func_getIDAuthor(@nameAuthor)

	delete from dbo.BOOK_AUTHOR
	where dbo.BOOK_AUTHOR.idBook=@idBook and dbo.BOOK_AUTHOR.idAuthor=@idAuthor
end
go
--PROCEDURE THÊM, SỬA, XÓA BOOK_CATEGORY
--Thêm thể loại cho sách
create or alter procedure proc_addNewBookCategory
@idBook varchar(8) ,
@nameCategory nvarchar(20)
as
begin
	declare @idCategory varchar(8) 
	select @idCategory=dbo.func_getIDCategory(@nameCategory)

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
@idBook varchar(8) ,
@nameCategory nvarchar(20), 
@nameNewCategory nvarchar(20)
as
begin
	declare @idCategory varchar(8) , @idNewCategory varchar(8) 
	select @idCategory=dbo.func_getIDCategory(@nameCategory), @idNewCategory=dbo.func_getIDCategory(@nameNewCategory)

	update dbo.BOOK_CATEGORY
	set idCategory=@idNewCategory
	where dbo.BOOK_CATEGORY.idCategory=@idCategory and dbo.BOOK_CATEGORY.idBook=@idBook
end
go
--Xóa bộ sách-thể loại
create or alter procedure proc_deleteBookCategory
@idBook varchar(8) ,
@nameCategory nvarchar(20)
as
begin
	declare @idCategory varchar(8) 
	select @idCategory=dbo.func_getIDCategory(@nameCategory)

	delete from dbo.BOOK_CATEGORY
	where dbo.BOOK_CATEGORY.idBook=@idBook and dbo.BOOK_CATEGORY.idCategory=@idCategory
end
go
--PROCEDURE THÊM, SỬA, XÓA CATEGORY
--Thêm một thể loại mới 
create or alter procedure proc_addNewCategory
@idCategory varchar(8) ,
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
@idCategory varchar(8) ,
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
@idCustomer varchar(8) ,
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
@idCus varchar(8) ,
@nameCus nvarchar(30),
@addressCus nvarchar(30),
@phoneNumber varchar(20)
as
begin
	update dbo.CUSTOMER
	set nameCus=@nameCus, addressCus=@addressCus, phoneNumber=@phoneNumber
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
@idEmployee varchar(8) ,
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
@idEmployee varchar(8) ,
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
@idPublisher varchar(8) ,
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
@idPublisher varchar(8) ,
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
@idTypeCustomer varchar(8) ,
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
@idTypeCus varchar(8) ,
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
@idVoucher varchar(8) ,
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
@idBillInput varchar(8) 
as
begin
	insert into dbo.BILLINPUT
		(
	idBillInput
		)
	values
		(
	@idBillInput
		)
end
go
--PROCEDURE THÊM SỬA XÓA BOOK_BILLINPUT
--Thêm một item vào đơn hàng nhập
create or alter procedure proc_addNewBookBillInput
@idBillInput varchar(8),
@idBook varchar(8),
@amountInput int
as
begin
	begin transaction
	begin try
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
		--Cập nhật lại số lượng sách trong cửa hàng
		update dbo.BOOK
		set dbo.BOOK.amount=dbo.BOOK.amount+@amountInput
		where dbo.BOOK.idBook=@idBook

		--Cập nhật tổng tiền hóa đơn
		declare @totalBill int  
		select @totalBill=dbo.func_returnToTalOfBillInput(@idBillInput)

		update dbo.BILLINPUT
		set dbo.BILLINPUT.total=@totalBill
		where dbo.BILLINPUT.idBillInput=@idBillInput
	commit transaction
	end try
	begin catch
		raiserror('Sách đã có trong đơn hàng. Vui lòng thay đổi số lượng trong đơn',16,1)
		rollback transaction
	end catch
end
go
--Sửa số lượng item trong hóa đơn
create or alter procedure proc_updateBookBillInput
@idBillImport varchar(8),
@idBook varchar(8),
@amountBook int,
@amountNewBook int
as
begin
	begin transaction
		begin try
			--Cập nhật lại thông tin trong giỏ hàng
			update dbo.BOOK_BILLINPUT
			set amountInput=@amountNewBook
			where dbo.BOOK_BILLINPUT.idBook=@idBook and dbo.BOOK_BILLINPUT.idBillInput=@idBillImport

			--Cập nhật lại số lượng sách trong kho
			update dbo.BOOK
			set dbo.BOOK.amount=dbo.BOOK.amount-@amountBook+@amountNewBook
			where dbo.BOOK.idBook=@idBook

			commit transaction
		end try
	begin catch
		raiserror('Đã có lỗi xảy ra. Vui lòng thử lại',16,1)
		rollback transaction
	end catch
end
go
--Xóa một item trong hóa đơn
create or alter procedure proc_deleteBookBillInput
@idBillInput varchar(8) ,
@idBook varchar(8) 
as
begin
	--Lấy ra số lượng sách có trong hóa đơn
	declare @amountBook int

	select @amountBook=dbo.BOOK_BILLINPUT.amountInput
	from dbo.BOOK_BILLINPUT
	where dbo.BOOK_BILLINPUT.idBook=@idBook and dbo.BOOK_BILLINPUT.idBillInput=@idBillInput
	--Xóa sách đó trong hóa đơn
	delete from dbo.BOOK_BILLINPUT
	where dbo.BOOK_BILLINPUT.idBillInput=@idBillInput and dbo.BOOK_BILLINPUT.idBook=@idBook
	--Cập nhật lại số lượng trong kho
	update dbo.BOOK
	set dbo.BOOK.amount=dbo.BOOK.amount-@amountBook
	where dbo.BOOK.idBook=@idBook
end
go
--Xác nhận xuất hóa đơn nhập
create or alter procedure proc_confirmBillImport
@idBillInput varchar(8) ,
@dateTimeOfBill date,
@idEmp varchar(8) 
as
begin
	declare @totalOfBill int

	select @totalOfBill=dbo.BILLINPUT.total
	from dbo.BILLINPUT
	where dbo.BILLINPUT.idBillInput=@idBillInput

	if(@totalOfBill<=0)
	begin
			delete from dbo.BILLINPUT
			where dbo.BILLINPUT.idBillInput=@idBillInput
			return;
	end

	update dbo.BILLINPUT
	set dateOfInput=@dateTimeOfBill, idEmployee=@idEmp
	where dbo.BILLINPUT.idBillInput=@idBillInput
end
go

--Xác nhận hủy một hóa đơn đang thêm
create or alter procedure proc_cancelBillImport
@idBill varchar(8) 
as 
begin
	--Duyệt qua từng idBook trong hóa đơn
	declare @idBook varchar(8) 
	declare item cursor for (select dbo.BOOK_BILLINPUT.idBook from dbo.BOOK_BILLINPUT where dbo.BOOK_BILLINPUT.idBillInput=@idBill)
	open item
	fetch next from item into @idBook
	while @@FETCH_STATUS=0
	begin
		execute proc_deleteBookBillInput @idBill, @idBook
		fetch next from item into @idBook
	end
	close item
	deallocate item

	--Xóa hóa đơn đó
	delete from dbo.BILLINPUT
	where dbo.BILLINPUT.idBillInput=@idBill
end
go

--PROCEDURE THÊM SỬA XÓA BILLOUTPUT
--Thêm một BillOutput
create or alter procedure proc_addNewBillOutput
@idBillOutput varchar(8) 
as
begin
	insert into dbo.BILLOUTPUT
		(
	idBillOutPut
		)
	values
		(
	@idBillOutput
		)
end
go

--PROCEDURE THÊM SỬA XÓA BOOK_BILLOUTPUT
--Thêm sản phẩm vào hóa đơn xuất
create or alter procedure proc_addNewBookBillOutput
@idBillOutput varchar(8) ,
@idBook varchar(8) ,
@amount int
as
begin
		begin transaction
		begin try
		--Thêm item vào bảng (amount đảm bảo thỏa ràng buộc do đã có trigger)
		if(exists(select * from dbo.BOOK_BILLOUTPUT 
						where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput and dbo.BOOK_BILLOUTPUT.idBook=@idBook))
				begin
					update dbo.BOOK_BILLOUTPUT
					set amountOutput=amountOutput+@amount
					where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput and dbo.BOOK_BILLOUTPUT.idBook=@idBook
				end
		else
			begin
				insert into dbo.BOOK_BILLOUTPUT
				(
				idBillOutput,
				idBook,
				amountOutput
				)
				values
				(
				@idBillOutput,
				@idBook,
				@amount
				)
			end
		--Cập nhật lại số lượng sách trong giỏ hảng
		update dbo.BOOK
		set dbo.BOOK.amount=dbo.BOOK.amount-@amount
		where dbo.BOOK.idBook=@idBook

		--Cập nhật tổng tiền hóa đơn
		declare @totalBill int 
		select @totalBill=dbo.func_returnToTalOfBillOutput(@idBillOutput)

		update dbo.BILLOUTPUT
		set dbo.BILLOUTPUT.total=@totalBill
		where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
		commit transaction
		end try
		begin catch
		rollback transaction
		end catch
end
go
--Cập nhật lại loại khách hàng sau mỗi đơn hàng
create or alter procedure proc_updateTypeCusForCus
@amountBooksBought int,
@idCus varchar(8) 
as
begin
	begin transaction
	begin try
		declare @idTypeCus varchar(8) , @pointMark int, @maxPointValue int
		set @maxPointValue=0
		declare point cursor for select dbo.TYPECUSTOMER.pointMark from dbo.TYPECUSTOMER order by pointMark ASC
		open point
		fetch next from point into @pointMark
		while @@FETCH_STATUS=0
		begin
			if(@amountBooksBought>=@pointMark)
				set @maxPointValue=@pointMark
			else
				break
			fetch next from point into @pointMark
		end
		close point
		deallocate point

		select @idTypeCus=(select dbo.TYPECUSTOMER.idTypeCus from dbo.TYPECUSTOMER where dbo.TYPECUSTOMER.pointMark=@maxPointValue)
		--Update lại IDtypecus cho khách hàng
		update dbo.CUSTOMER
		set idTypeCus=@idTypeCus, pointCus=@amountBooksBought
		where dbo.CUSTOMER.idCus=@idCus
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
end
go

--Xác nhận xuất hóa đơn
create or alter procedure proc_confirmBillExport
@idBillOutput varchar(8),
@dateTimeOfBill date,
@idCus varchar(8) ,
@idEmp varchar(8) ,
@idVoucher varchar(8) = null
as
begin
	declare @totalOfBill int , @discountOfVoucher int, @discountOfTypeCus int

	begin transaction
	begin try
		--Lấy ra giá trị hóa đơn và giá trị chiết khấu
		select @totalOfBill=dbo.BILLOUTPUT.total
		from dbo.BILLOUTPUT
		where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput 

		--Lấy giá trị chiết khấu của loại khách hàng
		set @discountOfTypeCus=dbo.func_getValueDiscountOfTypeCustomer(@idCus)

		--Tính giá trị chiết khấu voucher nếu có
		if(@idVoucher is not null)
		begin
			select @discountOfVoucher=dbo.VOUCHER.valueVoucher
			from dbo.VOUCHER
			where dbo.VOUCHER.idVoucher=@idVoucher
		end
		else
			set @discountOfVoucher=0
		--Tính tiền giá trị hóa đơn hiện tại
		set @totalOfBill=@totalOfBill-((@discountOfTypeCus*@totalOfBill)/100)
		set @totalOfBill=@totalOfBill-@discountOfVoucher

		--Nếu tiền hóa đơn bé hơn hoặc bằng 0 thì hủy bỏ hóa đơn đó
		if(@totalOfBill<=0)
		begin
				raiserror('Hóa đơn không hợp lệ',16,1)
				delete from dbo.BILLOUTPUT
				where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
				return;
		end

		--Cập nhật hóa đơn vào bảng
		update dbo.BILLOUTPUT
		set dateOfBill=@dateTimeOfBill, idCus=@idCus, idEmployee=@idEmp, idVoucher=@idVoucher, total=@totalOfBill
		where dbo.BILLOUTPUT.idBillOutPut=@idBillOutput
	
		--Cập lại điểm tích lũy và Type cho khách hàng
		declare @amountBookInBill int, @amountBookTotal int
		select @amountBookInBill=(select sum(amountOutput) from dbo.BOOK_BILLOUTPUT where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput)
		select @amountBookTotal=@amountBookInBill+(select dbo.CUSTOMER.pointCus from dbo.CUSTOMER where dbo.CUSTOMER.idCus=@idCus)
		exec proc_updateTypeCusForCus @amountBooksBought=@amountBookTotal, @idCus=@idCus
		--Cập nhật trạng thái của đơn hàng
		update dbo.BILLOUTPUT
		set stateBill = 1
		where dbo.BILLOUTPUT.idBillOutPut = @idBillOutput
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
end
go
--Xóa một item trong hóa đơn
create or alter procedure proc_deleteBookBillOutput
@idBillOutput varchar(8) ,
@idBook varchar(8) 
as
begin
	--Lấy ra số lượng sách có trong hóa đơn
	declare @amountBook int

	select @amountBook=dbo.BOOK_BILLOUTPUT.amountOutput
	from dbo.BOOK_BILLOUTPUT
	where dbo.BOOK_BILLOUTPUT.idBook=@idBook and dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput
	--Xóa sách đó trong hóa đơn
	delete from dbo.BOOK_BILLOUTPUT
	where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput and dbo.BOOK_BILLOUTPUT.idBook=@idBook
	--Cập nhật lại số lượng trong kho
	update dbo.BOOK
	set dbo.BOOK.amount=dbo.BOOK.amount+@amountBook
	where dbo.BOOK.idBook=@idBook
end
go

--Xác nhận hủy một hóa đơn đang thêm
create or alter procedure proc_cancelBillExport
@idBill varchar(8) 
as 
begin
	begin transaction
	begin try
		--Duyệt qua từng idBook trong hóa đơn
		declare @idBook varchar(8) 
		declare item cursor for (
			select dbo.BOOK_BILLOUTPUT.idBook 
			from dbo.BOOK_BILLOUTPUT 
			where dbo.BOOK_BILLOUTPUT.idBillOutput=@idBill)
		open item
		fetch next from item into @idBook
		while @@FETCH_STATUS=0
		begin
			execute proc_deleteBookBillOutput @idBill, @idBook
			fetch next from item into @idBook
		end
		close item
		deallocate item

		--Xóa hóa đơn đó
		delete from dbo.BILLOUTPUT
		where dbo.BILLOUTPUT.idBillOutPut=@idBill
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
end
go


--Xóa bỏ đơn hàng khi trạng thái đơn hàng false
create or alter procedure proc_deleteBillOutput 
as
begin
	begin transaction
	begin try
		declare @idBillOutput varchar(8)
		set @idBillOutput = (select dbo.func_returnIdBillFalse())
	
		print (@idBillOutput)
		exec proc_cancelBillExport @idBillOutput
		commit transaction
	end try
	begin catch 
		rollback transaction
	end catch
end
go

--Sửa số lượng item trong hóa đơn
create or alter procedure proc_updateBookBillOutput
@idBillOutput varchar(8),
@idBook varchar(8),
@amountBook int,
@amountNewBook int
as
begin
	begin transaction
		begin try
			--Cập nhật lại thông tin trong giỏ hàng
			update dbo.BOOK_BILLOUTPUT
			set amountOutput=@amountNewBook
			where dbo.BOOK_BILLOUTPUT.idBook=@idBook and dbo.BOOK_BILLOUTPUT.idBillOutput=@idBillOutput

			--Cập nhật lại số lượng sách trong kho
			update dbo.BOOK
			set dbo.BOOK.amount=dbo.BOOK.amount+@amountBook-@amountNewBook
			where dbo.BOOK.idBook=@idBook

			commit transaction
		end try
	begin catch
		raiserror('Đã có lỗi xảy ra. Vui lòng thử lại',16,1)
		rollback transaction
	end catch
end
go


---Procedure show doanh thu trong khoảng begin end---
create or alter proc sp_ShowRevenue
@begin date , @end date
as
begin
	select convert(date,dateOfBill) as dateOfBill, sum(total) as total
	from BILLOUTPUT where dateOfBill between @begin and @end
	group by convert(date,dateOfBill)
end
go
----Procedure show top 5 sản phẩm bán chạy nhất trong khoảng begin end-----
create or alter proc sp_ShowTop5Book
@begin date , @end date
as
begin
	select top 5 BOOK.nameBook, sum(BOOK_BILLOUTPUT.amountOutput) as amountOutput
	from BOOK_BILLOUTPUT, BOOK, BILLOUTPUT
	where BOOK_BILLOUTPUT.idBook= BOOK.idBook
		and BILLOUTPUT.idBillOutPut= BOOK_BILLOUTPUT.idBillOutput
		and dateOfBill between @begin and @end
	group by BOOK.nameBook 
	order by amountOutput desc
end
go
-------Tổng quan về tổng doanh thu trong khoảng thời gian--------
create or alter proc sp_Overview_Revenue
@begin date, @end date
as
begin
	select sum(total) 
	from BILLOUTPUT 
	where dateOfBill between @begin and @end
end
go
------Tổng quan về số hóa đơn trong khoảng thời gian----------
create or alter proc sp_Overview_AmountBillOutput
@begin date, @end date
as
begin
	select count(*) 
	from BILLOUTPUT 
	where dateOfBill between @begin and @end
end
go
-----Tổng quan về số sách bán được trong khoảng thời gian--------
create or alter proc sp_Overview_AmountBookBillOutput
@begin date, @end date
as
begin
	select sum(amountOutput) 
	from BOOK_BILLOUTPUT, BILLOUTPUT,BOOK
	where BOOK_BILLOUTPUT.idBook= BOOK.idBook
	and BILLOUTPUT.idBillOutPut= BOOK_BILLOUTPUT.idBillOutput
	and dateOfBill between @begin and @end
end
