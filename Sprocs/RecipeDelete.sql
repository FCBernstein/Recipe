create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar (500) = '' output
	)
as
begin
	declare @return int = 0
	if exists (select * from Recipe r where r.RecipeId = @RecipeId and (r.RecipeStatus = 'Published' or DateDiff(day, r.DateArchived, getdate()) < 30))
	begin
		select @return = 1, @Message = 'Cannot delete recipe because it is Published or in archive for 30 days or less.'
		goto finished
	end

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

	finished:
	return @return

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
and (r.RecipeStatus = 'Published' or DateDiff(day, r.DateArchived, getdate()) < 30)
order by r.RecipeId

select 'Recipe', r.RecipeId, Info= concat(r.RecipeName, ' ', r.RecipeStatus) from Recipe r where r.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.RecipeIngredientId, concat(ri.Amount, ' ', ri.MeasurementTypeId) from RecipeIngredient ri where ri.RecipeId = @RecipeId
union select 'Step', s.StepId, s.StepDetail from Step s where s.RecipeId = @RecipeId
union select 'CookBook', cbr.CookbookId, cb.CookbookName from CookbookRecipe cbr join Cookbook cb on cb.CookbookId = cbr.CookbookId where cbr.RecipeId = @RecipeId
union select 'Meal', mc.MealId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

declare @return int, @message varchar (500)
exec @return = RecipeDelete @RecipeId = @RecipeId, @Message = @message output

select @return, @message

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'RecipeIngredient', ri.RecipeIngredientId, concat(ri.Amount, ' ', ri.MeasurementTypeId) from RecipeIngredient ri where ri.RecipeId = @RecipeId
union select 'Step', s.StepId, s.StepDetail from Step s where s.RecipeId = @RecipeId
union select 'CookBook', cbr.CookbookId, cb.CookbookName from CookbookRecipe cbr join Cookbook cb on cb.CookbookId = cbr.CookbookId where cbr.RecipeId = @RecipeId
union select 'Meal', mc.MealId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

*/