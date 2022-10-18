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

--Kiểm tra điều kiện tổng tiền được giảm không quá 50% giá trị đơn hàng và voucher phải còn hạn sử dụng thì mới áp dụng được
create or alter trigger trg_discountAndUpdateVoucher
on DISCOUNT
for insert, update
as
begin
	declare @idBillDiscount int, @idVcher int, @totalCurrent int, @totalAfterDiscount int, @totalStart int, @checkBill bit
	select @idBillDiscount=i.idBill, @idVcher=i.idVoucher, @totalCurrent=dbo.totalPayCurrent(@idBillDiscount), @totalStart=dbo.totalPayBeforeDiscount(@idBillDiscount)
	from inserted i
	--Kiểm tra idVoucher có tồn tại 
	if (not exists(select * from VOUCHER where @idVcher=VOUCHER.idVoucher))
		begin
			print (N'Voucher không tồn tại trong kho')
			rollback transaction
		end
	--Kiểm tra nếu thêm voucher thì có vượt quá 50% giá trị bill 
	select @totalAfterDiscount=@totalCurrent-VOUCHER.valueVoucher
	from dbo.VOUCHER
	where VOUCHER.idVoucher=@idVcher

	if (@totalAfterDiscount < (0.5*@totalStart))
		begin
			print (N'Voucher không thể áp dụng do vượt quá 50% giá trị hóa đơn')
			rollback transaction
		end
	--Kiểm tra Voucher có còn hạn sử dụng 
	select @checkBill=dbo.checkVoucherValidOrNot(VOUCHER.dateStart,VOUCHER.dateEnd,BILLOUTPUT.dateOfBill)
	from dbo.BILLOUTPUT, dbo.VOUCHER
	where BILLOUTPUT.idBillOutPut=@idBillDiscount and VOUCHER.idVoucher=@idVcher
	if (@checkBill=0)
		begin
			print (N'Voucher đã hết hạn sử dụng')
			rollback transaction
		end
end
go


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

-- Kiểm tra số điện thoại của khách = 9 con số != 0 và phải có ký tự đầu tiên = 0 thì hợp lệ

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

-- Khách hàng không có đơn hàng nào mới được xóa (Không cần thiết, vì khi có đơn hàng sẽ bị ràng buộc khóa ngoại)
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

--select * from CUSTOMER

--delete CUSTOMER where idCus = 10