create or alter procedure dbo.CuisineGet(
	@CuisineId int = 0, 
	@All bit = 0, 
	@CuisineName varchar(50) = '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin
	declare @return int = 0

	select @CuisineName = nullif(@CuisineName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select c.CuisineId, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'
	union select 0, ''
	where @IncludeBlank = 1
	order by c.CuisineName

	return @return
end
go

/*
exec CuisineGet

exec CuisineGet @All = 1, @IncludeBlank = 1

exec CuisineGet @CuisineName = '' --return no result set

exec CuisineGet @CuisineName = 'a'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId
*/