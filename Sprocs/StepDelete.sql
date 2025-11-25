create or alter procedure dbo.StepDelete(
    @StepId int,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0
    
    select @StepId = isnull(@StepId,0)

    delete Step where StepId = @StepId

    return @return    
end
go