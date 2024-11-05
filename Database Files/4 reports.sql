-- SM Excellent work! 100% See comments, no need to resubmit.
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/
use HeartyHearthDB
go 
/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Category = 'Recipes', Amount = count(r.RecipeId) from Recipe r 
union select 'Meals', count(m.MealId) from Meal m
union select 'Cookbooks', count(c.CookbookId) from Cookbook c


/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
;
with x as(
    select IngCount = count(ri.IngredientId), ri.RecipeId
    from RecipeIngredient ri
    group by ri.RecipeId
)

select RecipeName = case
         when r.RecipeStatus = 'Archived' 
         then '<span style="color:gray">' + r.RecipeName + '</span>' 
         else r.RecipeName 
         end, 
    r.RecipeStatus, DatePublished = isnull(convert(varchar,r.DatePublished,101),''), DateArchived = isnull(convert(varchar,r.DateArchived,101),''), CreatedBy = concat(u.UserFirstName,' ', u.UserLastName), r.CalorieCount, x.IngCount
from x
join Recipe r
on x.RecipeId = r.RecipeId
join Users u 
on r.UsersID = u.UsersID
where r.RecipeStatus in ('Published','Archived')
order by r.RecipeStatus desc, r.RecipeName

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a)
select r.RecipeName, r.CalorieCount, IngredientCount = count(distinct ri.RecipeIngredientId), StepCount = count(distinct s.StepId)
from Step s 
join Recipe r 
on s.RecipeId = r.RecipeId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Sweet Potato Chips'
group by r.RecipeName, r.CalorieCount

--b) FCB I did slightly different than instructions indicate, because it wouldn't make sense to have 'to taste'or 'as needed' (measurement types) and then ingredient name for ingredients without amounts
select IngredientList = case 
        when ri.Amount is null 
        then concat(i.IngredientName, ' ', m.MeasurementTypeName) 
        else concat(ri.Amount, ' ', m.MeasurementTypeName, ' ', i.IngredientName) 
        end
from Recipe r
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
join MeasurementType m 
on m.MeasurementTypeId = ri.MeasurementTypeId
where r.RecipeName = 'Sweet Potato Chips'
order by ri.RISequence
--c)
select s.StepDetail 
from Recipe r 
join Step s 
on r.RecipeId = s.RecipeId
where r.RecipeName = 'Sweet Potato Chips'
order by s.StepSequence
/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
;

select m.MealName, CreatedBy = concat(u.UserFirstName,' ', u.UserLastName), CalorieCount = sum(r.CalorieCount), CourseCount = count(distinct mc.CourseId), RecipeCount = count(distinct mcr.RecipeId)
from Meal m
join MealCourse mc 
on mc.MealId= m.MealId
join MealCourseRecipe mcr 
on mcr.MealCourseId = mc.MealCourseId 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join Users u 
on m.UsersID = u.UsersID
where m.MealActive = 1
group by m.MealName, concat(u.UserFirstName,' ', u.UserLastName), m.MealActive
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a)
select m.MealName, u.UserFirstName, u.UserLastName, m.MCreateDate
from Meal m 
join Users u 
on m.UsersID = u.UsersID
where m.MealName = 'Signature Family Anniversary Dinner'
--b)
-- SM Tip: Use one concat() with case in it. And use nested case.
--FCB I might be missing something basic here, but this was the only way I was able to get it to work and if this is actually what you had in mind, I dont understand why my original answer wasn't simpler code
-- I think that one case and three concats is easier to read/follow than one concat with three cases (four, if you include the nested case)

-- SM Depends how you look at it. In my understanding this code will be better for performance than the previous one (maybe I'm wrong with this as I'm not a DBA).
-- One way I look at it that makes it more readable this way is with the following Q&A.
-- 1) What does this column return? A concat().
-- 2) What's the values being passed into the concat()? Well, the basic values are course: recipe. But there are more for different scenarios.
-- 3) What are the different scenarios? Oh, if the recipe is a main dish in the main course we need to wrap it in b tags.
-- 4) Any other special instructions? Yes, if it's the main course we need to know if it's main or side dish.
-- In my opinion if you look at it in this way, this way will be more readable than the old way.
-- You have the full rights to disagree with me, and that's why I just added it as a tip.
select RecipeList = concat(
    case 
    when c.CourseName = 'Main' and mcr.MainDish = 1
    then '<b>' 
    --else '' end, -- SM No need for else. This will return null and concat() will treat it as ''
    c.CourseName,': ', 
    case 
    when c.CourseName = 'Main' 
    then 
        case mcr.MainDish
        when 1 
        then 'Main' -- SM I would do here like this case mcr.MainDish when 1 then 'Main' else 'Side' end + ' dish - '
        else 'Side' 
        end + ' dish - '
    --else '' -- SM No need for else. This will return null and concat() will treat it as ''
    end, 
    r.RecipeName, 
    case 
    when c.CourseName = 'Main' and mcr.MainDish = 1
    then '</b>' 
   -- else '' -- SM No need for else. This will return null and concat() will treat it as ''
    end
)
from Meal m 
join MealCourse mc 
on mc.MealId= m.MealId
join MealCourseRecipe mcr 
on mcr.MealCourseId = mc.MealCourseId 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join Course c 
on mc.CourseId = c.CourseId
where m.MealName = 'Signature Family Anniversary Dinner'
order by c.CourseSequence, r.RecipeName

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, Author = concat(u.UserFirstName,' ', u.UserLastName), RecipeCount = count(cr.RecipeId)
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Users u 
on c.UsersID = u.UsersID
where c.CookbookActive = 1
group by c.CookbookName, concat(u.UserFirstName,' ', u.UserLastName), c.CookbookActive
order by c.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a)
select c.CookbookName, Author = concat(u.UserFirstName,' ', u.UserLastName), c.CBCreateDate, c.Price, RecipeCount = count(cr.RecipeId)
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Users u 
on c.UsersID = u.UsersID
where c.CookbookName = 'Mom''s Kitchen'
group by c.CookbookName, concat(u.UserFirstName,' ', u.UserLastName), c.CBCreateDate, c.Price
--b)
select r.RecipeName, n.CuisineName, IngredientCount = count(distinct ri.RISequence), StepCount = count(distinct s.StepSequence)
from Recipe r
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId
join Cookbook c  
on c.CookbookId = cr.CookbookId
join Cuisine n 
on r.CuisineId = n.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Step s
on r.RecipeId = s.RecipeId
where c.CookbookName = 'Mom''s Kitchen'
group by r.RecipeName, n.CuisineName, c.CookbookName, cr.CBRSequence
order by cr.CBRSequence


/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a)
select RecipeName = upper(substring(reverse(r.RecipeName),1,1)) + lower(substring(reverse(r.RecipeName),2,len(r.RecipeName))), 
    RecipeImage = 'Recipe_' + replace(upper(substring(reverse(r.RecipeName),1,1)) + lower(substring(reverse(r.RecipeName),2,len(r.RecipeName))), ' ', '_') + '.jpg'
from Recipe r 

--b)
;
with x as(
    select  LastStep = max(s.StepSequence), s.RecipeId, r.RecipeName
    from Step s 
    join Recipe r 
    on s.RecipeId = r.RecipeId
    group by s.RecipeId, r.RecipeName
)

select s.StepDetail
from x 
join step s 
on x.RecipeId = s.RecipeId
where s.StepSequence = x.LastStep


/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a)
select u.UserName, RecipeStatus = isnull(r.RecipeStatus, 'N/A'), Amount = count(r.RecipeStatus)
from Users u 
left join Recipe r
on r.UsersID = u.UsersID
group by r.RecipeStatus, u.UserName

--b)
;
with x as(
    select u.UsersID, AmountRecipe = count(r.RecipeId)
    from Users u 
    join Recipe r
    on u.UsersID = r.UsersID
    group by u.UsersID
)

select r.UsersID, x.AmountRecipe, AverageDays = avg(DATEDIFF(day, r.DateDrafted, r.DatePublished))
from x
join Recipe r 
on x.UsersID = r.UsersID
where r.DatePublished is not null
group by r.UsersID, x.AmountRecipe

--c)
select u.UserName, TotalMeals = count(m.UsersID), TotalActive = sum(case m.MealActive when 1 then 1 else 0 end), TotalInactive = sum(case m.MealActive when 0 then 1 else 0 end)
from Users u 
left join Meal m 
on u.UsersID = m.UsersID
group by u.UserName

--d)
select u.UserName, TotalCookbooks = count(c.UsersID), TotalActive = sum(case c.CookbookActive when 1 then 1 else 0 end), TotalInactive = sum(case c.CookbookActive when 0 then 1 else 0 end)
from Users u 
left join Cookbook c 
on u.UsersID = c.UsersID
group by u.UserName

--e)
select r.RecipeName, r.RecipeStatus, DaysUntilArchived = DATEDIFF(day, r.DateDrafted, r.DateArchived)
from Recipe r 
where r.RecipeStatus = 'Archived' and r.DatePublished is null 

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
--a)
select Category = 'Recipes', Amount = count(r.RecipeId) 
    from Users u 
    join Recipe r 
    on u.UsersID = r.UsersID
where u.UserName = 'SusFish6576!'
union select 'Meals', count(m.MealId) 
    from Users u 
    join Meal m 
    on u.UsersID = m.UsersID
where u.UserName = 'SusFish6576!'
union select 'Cookbooks', count(c.CookbookId) 
    from Users u 
    join Cookbook c 
    on u.UsersID = c.UsersID
where u.UserName = 'SusFish6576!'

--b)
-- SM This should be hours. And I think here you'll definitely agree that this is more readable than before.
select r.RecipeName, r.RecipeStatus, DaysUntilPublishedOrArchived = DATEDIFF(hour, case r.RecipeStatus 
                                                                    when 'Published' then  r.DateDrafted 
                                                                    when 'Archived' then isnull(r.DatePublished, r.DateDrafted)
																	-- SM No need for second isnull() this will never return drafted.
                                                                    end, isnull(r.DateArchived, r.DatePublished))
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
where u.UserName = 'SusFish6576!' and r.RecipeStatus <> 'Draft'

--c)
-- SM Excellent!
with x as(
    select r.RecipeName, c.CuisineName
    from Cuisine c 
    join Recipe r
    on c.CuisineId = r.CuisineId
    join Users u
    on u.UsersID = r.UsersID
    where u.UserName = 'SusFish6576!'
)

select c.CuisineName, AmountCuisine = count(x.RecipeName)
from Cuisine c 
left join x 
on c.CuisineName = x.CuisineName
group by c.CuisineName
