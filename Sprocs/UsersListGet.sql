create or alter procedure dbo.UsersListGet(
	@UsersId int = 0, 
	@All bit = 0, 
	@UserName varchar(50) = '',
	@IncludeBlank bit = 0)
as
begin
	select @UserName = nullif(@UserName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select u.UsersId, u.UserFirstName, u.UserLastName, u.UserName, 'User' = dbo.FullNameofUser(u.UsersId)
	from Users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.UserName like '%' + @UserName + '%'
	union select 0, '','','',''
	where @IncludeBlank = 1
	order by 'User'
end
go

/*
exec UsersGet

exec UsersGet @All = 1, @IncludeBlank = 1

exec UsersGet @UserName = '' --return no result set

exec UsersGet @UserName = 'a'

declare @UsersId int
select top 1 @UsersId = u.UsersId from Users u
exec UsersGet @UsersId = @UsersId
*/