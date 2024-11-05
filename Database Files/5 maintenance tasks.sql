-- SM Excellent! 100%
use HeartyHearthDB
go

--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete cr
from CookbookRecipe cr 
join Cookbook c
on cr.CookbookId = c.CookbookId
join Recipe r 
on cr.RecipeId = r.RecipeId
join Users u 
on c.UsersID = u.UsersID
or r.UsersID = u.UsersID
where u.UserName = 'Malks69'

delete c
from Cookbook c
join Users u 
on c.UsersID = u.UsersID
where u.UserName = 'Malks69'

delete mcr
from MealCourseRecipe mcr
join Recipe r 
on mcr.RecipeId = r.RecipeId
join MealCourse mc 
on mc.MealCourseId = mcr.MealCourseId
join Meal m 
on m.MealId = mc.MealId
join Users u
on u.UsersID = m.UsersID
or u.UsersID = r.UsersID
where u.UserName = 'Malks69'

delete mc
from Users u 
join Meal m
on m.UsersID = u.UsersID
join MealCourse mc
on m.MealId = mc.MealId
where u.UserName = 'Malks69'

delete m
from Users u 
join Meal m
on m.UsersID = u.UsersID
where u.UserName = 'Malks69'

delete s
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Step s 
on r.RecipeId = s.RecipeId
where u.UserName = 'Malks69'

delete ri
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where u.UserName = 'Malks69'

delete r
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
where u.UserName = 'Malks69'

delete u
from Users u 
where u.UserName = 'Malks69'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified 
--version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(CuisineId, UsersID, RecipeName, CalorieCount, DateDrafted)
select r.CuisineId, r.UsersID, concat(r.RecipeName,' - clone'), r.CalorieCount, GETDATE()
from Recipe r 
where r.RecipeName = 'Sesame Chicken'
go

;
with x as(
	select ri.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Amount, ri.RISequence, r.RecipeName
	from RecipeIngredient ri 
	join Recipe r 
	on ri.RecipeId = r.RecipeId
	where r.RecipeName = 'Sesame Chicken'
)

insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, RISequence)
select r.RecipeId, x.IngredientId, x.MeasurementTypeId, x.Amount, x.RISequence
from x
cross join Recipe r
where r.RecipeName = Concat(x.RecipeName, ' - clone')
go

;
with x as(
	select s.RecipeId, s.StepSequence, s.StepDetail, r.RecipeName
	from Step s
	join Recipe r 
	on s.RecipeId = r.RecipeId
	where r.RecipeName = 'Sesame Chicken'
)

insert Step(RecipeId, StepSequence, StepDetail)
select r.RecipeId, x.StepSequence, x.StepDetail
from x
cross join Recipe r
where r.RecipeName = Concat(x.RecipeName, ' - clone')
go
/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
	select u.UserName, NumRecipes = count(r.RecipeId)
	from Users u 
	join Recipe r 
	on u.UsersID = r.UsersID
	where u.UserName = 'gl1000'
	group by u.UserName
)


insert Cookbook(UsersID, CookbookName, Price)
select u.UsersID, concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), x.NumRecipes*1.33
from x
join Users U 
on x.UserName = u.UserName
go 

insert CookbookRecipe(CookbookId, RecipeId, CBRSequence)
select c.CookbookId, r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
cross join Cookbook c
where u.UserName = 'gl1000' and c.CookbookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName)

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r
set CalorieCount = case m.MeasurementTypeName
						when 'oz' then r.CalorieCount - (ri.Amount*2)
						when 'stick' then r.CalorieCount - (ri.Amount*10)
						when 'tbsp' then r.CalorieCount - (ri.Amount*4)
						else r.CalorieCount
						end
from Recipe r
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient i 
on i.IngredientId = ri.IngredientId
join MeasurementType m
on m.MeasurementTypeId = ri.MeasurementTypeId
where i.IngredientName = 'butter'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
	select 
	AvgHours = avg(DATEDIFF(hour, r.DateDrafted, isnull(r.DatePublished, getdate())))
	from Recipe r
)

select u.UserFirstName, u.UserLastName, EmailAddress = concat(substring(u.UserFirstName,1,1),u.UserLastName,'@heartyhearth.com'), AlertText = concat('Alert: 
		Your recipe ', r.RecipeName, ' is sitting in draft for ', DATEDIFF(hour, r.DateDrafted, isnull(r.DatePublished, getdate())), ' hours.
		That is ', DATEDIFF(hour, r.DateDrafted, isnull(r.DatePublished, getdate())) - x.AvgHours, ' hours more than the average ', x.AvgHours, ' hours all other recipes took to be published.')
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join x
on DATEDIFF(hour, r.DateDrafted, isnull(r.DatePublished, getdate())) > x.AvgHours 
	and r.RecipeStatus = 'Draft'

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/

select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(c.CookbookId), ' books for sale, average price is $', cast (avg(c.Price) as decimal(5,2)), '. 
You can order them all and receive a 25% discount, for a total of $', sum(c.Price) - sum(c.Price)*.25, '.
Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from Cookbook c
