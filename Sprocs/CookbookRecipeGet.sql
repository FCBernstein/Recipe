create or alter procedure dbo.CookbookRecipeGet(
	@CookbookId int = 0,
	@All bit = 0, 
	@CookbookName varchar(50) = '')
as
begin
	select @CookbookName = nullif(@CookbookName, '')

	select cb.CookbookId, r.RecipeId, r.RecipeName, cbr.CBRSequence
	from Cookbook cb
	join CookbookRecipe cbr
	on cb.CookbookId = cbr.CookbookId
	join Recipe r
	on cbr.RecipeId = r.RecipeId
	where cb.CookbookId = @CookbookId
	or @All = 1
	or cb.CookbookName like '%' + @CookbookName + '%'
	order by cbr.CBRSequence
	
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