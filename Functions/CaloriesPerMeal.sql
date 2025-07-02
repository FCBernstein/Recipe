create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.CalorieCount)
	from Meal m
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealCourseRecipe mcr
	on mc.MealCourseId = mcr.MealCourseId
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId
	group by m.MealId

	return @value
end
go
select MCalorieCount = dbo.CaloriesPerMeal(m.MealId), *
from Meal m
