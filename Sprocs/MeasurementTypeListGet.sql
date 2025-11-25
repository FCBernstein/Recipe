create or alter procedure dbo.MeasurementTypeListGet(
	@MeasurementTypeId int = 0, 
	@All bit = 0, 
	@MeasurementTypeName varchar(50) = '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin
	declare @return int = 0

	select @MeasurementTypeName = nullif(@MeasurementTypeName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select mt.MeasurementTypeId, mt.MeasurementTypeName
	from MeasurementType mt
	where mt.MeasurementTypeId = @MeasurementTypeId
	or @All = 1
	or mt.MeasurementTypeName like '%' + @MeasurementTypeName + '%'
	union select 0, ''
	where @IncludeBlank = 1
	order by mt.MeasurementTypeName

	return @return
end
go

/*
exec MeasurementTypeGet

exec MeasurementTypeGet @All = 1, @IncludeBlank = 1

exec MeasurementTypeGet @MeasurementTypeName = '' --return no result set

exec MeasurementTypeGet @MeasurementTypeName = 'a'

declare @MeasurementTypeId int
select top 1 @MeasurementTypeId = mt.MeasurementTypeId from MeasurementType mt
exec MeasurementTypeGet @MeasurementTypeId = @MeasurementTypeId
*/