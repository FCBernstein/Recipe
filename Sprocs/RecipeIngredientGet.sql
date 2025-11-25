create or alter procedure dbo.RecipeIngredientGet(
	@RecipeId int = 0, 
	@All bit = 0, 
	@RecipeName varchar(50) = ''
	)
as
begin
	select @RecipeName = nullif(@RecipeName, '')

	select ri.RISequence, ri.Amount, m.MeasurementTypeId, i.IngredientId
	from Recipe r 
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId 
	join Ingredient i 
	on ri.IngredientId = i.IngredientId 
	join MeasurementType m 
	on m.MeasurementTypeId = ri.MeasurementTypeId 
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	order by ri.RISequence
end
go

/*
exec RecipeIngredientGet

exec RecipeIngredientGet @All = 1, @IncludeBlank = 1

exec RecipeIngredientGet @RecipeName = '' --return no result set

exec RecipeIngredientGet @RecipeName = 'Sweet Potato'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeIngredientGet @RecipeId = @RecipeId

*/