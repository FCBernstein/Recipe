create or alter procedure dbo.CookbookListGet(
	@CookbookId int = 0,
	@All bit = 0, 
	@IncludeBlank bit = 0,
	@CookbookName varchar(50) = '')
as
begin
	select @CookbookName = nullif(@CookbookName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select cb.CookbookId, cb.CookbookName, Author = dbo.FullNameofUser(cb.UsersID), RecipeCount = count(cr.RecipeId), cb.Price
	from Cookbook cb
	join CookbookRecipe cr 
	on cb.CookbookId = cr.CookbookId
	join Users u 
	on cb.UsersID = u.UsersID
	where cb.CookbookId = @CookbookId
	or @All = 1
	or cb.CookbookName like '%' + @CookbookName + '%'
	group by cb.CookbookId, cb.CookbookName, cb.UsersID, cb.Price
	union select 0, '', '', 0, 0.00
	where @IncludeBlank = 1
	order by cb.CookbookName
	
end
go
/*
exec CookbookGet

exec CookbookGet @All = 1, @IncludeBlank = 1

exec CookbookGet @CookbookName = '' --return no result set

exec CookbookGet @CookbookName = 'a'

declare @CookbookId int
select top 1 @CookbookId = cb.CookbookId from Cookbook cb
exec CookbookGet @CookbookId = @CookbookId
*/