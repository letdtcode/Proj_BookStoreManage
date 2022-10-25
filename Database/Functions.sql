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

---------------------------Hàm kiểm tra voucher còn trong thời gian sử dụng hay không------------------------------------------------------
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








