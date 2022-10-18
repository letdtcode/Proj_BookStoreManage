use BOOKSTOREMANAGE
go


---insert data author
insert into AUTHOR (nameAuthor, phoneNumber) values (N'Nguyen Van A', '0987342334')
insert into AUTHOR (nameAuthor, phoneNumber) values (N'Nguyen Van B', '0127342334')
insert into AUTHOR (nameAuthor, phoneNumber) values (N'Nguyen Van C', '0287342334')

select * from AUTHOR

--insert data publisher
insert into PUBLISHER (namePublisher, addressPublisher, phoneNumber) values ('Nha Xuat Ban Ha Noi', 'HaNoi', '0124567239')
insert into PUBLISHER (namePublisher, addressPublisher, phoneNumber) values ('Nha Xuat Ban Quoc Te', 'TP.HCM', '0124444239')
insert into PUBLISHER (namePublisher, addressPublisher, phoneNumber) values ('Nha Xuat Ban Thanh Nien', 'TP.HCM', '0124121239')

select * from PUBLISHER

--insert data Catergory
insert into CATEGORY (nameCategory) values ('Co tich')
insert into CATEGORY (nameCategory) values ('Truyen ngan')
insert into CATEGORY (nameCategory) values ('Trinh Tham')
insert into CATEGORY (nameCategory) values ('Ngon Tinh')
insert into CATEGORY (nameCategory) values ('Giao Trinh')

select * from CATEGORY

--insert data book
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Trinh Tham A', 1000, 30000, 50000, 1)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Trinh Tham B', 1000, 35000, 70000, 1)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Trinh Tham C', 1000, 60000, 100000, 1)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Trinh Tham D', 1000, 33000, 55000, 2)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Trinh Tham E', 1000, 30000, 50000, 3)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Giao Trinh A', 1000, 30000, 50000, 3)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Giao Trinh B', 1000, 30000, 50000, 3)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Giao Trinh C', 1000, 30000, 50000, 3)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Giao Trinh D', 1000, 30000, 50000, 1)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Giao Trinh E', 1000, 30000, 50000, 2)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Ngon Tinh A', 1000, 30000, 50000, 1)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Ngon Tinh B', 1000, 30000, 50000, 2)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Ngon Tinh C', 1000, 30000, 50000, 3)
insert into BOOK (nameBook, amount, priceImport, priceExport, idPublisher) values ('Ngon Tinh D', 1000, 30000, 50000, 2)

select * from BOOK

-- insert data book_author
insert into BOOK_AUTHOR values (1, 1)
insert into BOOK_AUTHOR values (1, 2)
insert into BOOK_AUTHOR values (1, 3)
insert into BOOK_AUTHOR values (2, 1)
insert into BOOK_AUTHOR values (3, 1)

insert into BOOK_AUTHOR values (4, 1)
insert into BOOK_AUTHOR values (4, 2)
insert into BOOK_AUTHOR values (4, 3)
insert into BOOK_AUTHOR values (5, 1)
insert into BOOK_AUTHOR values (6, 2)
insert into BOOK_AUTHOR values (7, 2)
insert into BOOK_AUTHOR values (8, 2)
insert into BOOK_AUTHOR values (9, 3)
insert into BOOK_AUTHOR values (10, 1)
insert into BOOK_AUTHOR values (11, 3)
insert into BOOK_AUTHOR values (12, 3)
insert into BOOK_AUTHOR values (13, 1)
insert into BOOK_AUTHOR values (13, 2)
insert into BOOK_AUTHOR values (13, 3)
insert into BOOK_AUTHOR values (14, 2)
insert into BOOK_AUTHOR values (14, 3)

select * from BOOK_AUTHOR

--insert data book_caregory
insert into BOOK_CATEGORY values (1, 4)
insert into BOOK_CATEGORY values (1, 3)
insert into BOOK_CATEGORY values (2, 4)
insert into BOOK_CATEGORY values (3, 4)
insert into BOOK_CATEGORY values (4, 4)
insert into BOOK_CATEGORY values (4, 3)
insert into BOOK_CATEGORY values (5, 4)

insert into BOOK_CATEGORY values (6, 5)
insert into BOOK_CATEGORY values (7, 5)
insert into BOOK_CATEGORY values (8, 5)
insert into BOOK_CATEGORY values (9, 5)
insert into BOOK_CATEGORY values (10, 5)

insert into BOOK_CATEGORY values (11, 1)
insert into BOOK_CATEGORY values (11, 3)
insert into BOOK_CATEGORY values (11, 5)
insert into BOOK_CATEGORY values (12, 5)
insert into BOOK_CATEGORY values (12, 3)
insert into BOOK_CATEGORY values (13, 5)
insert into BOOK_CATEGORY values (14, 5)

select * from BOOK_CATEGORY

--insert data TypeCus
insert into TYPECUSTOMER (nameTypeCus, pointMark, valueTypeCus) values ('kim cuong', 100, 30)
insert into TYPECUSTOMER (nameTypeCus, pointMark, valueTypeCus) values ('vang', 70, 25)
insert into TYPECUSTOMER (nameTypeCus, pointMark, valueTypeCus) values ('bac', 60, 20)
insert into TYPECUSTOMER (nameTypeCus, pointMark, valueTypeCus) values ('dong', 50, 15)

select * from TYPECUSTOMER


--insert data Customer
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Nguyen Van A', 'HCMC', 0126789234, 10, NULL) 
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Nguyen Thi H', 'HCMC', 0167789234, 55, 4) 
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Tran Van B', 'HCMC', 0124569234, 65, 3) 
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Do Van M', 'HCMC', 0126789234, 90, 2) 
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Nguyen Thi N', 'HCMC', 0167789234, 110, 1) 
insert into CUSTOMER (nameCus, addressCus, phoneNumber, pointCus, idTypeCus) values (N'Le Van C', 'HCMC', 0145789234, 101, 1) 
select * from CUSTOMER

--insert data Employee
insert into EMPLOYEE (firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth) values ('Le', 'Thi', 'Ly', N'NỮ', 'HCMC', '0126754389', 'lyle112@gmail.com', '2000')
insert into EMPLOYEE (firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth) values ('Pham', 'Thi', 'Ly', N'Nữ', 'HCMC', '0126752355', 'lypham100@gmail.com', '2002')
insert into EMPLOYEE (firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth) values ('Pham', 'Ngoc', 'Anh', N'nam', 'HCMC', '0126752355', 'lypham100@gmail.com', '2002')
insert into EMPLOYEE (firstName, middleName, lastName, sex, addEmp, phoneNumber, email, yearOfBirth) values ('Pham', N'Viết', 'Hiền', N'nam', 'HCMC', '0126752355', 'Viethien@gmail.com', '2000')


select * from EMPLOYEE


-- insert data account
insert into ACCOUNT (nameAccount, pass, typeOfAcc, idEmployee) values ('lyle112', 'abcd1234', 1, 4)
insert into ACCOUNT (nameAccount, pass, typeOfAcc, idEmployee) values ('phamanh', 'abcd1234', 0, 3)
insert into ACCOUNT (nameAccount, pass, typeOfAcc, idEmployee) values ('viethien', 'abcd1234', 0, 1)
insert into ACCOUNT (nameAccount, pass, typeOfAcc, idEmployee) values ('phamly100', 'abcd1234', 1, 2)

select * from ACCOUNT


--insert billinput

insert into BILLINPUT (dateOfInput, idEmployee) values ('2022-10-1', 1)
insert into BILLINPUT (dateOfInput, idEmployee) values ('2022-10-2', 1)
insert into BILLINPUT (dateOfInput, idEmployee) values ('2022-10-3', 4)

select * from BILLINPUT
-- insert book_billinput
insert into BOOK_BILLINPUT (idBillInput, idBook, amountInput) values (1, 1, 3000)
insert into BOOK_BILLINPUT (idBillInput, idBook, amountInput) values (2, 10, 3000)
insert into BOOK_BILLINPUT (idBillInput, idBook, amountInput) values (3, 5, 3000)

select * from BOOK_BILLINPUT

--insert data voucher
insert into VOUCHER (valueVoucher, nameOfEventVoucher, dateStart, dateEnd, amount) 
	values (10, N'Khuyến mãi tháng 10', '2022-10-20', '2022-10-21', 10)
insert into VOUCHER (valueVoucher, nameOfEventVoucher, dateStart, dateEnd, amount) 
	values (10, N'Khuyến mãi tháng 10', '2022-10-19', '2022-10-22', 10)
insert into VOUCHER (valueVoucher, nameOfEventVoucher, dateStart, dateEnd, amount) 
	values (10, N'Khuyến mãi tháng 10', '2022-10-20', '2022-10-22', 10)

select * from VOUCHER


--insert BillOutput

insert into BILLOUTPUT (dateOfBill, idCus, idEmployee) values ('2022-10-1', 1, 1)
insert into BILLOUTPUT (dateOfBill, idCus, idEmployee) values ('2022-10-2', 4, 2)
insert into BILLOUTPUT (dateOfBill, idCus, idEmployee) values ('2022-10-3', 6, 4)

select * from BILLOUTPUT

--insert book_billoutput

insert into BOOK_BILLOUTPUT values (1, 3, 100)
insert into BOOK_BILLOUTPUT values (1, 5, 200)
insert into BOOK_BILLOUTPUT values (2, 2, 10)

select * from BOOK_BILLOUTPUT





