use BOOKSTOREMANAGE
go
--Tác giả
insert into dbo.AUTHOR values ('TG1',N'Nguyễn Nhật Ánh','0342293128')
insert into dbo.AUTHOR values ('TG2',N'William Shakespear','0377092166')
insert into dbo.AUTHOR values ('TG3',N'Charles Dickens','0356853029')
insert into dbo.AUTHOR values ('TG4',N'George Orwell','0987118308')
insert into dbo.AUTHOR values ('TG5',N'J.K. Rowling','0945802082')
insert into dbo.AUTHOR values ('TG6',N'Virginia Woolf','0915467229')
insert into dbo.AUTHOR values ('TG7',N'Ernest Hemingway','0989676871')
insert into dbo.AUTHOR values ('TG8',N'William Faulkner','0902636196')
insert into dbo.AUTHOR values ('TG9',N'Fyodor Mikhailovich','0386042429')
insert into dbo.AUTHOR values ('TG10',N'James Joyce','0338313043')
--Nhà xuất bản
insert into dbo.PUBLISHER values ('NXB1',N'Nhà xuất bản thanh niên','Sài Gòn','0342293128')
insert into dbo.PUBLISHER values ('NXB2',N'Nhà xuất bản tuổi trẻ','Hà Nội','0902636196')
insert into dbo.PUBLISHER values ('NXB3',N'Nhà xuất bản ĐHQHG','Vũng Tàu','0338313043')
insert into dbo.PUBLISHER values ('NXB4',N'Nhà xuất bản kim đồng','Bến Tre','0915467229')
insert into dbo.PUBLISHER values ('NXB5',N'Nhà xuất bản tiền phong','Gia Lai','0356853029')
--Thể loại
insert into dbo.CATEGORY values ('TL1',N'Trinh thám',N'Liên quan đến các vụ án')
insert into dbo.CATEGORY values ('TL2',N'Khoa học viễn tưởng',N'Thể loại phim thường sử dụng những yếu tố hư cấu')
insert into dbo.CATEGORY values ('TL3',N'Kiếm hiệp',N'Lấy bối cảnh thời phong kiến')
insert into dbo.CATEGORY values ('TL4',N'Hành động',N'Những cảnh hành động, yếu tố bạo lực')
insert into dbo.CATEGORY values ('TL5',N'Phiêu lưu',N'Du hành mạo hiểm')
insert into dbo.CATEGORY values ('TL6',N'Lãng mạn',N'Câu chuyện tình yêu của các nhân vật')
--Loại khách hàng
insert into dbo.TYPECUSTOMER values ('VIP1',N'Khách hàng mới',0,0)
insert into dbo.TYPECUSTOMER values ('VIP2',N'Khách hàng tiềm năng',20,1)
insert into dbo.TYPECUSTOMER values ('VIP3',N'Khách hàng thân thiết',40,2)
insert into dbo.TYPECUSTOMER values ('VIP4',N'Khách hàng vàng',60,3)
insert into dbo.TYPECUSTOMER values ('VIP5',N'Khách hàng bạch kim',80,4)
insert into dbo.TYPECUSTOMER values ('VIP6',N'Khách hàng kim cương',100,5)
insert into dbo.TYPECUSTOMER values ('VIP7',N'Khách hàng cao thủ',120,6)
insert into dbo.TYPECUSTOMER values ('VIP8',N'Khách hàng đại cao thủ',140,7)
insert into dbo.TYPECUSTOMER values ('VIP9',N'Khách hàng thách đấu',160,8)
insert into dbo.TYPECUSTOMER values ('VIP10',N'Khách hàng vô địch',180,9)
--Thông tin khách hàng
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH1',N'Nguyễn Trường An',N'Bạc Liêu','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH2',N'Nguyễn Quang Anh',N'Gia Lai','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH3',N'Nguyễn Tuấn Dương',N'Hà Nam','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH4',N'Nguyễn Quang Hải',N'Khánh Hòa','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH5',N'Nguyễn Tuấn Kiệt',N'Bình Thuận','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH6',N'Bùi Thiên Ân',N'Hải Dương','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH7',N'Bùi Đức Bình',N'Bình Dương','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH8',N'Võ Minh Khang',N'Cao Bằng','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH9',N'Võ Tiến Thành',N'Đà Nẵng','0342293128','VIP1')
insert into dbo.CUSTOMER(idCus,nameCus,addressCus,phoneNumber,idTypeCus) values ('KH10',N'Phan Minh Anh',N'Đồng Tháp','0342293128','VIP1')
--Thông tin nhân viên
insert into dbo.EMPLOYEE values ('NV1',N'Nguyễn',N'Đức',N'Thành',N'Nam',N'Sài Gòn','0342293128','boynguyenducthanh@gmail.com','2002-12-23')
insert into dbo.EMPLOYEE values ('NV2',N'Nguyễn',N'Ngọc',N'Linh',N'Nữ',N'Sài Gòn','0342293128','boynguyenducthanh@gmail.com','2001-10-14')
insert into dbo.EMPLOYEE values ('NV3',N'Bùi',N'Tấn',N'Đạt',N'Nam',N'Sài Gòn','0342293128','boynguyenducthanh@gmail.com','2000-05-16')
insert into dbo.EMPLOYEE values ('NV4',N'Đỗ',N'Đức',N'Minh',N'Nam',N'Sài Gòn','0342293128','boynguyenducthanh@gmail.com','2003-07-26')
insert into dbo.EMPLOYEE values ('NV5',N'Nguyễn',N'Thái Ngọc',N'Tân',N'Nam',N'Sài Gòn','0342293128','boynguyenducthanh@gmail.com','1999-02-12')
--Thêm tài khoản
exec proc_addNewAccount 'ACC1','admin01','admin01',1,'NV1'
exec proc_addNewAccount 'ACC2','admin02','admin02',1,'NV2'
exec proc_addNewAccount 'ACC3','nhanvien01','nhanvien01',0,'NV3'
exec proc_addNewAccount 'ACC4','nhanvien02','nhanvien02',0,'NV4'
--Thêm voucher
insert into dbo.VOUCHER values ('VC1',100,N'Chào mừng nhà giáo Việt Nam','2022-05-30','2022-11-15',100)
insert into dbo.VOUCHER values ('VC2',40,N'Săn sale sập sàn nhận ngàn quà tặng','2022-03-24','2022-11-20',100)
insert into dbo.VOUCHER values ('VC3',200,N'Quẩy tưng bừng khai trương cửa hàng mới','2021-07-30','2022-10-15',100)
insert into dbo.VOUCHER values ('VC4',150,N'Kỷ niệm 5 năm thành lập','2022-05-30','2022-11-20',100)
insert into dbo.VOUCHER values ('VC5',300,N'Trung thu nhận ngàn yêu thương','2022-04-30','2022-08-15',100)



