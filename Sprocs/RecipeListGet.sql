create or alter procedure dbo.RecipeListGet(
	@RecipeId int = 0, 
	@All bit = 0, 
	@RecipeName varchar(50) = ''
	)
as
begin
	select @RecipeName = nullif(@RecipeName, '')

	select r.RecipeId, r.RecipeName, r.RecipeStatus, NameofUser = dbo.FullNameofUser(r.UsersId), r.CalorieCount, NumIngredients = dbo.NumIngPerRecipe(r.RecipeId)
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	order by r.RecipeStatus desc, r.RecipeName
end
go

/*
exec RecipeListGet

exec RecipeListGet @All = 1, @IncludeBlank = 1

exec RecipeListGet @RecipeName = '' --return no result set

exec RecipeListGet @RecipeName = 'a'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeListGet @RecipeId = @RecipeId
*/