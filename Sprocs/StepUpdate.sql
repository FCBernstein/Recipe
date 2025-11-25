create or alter procedure dbo.StepUpdate(
	@StepId int output,
	@RecipeId int,
	@StepDetail varchar(1000) = '',
	@StepSequence int,
    @Message varchar(500) = '' output
	)
as
begin
	declare @return int = 0

    select @StepId = isnull(@StepId, 0), @RecipeId = isnull(@RecipeId, 0)

	if @StepId = 0
	begin
		insert Step(RecipeId, StepDetail, StepSequence)
		values(@RecipeId, @StepDetail, @StepSequence)

		select @StepId = scope_identity()
	end
	else
	begin
		update Step
		set
			RecipeId = @RecipeId, 
			StepDetail = @StepDetail,
			StepSequence = @StepSequence
		where StepId = @StepId
	end
	
	return @return
end
go