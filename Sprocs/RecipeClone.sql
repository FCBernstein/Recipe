create or alter procedure dbo.RecipeClone(
	@RecipeId int output,
	@ClonedRecipeId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	select @RecipeId = isnull(@RecipeId,0)

	begin try
		begin tran
		insert Recipe(CuisineId, UsersID, RecipeName, CalorieCount, DateDrafted)
		select r.CuisineId, r.UsersID, concat(r.RecipeName,' - clone'), r.CalorieCount, GETDATE()
		from Recipe r 
		where r.RecipeId = @RecipeId

		select @ClonedRecipeId = SCOPE_IDENTITY();
		
		;
		with x as(
		select ri.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Amount, ri.RISequence, r.RecipeName
		from RecipeIngredient ri 
		join Recipe r 
		on ri.RecipeId = r.RecipeId
		where r.RecipeId = @RecipeId
		)

		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, RISequence)
		select r.RecipeId, x.IngredientId, x.MeasurementTypeId, x.Amount, x.RISequence
		from x
		cross join Recipe r
		where r.RecipeId = @ClonedRecipeId


		;
		with x as(
		select s.RecipeId, s.StepSequence, s.StepDetail, r.RecipeName
		from Step s
		join Recipe r 
		on s.RecipeId = r.RecipeId
		where r.RecipeId = @RecipeId
		)

		insert Step(RecipeId, StepSequence, StepDetail)
		select r.RecipeId, x.StepSequence, x.StepDetail
		from x
		cross join Recipe r
		where r.RecipeId = @ClonedRecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go