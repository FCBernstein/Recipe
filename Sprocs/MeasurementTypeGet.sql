create or alter procedure dbo.MeasurementTypeGet(@MeasurementTypeId int = 0, @All bit = 0, @MeasurementTypeName varchar(50) = '')
as
begin
	select @MeasurementTypeName = nullif(@MeasurementTypeName, '')

	select mt.MeasurementTypeId, mt.MeasurementTypeName
	from MeasurementType mt
	where mt.MeasurementTypeId = @MeasurementTypeId
	or @All = 1
	or mt.MeasurementTypeName like '%' + @MeasurementTypeName + '%'
	order by mt.MeasurementTypeName
end
go

/*
exec MeasurementTypeGet

exec MeasurementTypeGet @All = 1

exec MeasurementTypeGet @MeasurementTypeName = '' --return no result set

exec MeasurementTypeGet @MeasurementTypeName = 'a'

declare @MeasurementTypeId int
select top 1 @MeasurementTypeId = mt.MeasurementTypeId from MeasurementType mt
exec MeasurementTypeGet @MeasurementTypeId = @MeasurementTypeId
*/