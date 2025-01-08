create or alter procedure dbo.MealGet(@MealId int = 0, @All bit = 0, @MealName varchar(50) = '')
as
begin
	select @MealName = nullif(@MealName, '')

	select m.MealId, m.UsersID, m.MealName, m.MCreateDate, m.MealActive
	from Meal m
	where m.MealId = @MealId
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
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