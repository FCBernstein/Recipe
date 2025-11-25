create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0, 
	@All bit = 0, 
	@IngredientName varchar(50) = ''
	)
as
begin
	declare @return int = 0 

	select @IngredientName = nullif(@IngredientName, ''), @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0)

	select i.IngredientId, i.IngredientName
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	order by i.IngredientName
end
go

/*
exec IngredientGet

exec IngredientGet @All = 1, @IncludeBlank = 1

exec IngredientGet @IngredientName = '' --return no result set

declare @IngredientId int
select top 1 @IngredientId = i.IngredientId from Ingredient i
exec IngredientGet @IngredientId = @IngredientId
*/