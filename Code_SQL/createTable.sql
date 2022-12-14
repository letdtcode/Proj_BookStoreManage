create database BOOKSTOREMANAGE
go
use BOOKSTOREMANAGE
go
CREATE TABLE [dbo].AUTHOR (
idAuthor int IDENTITY(1,1) NOT NULL,
nameAuthor nvarchar(30) NOT NULL unique,
phoneNumber varchar(10) NULL

CONSTRAINT pk_author PRIMARY KEY (idAuthor)
--CONSTRAINT chk_phoneAuthor CHECK (len(phoneNumber) = 10)
)
GO 

CREATE TABLE [dbo].PUBLISHER (
idPublisher int IDENTITY(1,1) NOT NULL,
namePublisher nvarchar(30) NOT NULL,
addressPublisher nvarchar(30) NULL,
phoneNumber varchar(10) NULL

--CONSTRAINT chk_phonePublisher CHECK (len(phoneNumber) = 10)
CONSTRAINT pk_publisher PRIMARY KEY (idPublisher)
)
GO 

CREATE TABLE [dbo].BOOK (
idBook int IDENTITY(1,1) NOT NULL,
nameBook nvarchar(20) NOT NULL,
urlImage image NULL,
amount int not null default 0,
priceImport int NULL,
priceExport int NULL,
idPublisher int NULL

CONSTRAINT pk_book PRIMARY KEY (idBook),
CONSTRAINT fk_Publisher FOREIGN KEY (idPublisher) REFERENCES PUBLISHER (idPublisher),
CONSTRAINT chk_amount CHECK (amount >= 0),
CONSTRAINT chk_price CHECK (priceImport >= 0 and priceExport >= 0)
)
GO 

CREATE TABLE [dbo].TYPECUSTOMER (
idTypeCus int IDENTITY(1,1) NOT NULL,
nameTypeCus nvarchar(30) NOT NULL,
pointMark int NULL,
valueTypeCus int NULL

CONSTRAINT pk_typeCus PRIMARY KEY (idTypeCus),
CONSTRAINT chk_pointMark CHECK (pointMark >= 0),
CONSTRAINT chk_valueTypeCus CHECK (valueTypeCus >= 0 and valueTypeCus < 100)
)
GO

CREATE TABLE [dbo].CUSTOMER (
idCus int IDENTITY(1,1) NOT NULL,
nameCus nvarchar(30) NOT NULL,
addressCus nvarchar(30) NULL,
phoneNumber varchar(20) NULL,
pointCus int NOT NULL DEFAULT 0,
idTypeCus int NULL

CONSTRAINT pk_customer PRIMARY KEY (idCus),
CONSTRAINT fk_TypeCus FOREIGN KEY (idTypeCus) REFERENCES TYPECUSTOMER (idTypeCus),
--CONSTRAINT chk_phoneCustomer CHECK (len(phoneNumber) = 10),
CONSTRAINT chk_pointCus CHECK (pointCus >= 0)
)
GO

CREATE TABLE [dbo].EMPLOYEE (
idEmployee int IDENTITY(1,1) NOT NULL,
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
--CONSTRAINT chk_phoneEmployee CHECK (len(phoneNumber) = 10),

CONSTRAINT pk_employee PRIMARY KEY (idEmployee)
)
go


CREATE TABLE [dbo].VOUCHER (
idVoucher int IDENTITY(1,1) NOT NULL,
valueVoucher int NOT NULL,
nameOfEventVoucher nvarchar(40) NULL,
dateStart date not null,
dateEnd date not null,
amount int NULL,

CONSTRAINT pk_voucher PRIMARY KEY (idVoucher),
CONSTRAINT chk_dateOfVoucher CHECK (DATEDIFF(day,dateStart,dateEnd)>0)
)
GO

CREATE TABLE [dbo].BILLOUTPUT (
idBillOutPut int IDENTITY(1,1) NOT NULL,
dateOfBill date NULL,
total int NOT NULL DEFAULT 0,
idCus int NULL,
idEmployee int NULL,
idVoucher int null,
stateBill bit,

CONSTRAINT pk_billOutPut PRIMARY KEY (idBillOutPut),
CONSTRAINT fk_pay FOREIGN KEY (idCus) REFERENCES CUSTOMER (idCus),
CONSTRAINT fk_collect FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT fk_Discount FOREIGN KEY (idVoucher) REFERENCES VOUCHER (idVoucher),
)
GO 

CREATE TABLE [dbo].ACCOUNT (
idAccount int IDENTITY(1,1) NOT NULL,
nameAccount varchar(20) NOT NULL unique,
password varchar(30) NOT NULL,
typeOfAcc bit NOT NULL,
idEmployee int NULL

CONSTRAINT pk_account PRIMARY KEY (idAccount),
CONSTRAINT fk_acc_Of_Employee FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT chk_userName CHECK (len(nameAccount) > 6),
CONSTRAINT chk_passwd CHECK (len(password) > 6)
)
GO

CREATE TABLE [dbo].CATEGORY (
idCategory int IDENTITY(1,1) NOT NULL,
nameCategory nvarchar(20) NOT NULL unique,
describeCategory nvarchar(50) NULL,

CONSTRAINT pk_category PRIMARY KEY (idCategory)
)
GO

CREATE TABLE [dbo].BOOK_AUTHOR (
idBook int NOT NULL,
idAuthor int NOT NULL,

CONSTRAINT pk_book_author PRIMARY KEY (idBook,idAuthor),
CONSTRAINT fk_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_author FOREIGN KEY (idAuthor) REFERENCES AUTHOR (idAuthor)
)
GO

CREATE TABLE [dbo].BOOK_CATEGORY (
idBook int NOT NULL,
idCategory int NOT NULL,

CONSTRAINT pk_book_category PRIMARY KEY (idBook,idCategory)
CONSTRAINT fk_id_into_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_id_into_categgory FOREIGN KEY (idCategory) REFERENCES CATEGORY (idCategory)
)
GO

CREATE TABLE [dbo].BILLINPUT (
idBillInput int IDENTITY(1,1) NOT NULL,
dateOfInput date NULL,
total int NOT NULL DEFAULT 0,
idEmployee int NULL,

CONSTRAINT pk_billinput PRIMARY KEY (idBillInput),
CONSTRAINT fk_employee_checkin FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee)
)
GO

CREATE TABLE [dbo].BOOK_BILLINPUT (
idBillInput int NOT NULL,
idBook int NOT NULL,
amountInput INT NOT NULL,

CONSTRAINT pk_book_billinput PRIMARY KEY (idBillInput,idBook),
CONSTRAINT fk_idBillInput FOREIGN KEY (idBillInput) REFERENCES BILLINPUT (idBillInput),
CONSTRAINT fk_idBook_into_input FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
GO
CREATE TABLE [dbo].BOOK_BILLOUTPUT (
idBillOutput int NOT NULL,
idBook int NOT NULL,
amountOutput int NOT NULL

CONSTRAINT pk_book_billoutput PRIMARY KEY (idBillOutput,idBook),
CONSTRAINT fk_idBillOuput FOREIGN KEY (idBillOutput) REFERENCES BILLOUTPUT (idBillOutput),
CONSTRAINT fk_idBook_into_output FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
go

















