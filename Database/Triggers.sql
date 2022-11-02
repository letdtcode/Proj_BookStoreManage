use BOOKSTOREMANAGE
go


--------------------------------------------TRIGGER-----------------------------------------
--Kiểm tra trả về lỗi nếu ngày xuất hóa đơn trước ngày nhập sách về và kiểm tra số lượng sách trong hóa đơn phải còn trong kho thì mới được bán
create or alter trigger trg_checkDateBillOut on BOOK_BILLOUTPUT
for insert, update
as
begin	
	declare @dateOutput date, @idBill int, @dateInput date, @numBookSold int, @idBookSold int
	select @dateOutput=(select BILLOUTPUT.dateOfBill from dbo.BILLOUTPUT where BILLOUTPUT.idBillOutPut=i.idBillOutput),
	@idBill=i.idBillOutput,
	@numBookSold=i.amountOutput,
	@idBookSold=i.idBook
	from inserted i

	select @dateInput=BILLINPUT.dateOfInput
	from dbo.BOOK_BILLOUTPUT,dbo.BOOK_BILLINPUT,dbo.BILLINPUT
	where @idBill=BOOK_BILLOUTPUT.idBillOutput and BOOK_BILLOUTPUT.idBook=BOOK_BILLINPUT.idBook and BOOK_BILLINPUT.idBillInput=BILLINPUT.idBillInput

	if(@dateOutput<@dateInput)
		begin
			print(N'Thời gian không hợp lệ')
			rollback transaction
		end
	if (@numBookSold >= (select BOOK.amount from dbo.BOOK where @idBookSold=BOOK.idBook))
	begin
		print (N'Số lượng sách trong kho không đáp ứng đủ !')
		rollback transaction
	end
end
go

------------------------------------- Kiểm tra voucher còn hạn sử dụng hay không-----------------------------------
create or alter trigger trg_ExpiryUseVoucher
on BILLOUTPUT 
for insert, update
as
begin
	declare @checkBill bit, @idBillOutput int, @idVoucher int
	select @idBillOutput = i.idBillOutPut, @idVoucher = i.idVoucher from inserted i


	select @checkBill = dbo.func_checkVoucherValidOrNot (VOUCHER.dateStart,VOUCHER.dateEnd,BILLOUTPUT.dateOfBill)
	from dbo.BILLOUTPUT, dbo.VOUCHER
	where BILLOUTPUT.idBillOutPut= @idBillOutput and VOUCHER.idVoucher= @idVoucher
	if (@checkBill=0)
		begin
			print (N'Voucher đã hết hạn sử dụng')
			rollback transaction
		end
end
go

--select dbo.func_checkVoucherValidOrNot('2022-1-1', '2022-10-10', '2022-10-9')
 

---- Kiểm tra nếu số sách trong kho = 0 mới cho phép xóa
--Create or alter trigger CheckAmountBook on BOOK
--for delete
--as
--begin
--	declare @amountBook int, @idBook int
--	set @idBook = (select i.idbook from deleted i)

--	set @amountBook = (select amount from BOOK where idBook = @idBook)
--	if @amountBook > 0
--	print @amountBook
--	begin
--		print N'Sách này vẫn còn trong kho, không thể xóa'
--		rollback transaction
--	end
--end


------------------------------------- Kiểm tra số điện thoại của khách = 9 con số != 0 và phải có ký tự đầu tiên = 0 thì hợp lệ---------------------
Create or alter trigger checkPhoneNumberOfCustomer 
on CUSTOMER
for insert, update
as begin
	declare @phoneNumber varchar(20)

	set @phoneNumber = (select i.phoneNumber from inserted i)

	if (@phoneNumber not like '%[^0-9]%' and 
		LEN(@phoneNumber) = 10 and
		LEFT(@phoneNumber, 1) = 0
	)
	begin
		print N'Đã thêm thành cônng'
	end
	else
	begin
		print N'Số điện thoại nhập không đúng định dạng'
		rollback transaction
	end
end
go
--insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus)
--values ('New CUS', 'GL', '0123467899', 12)

--select * from CUSTOMER

----------------------- Khách hàng không có đơn hàng nào mới được xóa (Không cần thiết, vì khi có đơn hàng sẽ bị ràng buộc khóa ngoại)
Create or alter trigger DeleCus on CUSTOMER for delete
as
begin
		declare @idCus int, @idBill int
		set @idCus = (select d.idCus from deleted d)
		set @idBill = (select idBillOutPut from BILLOUTPUT where idCus = @idCus)

		if( @idBill is null)
		begin
			print N'Đã xóa thành công'
		end
		else
		begin
			print N'Khách hàng không thể xóa'
			rollback transaction
		end
end
go
--select * from CUSTOMER

--delete CUSTOMER where idCus = 10

-------------------------------------------------------Kiểm tra số sách thêm vào giỏ hàng phải nhỏ hơn hoặc bằng sách trong kho-------------
Create or alter trigger trg_checkAmountBook on BOOK_BILLOUTPUT
for insert, update
as
begin
	

end
go

--------------------------------Voucher--------------------------
--kiểm tra value phải nhỏ hơn hoặc = 100 và  lớn hơn 0
Create or alter trigger trg_checkValueVoucher on VOUCHER
for insert, update
as
begin
	declare @value int
	select @value = i.valueVoucher from inserted i

	if (@value <= 0 or @value >100)
	begin
		print N'Nhập giá trị value không chính xác. Value nằm trong khoảng từ 0 -> 100'
		rollback transaction
	end
end
go
-- Kiểm tra dateStart phải < dateEnd
Create or alter trigger trg_checkDateVoucher on Voucher
for insert, update
as
begin
	declare @dateStart date, @dateEnd date
	select @dateStart = i.dateStart, @dateEnd = i.dateEnd
	from inserted i

	if (@dateStart > @dateEnd)
	begin
		print N'Ngày bắt đầu và kết thúc không hợp lệ'
		rollback transaction
	end

end
go


--Điều kiện giá bán phải lớn hơn giá nhập
create or alter trigger trg_checkPriceOfBook
on BOOK
for insert, update
as
begin
	declare @priceImport int, @priceExport int
	select @priceImport=i.priceImport, @priceExport=i.priceExport
	from inserted i

	if (@priceImport > @priceExport)
	begin
		raiserror ('Giá nhập sách phải nhỏ hơn giá bán',16,1)
		rollback transaction
	end
end
go
