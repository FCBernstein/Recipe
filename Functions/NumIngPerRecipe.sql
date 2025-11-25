create or alter function dbo.NumIngPerRecipe(@RecipeId int)
returns int
as
begin
	declare @value int

	select @value = count(*)
	from RecipeIngredient ri
	join Recipe r
	on ri.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId

	return @value
end
go

select RecicpeDesc = dbo.NumIngPerRecipe(r.RecipeId), *
from Recipe r
