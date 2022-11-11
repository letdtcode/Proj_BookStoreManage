create database BOOKSTOREMANAGE
go
use BOOKSTOREMANAGE
go
CREATE TABLE [dbo].AUTHOR (
idAuthor varchar(8) NOT NULL,
nameAuthor nvarchar(30) NOT NULL,
phoneNumber varchar(10) NULL

CONSTRAINT pk_author PRIMARY KEY (idAuthor)
CONSTRAINT chk_phoneAuthor CHECK (len(phoneNumber) = 10)
)
GO 

CREATE TABLE [dbo].PUBLISHER (
idPublisher varchar(8) NOT NULL,
namePublisher nvarchar(30) NOT NULL,
addressPublisher nvarchar(30) NULL,
phoneNumber varchar(10) NULL

CONSTRAINT chk_phonePublisher CHECK (len(phoneNumber) = 10)
CONSTRAINT pk_publisher PRIMARY KEY (idPublisher)
)
GO 

CREATE TABLE [dbo].BOOK (
idBook varchar(8) NOT NULL,
nameBook nvarchar(20) NOT NULL,
urlImage image NULL,
amount int NULL,
priceImport int NULL,
priceExport int NULL,
idPublisher varchar(8) NULL

CONSTRAINT pk_book PRIMARY KEY (idBook),
CONSTRAINT fk_Publisher FOREIGN KEY (idPublisher) REFERENCES PUBLISHER (idPublisher),

CONSTRAINT chk_amount CHECK (amount >= 0),
CONSTRAINT chk_price CHECK (priceImport >= 0 and priceExport >= 0)
)
GO 
alter table dbo.book
add constraint df_amount
default 0 for amount
go

CREATE TABLE [dbo].TYPECUSTOMER (
idTypeCus varchar(8) NOT NULL,
nameTypeCus nvarchar(30) NOT NULL,
pointMark int NULL,
valueTypeCus int NULL

CONSTRAINT pk_typeCus PRIMARY KEY (idTypeCus)
)
GO

CREATE TABLE [dbo].CUSTOMER (
idCus varchar(8) NOT NULL,
nameCus nvarchar(30) NOT NULL,
addressCus nvarchar(30) NULL,
phoneNumber varchar(20) NULL,
pointCus int NOT NULL DEFAULT 0,
idTypeCus varchar(8) NULL

CONSTRAINT pk_customer PRIMARY KEY (idCus),
CONSTRAINT fk_TypeCus FOREIGN KEY (idTypeCus) REFERENCES TYPECUSTOMER (idTypeCus),
CONSTRAINT chk_phoneCustomer CHECK (len(phoneNumber) = 10)
)
GO

CREATE TABLE [dbo].EMPLOYEE (
idEmployee varchar(8) NOT NULL,
firstName nvarchar(10) NOT NULL,
middleName nvarchar(10) NULL,
lastName varchar(10) NOT NULL,
sex nvarchar(5) NOT NULL,
addEmp nvarchar(30) NULL,
phoneNumber varchar(10) NULL,
email varchar(50) NOT NULL, 
yearOfBirth date NULL,

CONSTRAINT chk_sex CHECK (upper(sex) like N'NAM' or upper(sex) like N'NỮ' or upper(sex) like N'KHÁC'),
CONSTRAINT chk_email CHECK (email like '%@gmail.com%'),
CONSTRAINT chk_yearOfBirth CHECK (DATEDIFF(YEAR,yearOfBirth,GETDATE()) >= 18 AND DATEDIFF(YEAR,yearOfBirth,GETDATE()) <= 50),
CONSTRAINT chk_phoneEmployee CHECK (len(phoneNumber) = 10),

CONSTRAINT pk_employee PRIMARY KEY (idEmployee)
)
go


CREATE TABLE [dbo].VOUCHER (
idVoucher varchar(8) NOT NULL,
valueVoucher int NOT NULL,
nameOfEventVoucher nvarchar(40) NULL,
dateStart date null,
dateEnd date null,
amount int NULL,

CONSTRAINT pk_voucher PRIMARY KEY (idVoucher),
)
GO

CREATE TABLE [dbo].BILLOUTPUT (
idBillOutPut varchar(8) NOT NULL,
dateOfBill date NOT NULL,
total int NOT NULL DEFAULT 0,
idCus varchar(8) NULL,
idEmployee varchar(8) NULL,
sttus bit default 0,
idVoucher varchar(8) null,

CONSTRAINT pk_billOutPut PRIMARY KEY (idBillOutPut),
CONSTRAINT fk_pay FOREIGN KEY (idCus) REFERENCES CUSTOMER (idCus),
CONSTRAINT fk_collect FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT fk_Discount FOREIGN KEY (idVoucher) REFERENCES VOUCHER (idVoucher),
)
GO 
alter table dbo.BILLOUTPUT
add constraint df_total
default 0 for total
go
alter table dbo.BILLOUTPUT
alter column dateOfBill date null
go
alter table dbo.billoutput
drop column 
go
alter table dbo.billoutput
drop constraint DF__BILLOUTPU__total__3D5E1FD2
go
delete from dbo.BOOK_BILLOUTPUT
where dbo.BOOK_BILLOUTPUT.idBillOutput='BILL10'
go
delete from dbo.BILLOUTPUT
where dbo.BILLOUTPUT.idBillOutput='BILL10'
go

go
CREATE TABLE [dbo].ACCOUNT (
idAccount varchar(8) NOT NULL,
nameAccount varchar(20) NOT NULL unique,
password varchar(30) NOT NULL,
typeOfAcc bit NOT NULL,
idEmployee varchar(8) NULL

CONSTRAINT pk_account PRIMARY KEY (idAccount),
CONSTRAINT fk_acc_Of_Employee FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT chk_userName CHECK (len(nameAccount) > 6),
CONSTRAINT chk_passwd CHECK (len(password) > 6)
)
GO

CREATE TABLE [dbo].CATEGORY (
idCategory varchar(8) NOT NULL,
nameCategory nvarchar(20) NOT NULL,
describeCategory nvarchar(50) NULL,

unique(nameCategory),
CONSTRAINT pk_category PRIMARY KEY (idCategory)
)
go



CREATE TABLE [dbo].BOOK_AUTHOR (
idBook varchar(8) NOT NULL,
idAuthor varchar(8) NOT NULL

CONSTRAINT pk_book_author PRIMARY KEY (idBook,idAuthor),
CONSTRAINT fk_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_author FOREIGN KEY (idAuthor) REFERENCES AUTHOR (idAuthor)
)
GO

CREATE TABLE [dbo].BOOK_CATEGORY (
idBook varchar(8) NOT NULL,
idCategory varchar(8) NOT NULL

CONSTRAINT pk_book_category PRIMARY KEY (idBook,idCategory)
CONSTRAINT fk_id_into_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_id_into_categgory FOREIGN KEY (idCategory) REFERENCES CATEGORY (idCategory)
)
GO

CREATE TABLE [dbo].BILLINPUT (
idBillInput varchar(8) NOT NULL,
dateOfInput date NULL,
total int NOT NULL DEFAULT 0,
idEmployee varchar(8) NULL,

CONSTRAINT pk_billinput PRIMARY KEY (idBillInput),
CONSTRAINT fk_employee_checkin FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee)
)
GO

CREATE TABLE [dbo].BOOK_BILLINPUT (
idBillInput varchar(8) NOT NULL,
idBook varchar(8) NOT NULL,
amountInput INT NULL,

CONSTRAINT pk_book_billinput PRIMARY KEY (idBillInput,idBook),
CONSTRAINT fk_idBillInput FOREIGN KEY (idBillInput) REFERENCES BILLINPUT (idBillInput),
CONSTRAINT fk_idBook_into_input FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
GO
CREATE TABLE [dbo].BOOK_BILLOUTPUT (
idBillOutput varchar(8) NOT NULL,
idBook varchar(8) NOT NULL,
amountOutput int NULL

CONSTRAINT pk_book_billoutput PRIMARY KEY (idBillOutput,idBook),
CONSTRAINT fk_idBillOuput FOREIGN KEY (idBillOutput) REFERENCES BILLOUTPUT (idBillOutput),
CONSTRAINT fk_idBook_into_output FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
go
alter table dbo.Book
alter column urlImage image
go
select * from dbo.view_Book
go
alter table dbo.category
add unique(nameCategory)
go

















