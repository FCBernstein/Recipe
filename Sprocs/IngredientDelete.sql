create or alter procedure dbo.IngredientDelete(
    @IngredientId int,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0
    
    select @IngredientId = isnull(@IngredientId,0)

    delete Ingredient where IngredientId = @IngredientId

    return @return    
end
go