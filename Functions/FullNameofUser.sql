create or alter function dbo.FullNameofUser(@UsersId int)
returns varchar(150)
as
begin
	declare @value varchar(150)
	
	select @value = concat(u.UserFirstName, ' ', u.UserLastName)
	from users u
	where u.UsersId = @UsersId

	return @value
end
go

select FullName = dbo.FullNameofUser(u.UsersID), *
from Users u