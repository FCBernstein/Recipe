create or alter procedure dbo.RecipeStepGet(
	@RecipeId int = 0, 
	@All bit = 0, 
	@StepDetail varchar(50) = ''
	)
as
begin
	select @StepDetail = nullif(@StepDetail, '')

	select s.StepId, s.StepDetail, s.StepSequence, s.RecipeId
	from Recipe r 
	join Step s 
	on r.RecipeId = s.RecipeId
	where r.RecipeId = @RecipeId
	or @All = 1
	or s.StepDetail like '%' + @StepDetail + '%'
	order by s.StepSequence
end
go

/*
exec RecipeStepGet

exec RecipeStepGet @All = 1

exec RecipeStepGet @StepDetail = '' --return no result set

exec RecipeStepGet @StepDetail = 'g'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeStepGet @RecipeId = @RecipeId, @IncludeBlank = 1
*/