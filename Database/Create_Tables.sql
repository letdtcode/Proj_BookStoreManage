\create database BOOKSTOREMANAGE
go

use BOOKSTOREMANAGE
go
-------------------------------------
CREATE TABLE [dbo].AUTHOR (
	idAuthor INT IDENTITY(1,1) NOT NULL,
	nameAuthor nvarchar(30) NOT NULL,
	phoneNumber varchar(10) NULL

	CONSTRAINT pk_author PRIMARY KEY (idAuthor)
	CONSTRAINT chk_phoneAuthor CHECK (len(phoneNumber) = 10)
)
GO 

--------------------------------------
CREATE TABLE [dbo].PUBLISHER (
	idPublisher INT IDENTITY(1,1) NOT NULL,
	namePublisher nvarchar(30) NOT NULL,
	addressPublisher nvarchar(30) NULL,
	phoneNumber varchar(10) NULL

	CONSTRAINT chk_phonePublisher CHECK (len(phoneNumber) = 10)
	CONSTRAINT pk_publisher PRIMARY KEY (idPublisher)
)
GO 

-------------------------------------

CREATE TABLE [dbo].CATEGORY (
	idCategory INT IDENTITY(1,1) NOT NULL,
	nameCategory nvarchar(20) NOT NULL

	CONSTRAINT pk_category PRIMARY KEY (idCategory)
)
go

-------------------------------------
CREATE TABLE [dbo].BOOK (
	idBook INT IDENTITY(1,1) NOT NULL,
	nameBook nvarchar(20) NOT NULL,
	imageBook image NULL,
	amount int NULL,
	priceImport int NULL,
	priceExport int NULL,
	idPublisher int NULL
	CONSTRAINT pk_book PRIMARY KEY (idBook),
	CONSTRAINT fk_Publisher FOREIGN KEY (idPublisher) REFERENCES PUBLISHER (idPublisher),

	CONSTRAINT chk_amount CHECK (amount >= 0),
	CONSTRAINT chk_price CHECK (priceImport >= 0 and priceExport >= 0 and priceImport < priceExport)
)
GO 

------------------------------------------------------

CREATE TABLE [dbo].BOOK_AUTHOR (
	idBook INT NOT NULL,
	idAuthor INT NOT NULL

	CONSTRAINT pk_book_author PRIMARY KEY (idBook,idAuthor),
	CONSTRAINT fk_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
	CONSTRAINT fk_author FOREIGN KEY (idAuthor) REFERENCES AUTHOR (idAuthor)
	)
GO
-------------------------------------

CREATE TABLE [dbo].BOOK_CATEGORY (
	idBook INT NOT NULL,
	idCategory int NOT NULL

	CONSTRAINT pk_book_category PRIMARY KEY (idBook,idCategory)
	CONSTRAINT fk_id_into_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
	CONSTRAINT fk_id_into_categgory FOREIGN KEY (idCategory) REFERENCES CATEGORY (idCategory)
)
GO


-------------------------------------

CREATE TABLE [dbo].TYPECUSTOMER (
	idTypeCus INT IDENTITY(1,1) NOT NULL,
	nameTypeCus nvarchar(30) NOT NULL,
	pointMark int NULL,
	valueTypeCus int NULL

	CONSTRAINT pk_typeCus PRIMARY KEY (idTypeCus)
)
GO
-------------------------------------

CREATE TABLE [dbo].CUSTOMER (
	idCus INT IDENTITY(1,1) NOT NULL,
	nameCus nvarchar(30) NOT NULL,
	addressCus nvarchar(30) NULL,
	phoneNumber varchar(20) NULL,
	pointCus int NOT NULL DEFAULT 0,
	idTypeCus INT NULL


	CONSTRAINT pk_customer PRIMARY KEY (idCus)
	CONSTRAINT fk_TypeCus FOREIGN KEY (idTypeCus) REFERENCES TYPECUSTOMER (idTypeCus)
)
GO

-------------------------------------

CREATE TABLE [dbo].EMPLOYEE (
	idEmployee INT IDENTITY(1,1) NOT NULL,
	firstName nvarchar(10) NOT NULL,
	middleName nvarchar(10) NULL,
	lastName varchar(10) NOT NULL,
	sex nvarchar(5) NOT NULL,
	addEmp nvarchar(30) NULL,
	phoneNumber varchar(10) NULL,
	email varchar(50) NOT NULL, 
	yearOfBirth date NULL,

	CONSTRAINT chk_sex CHECK (upper(sex) like N'NAM' or upper(sex) like N'NỮ' or upper(sex) like N'KHÁC'), -- Dũng mỡi sửa
	CONSTRAINT chk_email CHECK (email like '%@gmail.com%'), --- Dũng mới sửa
	CONSTRAINT chk_yearOfBirth CHECK (DATEDIFF(YEAR,yearOfBirth,GETDATE()) >= 18 AND DATEDIFF(YEAR,yearOfBirth,GETDATE()) <= 50),
	CONSTRAINT chk_phone CHECK (len(phoneNumber) = 10),
	CONSTRAINT pk_employee PRIMARY KEY (idEmployee)
)
GO 

-----------------------------------------------


CREATE TABLE [dbo].ACCOUNT (
	idAccount INT IDENTITY(1,1) NOT NULL,
	nameAccount varchar(20) NOT NULL unique,
	pass varchar(30) NOT NULL,
	typeOfAcc bit NOT NULL,
	idEmployee int NULL

	CONSTRAINT pk_account PRIMARY KEY (idAccount),
	CONSTRAINT fk_acc_Of_Employee FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
	CONSTRAINT chk_userName CHECK (len(nameAccount) > 6),
	CONSTRAINT chk_passwd CHECK (len(pass) > 6)
)
GO

-------------------------------------

CREATE TABLE [dbo].VOUCHER (
	idVoucher INT IDENTITY(1,1) NOT NULL,
	valueVoucher int NOT NULL,
	nameOfEventVoucher nvarchar(40) NULL,
	dateStart date null,
	dateEnd date null,
	amount int NULL,

	CONSTRAINT pk_voucher PRIMARY KEY (idVoucher),
	--CONSTRAINT fk_Discount FOREIGN KEY (idBill) REFERENCES BILL (idBill)
)
GO

------------------------------------- 

CREATE TABLE [dbo].BILLOUTPUT (
	idBillOutPut INT IDENTITY(1,1) NOT NULL,
	dateOfBill date NOT NULL,
	total int NOT NULL DEFAULT 0,
	idCus int NULL,
	idEmployee int NULL,
	idVoucher int NULL

	CONSTRAINT pk_billOutPut PRIMARY KEY (idBillOutPut)
	CONSTRAINT fk_pay FOREIGN KEY (idCus) REFERENCES CUSTOMER (idCus),
	CONSTRAINT fk_collect FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
	CONSTRAINT fk_voucher FOREIGN KEY (idVoucher) REFERENCES VOUCHER (idVoucher)
)
GO

------------------------------------- 

CREATE TABLE [dbo].BOOK_BILLOUTPUT (
	idBillOutput INT NOT NULL,
	idBook INT NOT NULL,
	amountOutput int NULL

	CONSTRAINT pk_book_billoutput PRIMARY KEY (idBillOutput,idBook),
	CONSTRAINT fk_idBillOuput FOREIGN KEY (idBillOutput) REFERENCES BILLOUTPUT (idBillOutput),
	CONSTRAINT fk_idBook_into_output FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
go


-------------------------------------
--CREATE TABLE [dbo].DISCOUNT (
--idBill INT NOT NULL,
--idVoucher INT NOT NULL

--CONSTRAINT pk_discount PRIMARY KEY (idBill,idVoucher)
--CONSTRAINT fk_bill_discount FOREIGN KEY (idBill) REFERENCES BILLOUTPUT (idBillOutPut),
--CONSTRAINT fk_voucher FOREIGN KEY (idVoucher) REFERENCES VOUCHER (idVoucher)
--)
--GO

-------------------------------------

CREATE TABLE [dbo].BILLINPUT (
	idBillInput INT IDENTITY(1,1) NOT NULL,
	dateOfInput date NULL,
	total int NOT NULL DEFAULT 0,
	idEmployee INT NULL

	CONSTRAINT pk_billinput PRIMARY KEY (idBillInput)
	CONSTRAINT fk_employee_checkin FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee)
)
GO
-------------------------------------

CREATE TABLE [dbo].BOOK_BILLINPUT (
	idBillInput INT NOT NULL,
	idBook INT NOT NULL,
	amountInput INT NULL,

	CONSTRAINT pk_book_billinput PRIMARY KEY (idBillInput,idBook),
	CONSTRAINT fk_idBillInput FOREIGN KEY (idBillInput) REFERENCES BILLINPUT (idBillInput),
	CONSTRAINT fk_idBook_into_input FOREIGN KEY (idBook) REFERENCES BOOK (idBook)
)
GO
-------------------------------------
