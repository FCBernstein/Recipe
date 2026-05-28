create or alter procedure dbo.IngredientListGet(
	@IngredientId int = 0, 
	@All bit = 0, 
	@IngredientName varchar(50) = '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin
	declare @return int = 0 

	select @IngredientName = nullif(@IngredientName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

	select i.IngredientId, i.IngredientName
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	or i.IngredientName like '%' + @IngredientName +'%'
	union select 0, ''
	where @IncludeBlank = 1
	order by i.IngredientName

	return @return
end
go

/*
exec IngredientListGet

exec IngredientListGet @All = 1, @IncludeBlank = 1

exec IngredientListGet @IngredientName = '' --return no result set

declare @IngredientId int
select top 1 @IngredientId = i.IngredientId from Ingredient i
exec IngredientListGet @IngredientId = @IngredientId
*/