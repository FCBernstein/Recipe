create or alter procedure dbo.CookbookGet(@CookbookId int = 0, @All bit = 0, @CookbookName varchar(50) = '')
as
begin
	select @CookbookName = nullif(@CookbookName, '')

	select cb.CookbookId, cb.UsersID, cb.CookbookName, cb.Price, cb.CBCreateDate,cb.CookbookActive
	from Cookbook cb
	where cb.CookbookId = @CookbookId
	or @All = 1
	or cb.CookbookName like '%' + @CookbookName + '%'
	order by cb.CookbookName
end
go
/*
exec CookbookGet

exec CookbookGet @All = 1

exec CookbookGet @CookbookName = '' --return no result set

exec CookbookGet @CookbookName = 'a'

declare @CookbookId int
select top 1 @CookbookId = cb.CookbookId from Cookbook cb
exec CookbookGet @CookbookId = @CookbookId
*/