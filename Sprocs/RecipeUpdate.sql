create or alter procedure dbo.RecipeUpdate(
	@RecipeId int output,
	@UsersID int,
	@RecipeName varchar (50),
	@CalorieCount int,
	@DateDrafted datetime,
	@CuisineId int,
--	@DatePublished datetime,
--	@DateArchived datetime,
	@Message varchar(500) = '' output
)
as
begin
	select @RecipeId = isnull(@RecipeId,0)

	if @RecipeId = 0
	begin
		insert Recipe(CuisineId, UsersID, RecipeName, CalorieCount, DateDrafted)
		values(@CuisineId, @UsersID, @RecipeName, @CalorieCount, @DateDrafted)

		select @RecipeId = scope_identity()
	end
	else
	begin
		update Recipe
		set 
			CuisineId = @CuisineId, 
			UsersID = @UsersID, 
			RecipeName = @RecipeName, 
			CalorieCount = @CalorieCount, 
			DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end

end
go