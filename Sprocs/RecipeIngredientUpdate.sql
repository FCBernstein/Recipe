create or alter procedure dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int output,
    @RecipeId int,
    @IngredientId int,
    @MeasuementTypeId int,
    @Amount decimal (4,2),
    @RISequence int,
    @Message varchar (500) = '' output

)
as
begin 
    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

    if @RecipeId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, RISequence)
		values(@RecipeId, @IngredientId, @MeasuementTypeId, @Amount, @RISequence)

		select @RecipeIngredientId = scope_identity()
	end
	else
	begin
        update RecipeIngredient
        set 
            RecipeId = @RecipeId,
            IngredientId = @IngredientId,
            MeasurementTypeId = @MeasuementTypeId,
            Amount = @Amount,
            RISequence = @RISequence
            where RecipeIngredientId = @RecipeIngredientId

    end

    return @return
end 
go