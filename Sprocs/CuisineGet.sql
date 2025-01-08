create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineName varchar(50) = '')
as
begin
	select @CuisineName = nullif(@CuisineName, '')

	select c.CuisineId, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'
	order by c.CuisineName
end
go

/*
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineName = '' --return no result set

exec CuisineGet @CuisineName = 'a'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId
*/