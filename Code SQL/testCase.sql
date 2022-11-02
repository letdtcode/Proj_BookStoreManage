---------------------TEST----------------
use BOOKSTOREMANAGE
exec proc_addNewAccount @nameAccount = 'boynguyenducthanh', @password = '1234567', @typeOfAcc = 0, @idEmployee = 1
go
exec proc_updateAccount @idAccount = '1', @nameAccount = 'boynguyen', @password = '20021223', @typeOfAcc = 1, @idEmployee = '1'