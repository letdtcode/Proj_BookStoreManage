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
		set @state = 'grant select, update, delete, insert to '+ @user
		exec (@state)
		set @state = 'grant exec to '+ @user
		exec (@state)
		-- cấm quyền vào account
		set @state = 'deny select, update, insert, delete on object::ACCOUNT To ' + @user
		exec (@state)
		-- cấm quyền xem account
		set @state = 'deny select, update, insert, delete on object::view_Account to ' + @user
		exec (@state)
		-- cấm quyền thêm account
		set @state = 'deny exec on object::proc_addNewAccount to ' + @user
		exec (@state)
		-- cấm quyền chỉnh sửa account
		set @state = 'deny exec on object::proc_updateAccount to ' + @user
		exec (@state)
		-- cấm quyền xóa account
		set @state = 'deny exec on object::proc_DeleteAccount to ' + @user
		exec (@state)
		-- cấm quyền tìm kiếm account
		set @state = 'deny select, update, insert, delete on object::func_searchAccount to ' + @user
		exec (@state)

		-- cấm quyền vào nhân viên
		set @state = 'deny select, update, insert, delete on object::EMPLOYEE To ' + @user
		exec (@state)
		--cấm quyền xem nhân viên
		set @state = 'deny select, update, insert, delete on object::view_Employee to ' + @user
		exec (@state)
		-- Cấm quyền thêm nhân viên
		set @state = 'deny exec on object::proc_addNewEmployee to ' + @user
		exec (@state)
		-- Cấm quyền sửa nhân viên
		set @state = 'deny exec on object::proc_updateEmployee to ' + @user
		exec (@state)
		-- Cấm quyền xóa nhân viên
		set @state = 'deny exec on object::proc_deleteEmployee to ' + @user
		exec (@state)
		
		-- Cấm quyền xem doanh thu
		set @state = 'deny exec on object::proc_ShowRevenue to ' + @user
		exec (@state)

		set @state = 'deny exec on object::proc_ShowTop5Book to ' + @user
		exec (@state)

		set @state = 'deny exec on object::proc_Overview_Revenue to ' + @user
		exec (@state)

		set @state = 'deny exec on object::proc_Overview_AmountBillOutput to ' + @user
		exec (@state)

		set @state = 'deny control, select, update, delete, insert on object::view_top5StockMin to ' + @user
		exec (@state)

		set @state = 'deny exec on object::proc_Overview_AmountBookBillOutput to ' + @user
		exec (@state)
		print N'Đã gán quyền user'
	end
end
go

create or alter proc proc_deleteUser (@user nvarchar(20))
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

Create or alter proc proc_updateUser (@user varchar (20), @newPass varchar(30))
as
begin 
	declare @state varchar (200)
	set @state =' alter login '+@user+' with password = '+ ''''+@newPass+ ''''
	print (@state)
	exec (@state)
end
go
