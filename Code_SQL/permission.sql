use BOOKSTOREMANAGE
go

create or alter proc proc_permission (@user nvarchar (20), @pass nvarchar(20))
as
begin
	declare @state nvarchar (100), @role bit
	set @role = (select typeOfAcc from ACCOUNT where nameAccount like @user and password like @pass)
	print @role
	if (@role = 1)
	begin
		set @state = 'grant exec, control to ' + @user
		exec (@state)
		exec master ..sp_addsrvrolemember @user, N'sysadmin'
		print N'Đã gán quyền của admin' 
	end
	else if(@role = 0) 
	begin
		--cấp quyền vào các bảng
		set @state = 'grant select, update, delete, insert, control to '+ @user
		exec (@state)
		-- cấm quyền vào account
		set @state = 'deny control, select, update, insert, delete on object::ACCOUNT To ' + @user
		exec (@state)
		-- cấm quyền vào nhân viên
		set @state = 'deny control, select, update, insert, delete on object::EMPLOYEE To ' + @user
		exec (@state)
		-- cấm quyền xem account
		set @state = 'deny control, select, update, insert, delete on object::view_Account to ' + @user
		exec (@state)
		--cấm quyền xem nhân viên
		set @state = 'deny control, select, update, insert, delete on object::view_Employee to ' + @user
		exec (@state)
		
		print N'Đã gán quyền user'
	end
end
go


Create or alter proc proc_deleteUser (@user nvarchar(20))
as
begin
	declare @state1 nvarchar(200), @state2 nvarchar(200)
	begin transaction deleteUser
	begin try
		set @state1 = 'drop login ' +@user
		set @state2 = 'drop user ' +@user
		exec (@state1)
		exec (@state2)
		commit transaction deleteUser
	end try
	begin catch
		print (error_message())
		rollback transaction deleteUser
	end catch
end
go



create or alter proc proc_createUser (@user nvarchar(30), @pass nvarchar (30))
as
begin

	declare @createLogin nvarchar (100)
	declare @createUser nvarchar (100)

	set @createLogin = 'Create Login ' + @user + ' with password = ''' + @pass + ''''
	set @createUser = 'Create User ' + @user + ' For Login ' + @user
	
	print @createLogin
	print @createUser

	exec (@createLogin)
	exec (@createUser)

	exec proc_permission @user, @pass

end
go


Create or alter proc proc_updateUser (@user varchar (20), @newPass varchar(30), @oldPass varchar)
as
begin 
	declare @state varchar (200)
	set @state = 'login '+@user+' with password = '+@newPass --+ ' old_password = ' +@oldPass
	exec (@state)
end
go
--------------------nháp-------------------------
ALTER USER Mary5 WITH NAME = Mary51;
GO
ALTER USER Mary51 WITH DEFAULT_SCHEMA = Purchasing;
GO
ALTER USER Mai
WITH LOGIN = Mai;
GO
---Cấm user: abcd1234 tới account
deny select, update, insert, delete on object::ACCOUNT To abcd1234
--deny EXECUTE ON XML SCHEMA COLLECTION::ACCOUNT to acbd1234

--cấm thực thi proc trên acc: abcd1234
deny EXECUTE on object::proc_addNewAccount to abcd1234
-- cấm select view
deny select on object::view_ACCOUNT to abcd1234

Grant all to dmgdung
grant IMPERSONATE on user::abcd1234 to dmgdung
REVOKE CONTROL ON USER::abcd1234 FROM dmgdung;  

revoke all to abcd1234
drop login dmgdung
DROP USER IF EXISTS abcd1234 


	select * from ACCOUNT
insert into ACCOUNT values ('ACC1', 'dungdmd', 'abcd1234', 1, 'NV1')
insert into ACCOUNT values ('ACC2', 'lyly1122', 'abcd1234', 0, 'NV1')
insert into ACCOUNT values ('ACC3', 'viethien', 'abcd1234', 0, 'NV1')

Create Login dungdmd with password ='abcd1234'
Create User dungdmd For Login dungdmd

grant execute on proc_DeleteAccount to dungdmd
GRANT EXEC ON SCHEMA::dbo TO dungdmd
grant exec, control, select, update, delete, insert to dungdmd
GRANT CONTROL ON DATABASE::BOOKSTOREMANAGE TO dungdmd;
grant  BACKUP DATABASE to dungdmd
grant CREATE ROLE to dungdmd
grant ALTER ANY USER to dungdmd
grant alter any login to dungdmd
grant BOOKSTOREMANAGE to dungdmd
grant insert to dungdmd

