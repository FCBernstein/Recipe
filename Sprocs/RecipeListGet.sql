create or alter procedure dbo.RecipeListGet(
	@RecipeId int = 0, 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@SecondSortCol bit = 0,
	@RecipeName varchar(50) = ''
	)
as
begin
	select @RecipeName = nullif(@RecipeName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select *
	from (
	select r.RecipeId, r.RecipeName, r.RecipeStatus, NameofUser = dbo.FullNameofUser(r.UsersId), r.CalorieCount, NumIngredients = dbo.NumIngPerRecipe(r.RecipeId)
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	union select 0, ' ', ' ',' ', 0, 0
	where @IncludeBlank = 1
	) as RecipeList
	order by 
		case when @IncludeBlank = 0 then RecipeStatus end desc,
		case when @IncludeBlank = 1 then RecipeName end,
		case when @SecondSortCol = 0 then RecipeName end,
		RecipeId;
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