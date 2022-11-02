use BOOKSTOREMANAGE
go


-----------------------------------------------VIEW-------------------------------
--1.Xuất thông tin về mã nhà xuất bản, tên nhà xuất bản, số lượng đầu sách và tổng số lượng sách của nhà xuất bản có trong database
create view view_book_publisher
as
select PUBLISHER.idPublisher,namePublisher, count(idBook) as  amountTitle,sum(amount) as amountBook
from BOOK, PUBLISHER
where BOOK.idPublisher= PUBLISHER.idPublisher
group by PUBLISHER.idPublisher, namePublisher
go


--2.Thống kê mã sách, tên sách kèm số lượng đã bán của mỗi sách
create view view_Book_BillOutput
as
select BOOK.idBook, nameBook, sum(amountOutput) as sumAmountOutput
from BOOK,BILLOUTPUT,BOOK_BILLOUTPUT
where BOOK.idBook= BOOK_BILLOUTPUT.idBook and BILLOUTPUT.idBillOutPut= BOOK_BILLOUTPUT.idBillOutput
group by Book.idBook, nameBook


go


select * from book
select * from BOOK_AUTHOR
select * from BOOK_CATEGORY



select * from 
--3.	Xuất thông tin về khách hàng bao gồm : mã khách hàng, tên , địa chỉ, số điện thoại, loại khách hàng và số lượng sách đã mua
create or alter view view_customer_bookOutput
as
select CUSTOMER.idCus,CUSTOMER.nameCus, 
	   CUSTOMER.addressCus,CUSTOMER.phoneNumber, CUSTOMER.pointCus,
	   nameTypeCus, sum(amountOutput)as sumAmountOutput 
from BOOK,CUSTOMER,TYPECUSTOMER,BILLOUTPUT,BOOK_BILLOUTPUT
where CUSTOMER.idTypeCus = TYPECUSTOMER.idTypeCus 
	and BILLOUTPUT.idCus= CUSTOMER.idCus
	and BOOK.idBook = BOOK_BILLOUTPUT.idBook 
	and BOOK_BILLOUTPUT.idBillOutput= BILLOUTPUT.idBillOutPut
group by CUSTOMER.idCus, CUSTOMER.nameCus,
		CUSTOMER.addressCus, CUSTOMER.phoneNumber, CUSTOMER.pointCus, nameTypeCus
go


create or alter view view_customer_bookOutput 
as
select CUSTOMER.idCus,CUSTOMER.nameCus, 
	   CUSTOMER.addressCus,CUSTOMER.phoneNumber, CUSTOMER.pointCus,
	   nameTypeCus, sum(amountOutput)as sumAmountOutput 
from BOOK,CUSTOMER,TYPECUSTOMER,BILLOUTPUT,BOOK_BILLOUTPUT
where CUSTOMER.idTypeCus = TYPECUSTOMER.idTypeCus 
	and BILLOUTPUT.idCus= CUSTOMER.idCus
	and BOOK.idBook = BOOK_BILLOUTPUT.idBook 
	and BOOK_BILLOUTPUT.idBillOutput= BILLOUTPUT.idBillOutPut
group by CUSTOMER.idCus, CUSTOMER.nameCus,
		CUSTOMER.addressCus, CUSTOMER.phoneNumber, CUSTOMER.pointCus, nameTypeCus
go

--select * from view_customer_bookOutput where idCus = 1

--4.	Thống kê doanh thu theo từng ngày:
create view view_Revenue_BillOutput

as
select dateOfBill, sum(total) as revenue
from BILLOUTPUT
group by dateOfBill

go

--5.	Xem chi tiết hóa đơn bao gồm: mã hóa đơn, ngày xuất đơn, tên nhân viên, tên khách hàng,loại khách hàng, tên sách, số lượng mua, giá bán của sách, tổng tiền một loại sách, voucher được áp dụng ( cho toàn hóa đơn)
create view view_detail_BillOutPut
as
select BILLOUTPUT.idBillOutPut, firstName + middleName + lastName as nameEm, 
	CUSTOMER.nameCus,nameTypeCus,BOOK.idBook, nameBook, priceExport, amountOutput, 
	priceExport*amountOutput*valueVoucher/100 as totalPrice, valueVoucher, dateOfBill
from BILLOUTPUT, BOOK, VOUCHER, CUSTOMER, EMPLOYEE,BOOK_BILLOUTPUT, TYPECUSTOMER, DISCOUNT
where BILLOUTPUT.idCus= CUSTOMER.idCus and
	  BILLOUTPUT.idEmployee= EMPLOYEE.idEmployee and
	  BILLOUTPUT.idBillOutPut= BOOK_BILLOUTPUT.idBillOutput and
	  BOOK_BILLOUTPUT.idBook= BOOK.idBook and
	  CUSTOMER.idTypeCus= TYPECUSTOMER.idTypeCus and
	  VOUCHER.idVoucher= DISCOUNT.idVoucher and
	  DISCOUNT.idBill = BILLOUTPUT.idBillOutPut


<<<<<<< HEAD
=======

------------------------------View-------------------------------------------
--View tác giả
create view view_Author
as
select *
from dbo.AUTHOR
go

--View tài khoản
create view view_Account
as
select *
from dbo.ACCOUNT
go

>>>>>>> 8b764eec229463d82f96fc9fed78a671131d4404
