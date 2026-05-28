create or alter procedure dbo.MealGet(@MealId int = 0, @All bit = 0, @MealName varchar(50) = '')
as
begin
	select @MealName = nullif(@MealName, '')

	select m.MealId, m.MealName, NameofUser = dbo.FullNameofUser(m.UsersID), CalorieCount = dbo.CaloriesPerMeal(m.MealId), CourseCount = count(distinct mc.CourseId), RecipeCount = count(distinct mcr.RecipeId)
	from Meal m
	join MealCourse mc 
	on mc.MealId= m.MealId
	join MealCourseRecipe mcr 
	on mcr.MealCourseId = mc.MealCourseId 
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	join Users u 
	on m.UsersID = u.UsersID
	where m.MealId = @MealId
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
	group by m.MealId, m.MealName, m.UsersId
	order by m.MealName
end
go
/*
exec MealGet

exec MealGet @All = 1

exec MealGet @MealName = '' --return no result set

exec MealGet @MealName = 'p'

declare @MealId int
select top 1 @MealId = m.MealId from Meal m
exec MealGet @MealId = @MealId
*/