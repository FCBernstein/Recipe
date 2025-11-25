create or alter procedure dbo.MeasurementTypeDelete(
    @MeasurementTypeId int,
    @Message varchar (500) = '' output
)
as 
begin 
    declare @return int = 0
    
    select @MeasurementTypeId = isnull(@MeasurementTypeId,0)

    delete MeasurementType where MeasurementTypeId = @MeasurementTypeId

    return @return    
end
go