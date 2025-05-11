create or alter procedure dbo.RecipeDelete(
	@RecipeId int 
	)
as
begin
	begin try
		begin tran
		delete Step where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

end
go

/*
declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
left join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
left join Step s
on r.RecipeId = s.RecipeId
left join CookbookRecipe cbr
on cbr.RecipeId = r.RecipeId
left join Cookbook cb
on cbr.CookbookId = cb.CookbookId
left join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
left join MealCourse mc
on mcr.MealCourseId = mc.MealCourseId
left join Meal m
on mc.MealId = m.MealId
where cbr.RecipeId is null
and mcr.RecipeId is null
order by r.RecipeId

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.RecipeIngredientId, concat(ri.Amount, ' ', ri.MeasurementTypeId) from RecipeIngredient ri where ri.RecipeId = @RecipeId
union select 'Step', s.StepId, s.StepDetail from Step s where s.RecipeId = @RecipeId
union select 'CookBook', cbr.CookbookId, cb.CookbookName from CookbookRecipe cbr join Cookbook cb on cb.CookbookId = cbr.CookbookId where cbr.RecipeId = @RecipeId
union select 'Meal', mc.MealId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.RecipeIngredientId, concat(ri.Amount, ' ', ri.MeasurementTypeId) from RecipeIngredient ri where ri.RecipeId = @RecipeId
union select 'Step', s.StepId, s.StepDetail from Step s where s.RecipeId = @RecipeId
union select 'CookBook', cbr.CookbookId, cb.CookbookName from CookbookRecipe cbr join Cookbook cb on cb.CookbookId = cbr.CookbookId where cbr.RecipeId = @RecipeId
union select 'Meal', mc.MealId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

*/