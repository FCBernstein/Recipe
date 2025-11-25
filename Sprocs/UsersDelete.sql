create or alter procedure dbo.UsersDelete(
    @UsersId int,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0

    begin try
		begin tran
		    delete cr
            from CookbookRecipe cr 
            join Cookbook c
            on cr.CookbookId = c.CookbookId
            join Recipe r 
            on cr.RecipeId = r.RecipeId
            join Users u 
            on c.UsersID = u.UsersID
            or r.UsersID = u.UsersID
            where u.UsersID = @UsersId

            delete c
            from Cookbook c
            join Users u 
            on c.UsersID = u.UsersID
            where u.UsersID = @UsersId

            delete mcr
            from MealCourseRecipe mcr
            join Recipe r 
            on mcr.RecipeId = r.RecipeId
            join MealCourse mc 
            on mc.MealCourseId = mcr.MealCourseId
            join Meal m 
            on m.MealId = mc.MealId
            join Users u
            on u.UsersID = m.UsersID
            or u.UsersID = r.UsersID
            where u.UsersID = @UsersId

            delete mc
            from Users u 
            join Meal m
            on m.UsersID = u.UsersID
            join MealCourse mc
            on m.MealId = mc.MealId
            where u.UsersID = @UsersId

            delete m
            from Users u 
            join Meal m
            on m.UsersID = u.UsersID
            where u.UsersID = @UsersId

            delete s
            from Users u 
            join Recipe r 
            on u.UsersID = r.UsersID
            join RecipeIngredient ri 
            on r.RecipeId = ri.RecipeId
            join Step s 
            on r.RecipeId = s.RecipeId
            where u.UsersID = @UsersId

            delete ri
            from Users u 
            join Recipe r 
            on u.UsersID = r.UsersID
            join RecipeIngredient ri 
            on r.RecipeId = ri.RecipeId
            where u.UsersID = @UsersId

            delete r
            from Users u 
            join Recipe r 
            on u.UsersID = r.UsersID
            where u.UsersID = @UsersId

            delete u
            from Users u 
            where u.UsersID = @UsersId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

    return @return
end 
go
