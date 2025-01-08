create or alter procedure dbo.UsersGet(@UsersId int = 0, @All bit = 0, @UserName varchar(50) = '')
as
begin
	select @UserName = nullif(@UserName, '')

	select u.UsersId, u.UserFirstName, u.UserLastName, u.UserName
	from Users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.UserName like '%' + @UserName + '%'
	order by u.UserName
end
go

/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = '' --return no result set

exec UsersGet @UserName = 'a'

declare @UsersId int
select top 1 @UsersId = u.UsersId from Users u
exec UsersGet @UsersId = @UsersId
*/