create or alter procedure dbo.StepGet(@StepId int = 0, @All bit = 0, @StepDetail varchar(50) = '')
as
begin
	select @StepDetail = nullif(@StepDetail, '')

	select s.StepId, s.StepDetail
	from Step s
	where s.StepId = @StepId
	or @All = 1
	or s.StepDetail like '%' + @StepDetail + '%'
	order by s.StepDetail
end
go

/*
exec StepGet

exec StepGet @All = 1

exec StepGet @StepDetail = '' --return no result set

exec StepGet @StepDetail = 'g'

declare @StepId int
select top 1 @StepId = s.StepId from Step s
exec StepGet @StepId = @StepId
*/