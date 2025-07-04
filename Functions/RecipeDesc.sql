create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(150)
as
begin
	declare @value varchar(150)
	;
	with x as(
		select r.RecipeId, 
		IngCount = (select count(*) from RecipeIngredient ri where ri.RecipeId = r.RecipeId),
		StepCount = (select count(*) from Step s where s.RecipeId = r.RecipeId)
		from Recipe r
		)

	select @value = concat(r.RecipeName, ' (', c.CuisineName, ') has ', x.IngCount, ' ingredients and ', x.StepCount, ' steps')
	from x
	join Recipe r
	on x.RecipeId = r.RecipeId
	join Cuisine c
	on c.CuisineId = r.CuisineId
	where r.RecipeId = @RecipeId

	return @value
end
go

select RecicpeDesc = dbo.RecipeDesc(r.RecipeId), *
from Recipe r
join Cuisine c
on c.CuisineId = r.CuisineId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Step s
on r.RecipeId = s.RecipeId