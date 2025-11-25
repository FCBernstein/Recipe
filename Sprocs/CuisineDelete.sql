create or alter procedure dbo.CuisineDelete(
    @CuisineId int,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0
    
    select @CuisineId = isnull(@CuisineId,0)

    delete Cuisine where CuisineId = @CuisineId

    return @return    
end
go