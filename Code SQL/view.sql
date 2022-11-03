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

select * from view_book_publisher

--2.Thống kê mã sách, tên sách kèm số lượng đã bán của mỗi sách
create view view_Book_BillOutput
as
select BOOK.idBook, nameBook, sum(amountOutput) as sumAmountOutput
from BOOK,BILLOUTPUT,BOOK_BILLOUTPUT
where BOOK.idBook= BOOK_BILLOUTPUT.idBook and BILLOUTPUT.idBillOutPut= BOOK_BILLOUTPUT.idBillOutput
group by Book.idBook, nameBook

select * from view_Book_BillOutput
go

--3.	Xuất thông tin về khách hàng bao gồm : mã khách hàng, tên , địa chỉ, số điện thoại, loại khách hàng và số lượng sách đã mua
create view view_customer_bookOutput
as
select CUSTOMER.idCus,CUSTOMER.nameCus, 
	   CUSTOMER.addressCus,CUSTOMER.phoneNumber,
	   nameTypeCus, sum(amountOutput)as sumAmountOutput 
from BOOK,CUSTOMER,TYPECUSTOMER,BILLOUTPUT,BOOK_BILLOUTPUT
where CUSTOMER.idTypeCus = TYPECUSTOMER.idTypeCus 
	and BILLOUTPUT.idCus= CUSTOMER.idCus
	and BOOK.idBook = BOOK_BILLOUTPUT.idBook 
	and BOOK_BILLOUTPUT.idBillOutput= BILLOUTPUT.idBillOutPut
group by CUSTOMER.idCus, CUSTOMER.nameCus,
		CUSTOMER.addressCus, CUSTOMER.phoneNumber, nameTypeCus

select * from view_customer_bookOutput
go

--4.	Thống kê doanh thu theo từng ngày:
create view view_Revenue_BillOutput
as
select dateOfBill, sum(total) as revenue
from BILLOUTPUT
group by dateOfBill

select * from view_Revenue_BillOutput
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

select * from view_detail_BillOutPut
go
------------------------------View-------------------------------------------
--View tác giả
create view view_Author
as
select *
from dbo.AUTHOR
go
--View nhà xuất bản
create view view_Publisher
as
select *
from dbo.PUBLISHER
go
--View thông tin Sách
create or alter view view_Book
as
select *
--BOOK.idBook, BOOK.nameBook, BOOK.amount, BOOK.priceImport, BOOK.priceExport, BOOK.idPublisher
from dbo.BOOK
go
--View thể loại
create or alter view view_Category
as
select *
from dbo.CATEGORY
go
--View tài khoản
create or alter view view_Account
as
select idaccount,nameaccount,password,case when dbo.ACCOUNT.typeOfAcc=1
												then
													'Admin'
											else
													'Nhân viên'
											end as TypeAcc,idemployee
from dbo.ACCOUNT
go
select *
from dbo.view_Account
go
--View hóa đơn nhập
create or alter view view_ReceiptImport
as
select *
from dbo.BILLINPUT
go
--View chi tiết hóa đơn nhập
create or alter view view_DetailReceiptImport
as
select *
from dbo.BOOK_BILLINPUT
go
--View hóa đơn xuất
create or alter view view_ReceiptExport
as
select *
from dbo.BILLOUTPUT
go
--View chi tiết hóa đơn xuất
create or alter view view_DetailReceiptExport
as
select *
from dbo.BOOK_BILLOUTPUT
go
--View thông tin khách hàng
create or alter view view_Customer
as
select *
from dbo.CUSTOMER
go
--View loại khách hàng
create or alter view view_TypeCustomer
as
select *
from dbo.TYPECUSTOMER
go
--View Nhân viên
create or alter view view_Employee
as
select *
from dbo.EMPLOYEE
go
--View voucher
create or alter view view_Voucher
as
select *
from dbo.VOUCHER
go
delete dbo.BOOK where BOOK.idBook=5