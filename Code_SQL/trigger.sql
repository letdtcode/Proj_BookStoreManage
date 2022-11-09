use BOOKSTOREMANAGE
go
--------------------------------------------TRIGGER-----------------------------------------
--Kiểm tra trả về lỗi nếu ngày xuất hóa đơn trước ngày nhập sách về và kiểm tra số lượng sách trong hóa đơn phải còn trong kho thì mới được bán
create or alter trigger trg_checkDateBillOut
on BOOK_BILLOUTPUT
for insert, update
as
begin	
	declare @dateOutput date, @idBill varchar(8), @dateInput date, @numBookSold int, @idBookSold varchar(8)
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
drop trigger trg_discountAndUpdateVoucher

--Kiểm tra điều kiện tổng tiền được giảm không quá 50% giá trị đơn hàng và voucher phải còn hạn sử dụng thì mới áp dụng được
--create or alter trigger trg_discountAndUpdateVoucher
--on BILLOUTPUT
--for insert, update
--as
--begin
--	declare @idBillDiscount varchar(8), @idVcher varchar(8), @totalAfterDiscount int, @totalBeforeDiscount int, @checkBill bit
--	select @idBillDiscount=i.idBillOutPut, @idVcher=i.idVoucher, @totalBeforeDiscount=dbo.func_totalPayBeforeDiscount(@idBillDiscount)
--	from inserted i
--	Kiểm tra idVoucher có tồn tại 
--	if (@idVcher is not null and not exists(select * from dbo.VOUCHER where @idVcher=dbo.VOUCHER.idVoucher))
--		begin
--			raiserror ('Voucher không tồn tại trong kho',16,1)
--			rollback transaction
--		end

--	Kiểm tra nếu thêm voucher thì có vượt quá 50% giá trị bill 
--	select @totalAfterDiscount=@totalBeforeDiscount-VOUCHER.valueVoucher
--	from dbo.VOUCHER
--	where VOUCHER.idVoucher=@idVcher

--	if (@totalAfterDiscount <= (0.5*@totalBeforeDiscount))
--		begin
--			raiserror ('Voucher không thể áp dụng do vượt quá 50% giá trị hóa đơn',16,1)
--			rollback transaction
--		end
--	Kiểm tra Voucher có còn hạn sử dụng 
--	select @checkBill=dbo.func_checkVoucherValidOrNot(VOUCHER.dateStart,VOUCHER.dateEnd,BILLOUTPUT.dateOfBill)
--	from dbo.BILLOUTPUT, dbo.VOUCHER
--	where BILLOUTPUT.idBillOutPut=@idBillDiscount and VOUCHER.idVoucher=@idVcher
--	if (@checkBill=0)
--		begin
--			raiserror ('Voucher đã hết hạn sử dụng',16,1)
--			rollback transaction
--		end
--end
--go
--Kiểm tra số điện thoại tác giả 
go
create or alter trigger trg_checkPhoneNumberOfAuthor
on AUTHOR
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i

	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
			rollback transaction
		end

end
go
--Kiểm tra số điện thoại của nhà xuất bản
create or alter trigger trg_checkPhoneNumberOfPublisher
on PUBLISHER
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i

	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
			rollback transaction
		end
end
go
--Kiểm tra số điện thoại của khách hàng
create or alter trigger trg_checkPhoneNumberOfCustomer
on CUSTOMER
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i

	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
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

