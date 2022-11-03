use BOOKSTOREMANAGE
go

-----------------------------------------Function phụ trợ--------------------------------------------------
------------------------------------------------------------Hàm tính tổng tiền hóa đơn khi chưa áp dụng bất cứ voucher nào----------------
create or alter function func_totalPayBeforeDiscount(@idBill int)
returns int
as
begin
	declare @totalPrice int
	set @totalPrice= (
	select sum(priceExport*amountOutput)
	from dbo.BOOK,dbo.BOOK_BILLOUTPUT
	where BOOK.idBook=BOOK_BILLOUTPUT.idBook and @idBill=BOOK_BILLOUTPUT.idBillOutput)

	if (@totalPrice is null)
	begin
		set @totalPrice = 0
	end
	return @totalPrice
end
go

------------------------------------------------------------ Tính số tiền được giảm giá----------------------------------------------------------
create or alter function fuc_discount(@idbill int)
returns float
as
begin
	declare @discountVoucher float, @discountCustomer float, @discount float
	set @discountVoucher = (select valueVoucher from VOUCHER, BILLOUTPUT where idBillOutPut = @idbill and VOUCHER.idVoucher = BILLOUTPUT.idVoucher)
	set @discountCustomer = (select valueTypeCus from BILLOUTPUT, CUSTOMER, TYPECUSTOMER where idBillOutPut= @idbill and BILLOUTPUT.idCus = CUSTOMER.idCus and 
	CUSTOMER.idTypeCus = TYPECUSTOMER.idTypeCus)
	if (@discountCustomer is null)
	begin
		set @discountCustomer = 0
	end

	set @discount = @discountCustomer + @discountVoucher


	set @discount = (@discount/100)*  dbo.func_totalPayBeforeDiscount(@idbill)
	return @discount
end
go
--select dbo.fuc_discount(1002)


--select * from BILLOUTPUT
--select * from TYPECUSTOMER

------------------------------------------------------------Hàm tính tổng tiền hóa đơn hiện tại------------------------------------
create or alter function func_totalPayCurrent(@idBill int)
returns int
as 
begin
	declare @totalPrice int, @discount float
	set @discount = (
		select valueVoucher from Voucher, BILLOUTPUT 
		where idBillOutPut = @idBill and 
			VOUCHER.idVoucher = BILLOUTPUT.idVoucher
	)
	if (@discount is NULL)
	begin
		set @discount = 0
	end
	set @totalPrice=dbo.func_totalPayBeforeDiscount(@idBill) - (Convert(float,@discount)/100)*dbo.func_totalPayBeforeDiscount(@idBill)
	return @totalPrice
end
go

--select dbo.func_totalPayCurrent(1)

--------------------------------------------Hàm kiểm tra voucher còn trong thời gian sử dụng hay không------------------------------------------------------
create or alter function func_checkVoucherValidOrNot(@dateStart date,@dateEnd date,@dateCurrent date)
returns bit
as
begin
	declare @dayOfVoucher int, @dayCurrentSinceVoucher int
	set @dayOfVoucher = DATEDIFF(day, @dateEnd,@dateStart)
	set @dayCurrentSinceVoucher = DATEDIFF(day, @dateCurrent, @dateStart)
	if (@dayCurrentSinceVoucher < @dayOfVoucher)
		return 0
	return 1
end
go


------------------------------------------------------------ Tính thổng doanh thu trong 1 tháng -------------------------------------------------
create or alter function revenueInMonth (@month int, @year int)
returns float
as
begin
	declare @revenue float
	set @revenue = (select sum(total) from BILLOUTPUT where MONTH(dateOfBill) = @month and YEAR(dateOfBill) = @year)
	return @revenue
end
go

------------------------------------------------------------ Tính tổng doanh thu theo tháng-----------------------------------------------
create or alter function revenueInMonths (@startMonth int, @endMoth int, @year int)
returns @tableRevenueInMonths table (monthIndex int, revenue float) 
as
begin
	declare @revenueInMonth float
	while @startMonth <= @endMoth
	begin
		set @revenueInMonth = (select dbo.revenueInMonth(@startMonth, @year))
		insert into @tableRevenueInMonths select @startMonth, @revenueInMonth
		set @startMonth += 1
	end
	return 
end
go


------------------------------------------------------------ Hàm tính doanh thu trong năm---------------------------------------------
create or alter function revenueInYear (@year int)
returns float
as
begin
	declare @revenue float
	set @revenue = (select sum(total) from BILLOUTPUT where YEAR(dateOfBill) = @year)
	return @revenue
end
go

------------------------------------------------------------ Hàm tính doanh thu theo năm--------------------------------------------

create or alter function revenueInYears (@startYear int, @endYear int)
returns @tableRevenueInYears table (yearIndex int, revenue float) 
as
begin
	declare @revenueInYear float
	while @startYear <= @endYear
	begin
		set @revenueInYear = (select dbo.revenueInYear(@startYear))
		insert into @tableRevenueInYears select @startYear, @revenueInYear
		set @startYear += 1
	end
	return 
end
go


-- -------------------------------------------------Kiểm tra số sách trong kho----------------------------------------------------------
create or alter function returnAmountBook (@idBook int)
returns int
as
begin
	declare @amount int
	set @amount = (select amount from BOOK where idBook = @idBook)
	return @amount
end
go


-----------------------------------------------Tính điểm của khách qua tổng tiền trong hóa đơn---------------------------------------------
Create or alter function CalcScore (@price int)
returns int
as
begin
	declare @score int

	if (@price<=0)
	begin 
		set @score = 0
	end
	if (@price > 0 and @price <= 100000)
	begin
		set @score = 5
	end

	else if (@price > 100000 and @price <= 1000000)
	begin
		set @score = 10
	end

	else if (@price > 1000000 and @price <= 2000000)
	begin
		set @score = 30
	end

	else if (@price >= 2000000)
	begin
		set @score = 100
	end

	return @score
end
go
--function tìm kiếm gần đúng
CREATE FUNCTION [dbo].[fuConvertToUnsign1]
( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS 
BEGIN
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136)
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN
		SET @COUNTER1 = 1
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
		BEGIN
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
				ELSE
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK
			END 
			SET @COUNTER1 = @COUNTER1 +1 
		END SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-')
	RETURN @strInput
END

-------------------------Trả về tổng số tiền khi nhập sách----------------------------
create or alter function returnPriceInput (@idBill int)
returns int
as
begin
	declare @priceInput int
	set @priceInput = (select SUM(BOOK_BILLINPUT.amountInput* BOOK.priceImport) from BOOK_BILLINPUT, BOOK 
						where idBillInput = @idBill and
								BOOK_BILLINPUT.idBook = BOOK.idBook)


	return @priceInput
end
go