-- SM Excellent!
Use HeartyHearthDB
go

delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete Course 
delete Step 
delete RecipeIngredient
delete Recipe 
delete Users 
delete MeasurementType
delete Ingredient 
delete Cuisine
go  

insert Cuisine(CuisineName)
      select 'American'
union select 'British'
union select 'Chinese'
union select 'French'
union select 'Greek'
union select 'Indian'
union select 'Italian'
union select 'Moroccan'
union select 'Israeli'
union select 'Russian'
union select 'Mediterranean'
union select 'Zero Calorie'
go 

insert Ingredient(IngredientName)
      select 'eggs'
union select 'egg'
union select 'sugar'
union select 'oil'
union select 'flour'
union select 'salt'
union select 'water'
union select 'baking soda'
union select 'baking powder'
union select 'brown sugar'
union select 'corn starch'
union select 'corn syrup'
union select 'confectionary sugar'
union select 'cocoa'
union select 'vanilla extract'
union select 'vanilla sugar'
union select 'coffee'
union select 'chocolate chips'
union select 'yeast'
union select 'whip cream'
union select 'milk'
union select 'heavy cream'
union select 'cinnamon'
union select 'butter'
union select 'margarine'
union select 'strawberries'
union select 'blueberries'
union select 'cranberries'
union select 'chicken'
union select 'minute steak'
union select 'honey'
union select 'onion powder'
union select 'garlic powder'
union select 'paprika'
union select 'black pepper'
union select 'potatoes'
union select 'onions'
union select 'butternut squash'
union select 'zucchini'
union select 'sweet potato'
union select 'sweet potatoes'
union select 'parmesan cheese'
union select 'shredded cheese'
union select 'cottage cheese'
union select 'cream cheese'
union select 'sour cream'
union select 'pasta sauce'
union select 'vodka sauce'
union select 'ketchup'
union select 'mustard'
union select 'vinager'
union select 'carrots'
union select 'franks'
union select 'red currant jelly'
union select 'spicy brown mustard'
union select 'puff pastry squares'
union select 'portobello mushroom'
union select 'sesame seeds'
union select 'minced garlic'
union select 'basil'
union select 'thyme'
union select 'salt and pepper'
union select 'celery'
union select 'shredded cabbage'
union select 'marjoram'
union select 'cumin'
union select 'bread'
union select 'pineapple juice'
union select 'crushed pineapple'
union select 'pina colada syrup'
union select 'kiwi'
union select 'noodles'
union select 'applesauce'
union select 'olive oil'
union select 'orzo'
union select 'soy sauce'
union select 'crushed red pepper'
union select 'garlic'
union select 'chicken cutlets'
union select 'apricot jam'
union select 'mayonnaise'
union select 'honey'
union select 'lemon juice'
union select 'onion soup mix'
union select 'bread crumbs'
union select 'pickled tongue'
union select 'tomatoe sauce'
union select 'orange juice'
union select 'corned beef'
union select 'ziti noodles'
union select 'tomatoe paste'
union select 'muenster cheese'
union select 'warm water'
union select 'white wine'
union select 'oats'
union select 'vanilla ice cream'
union select 'heavy cream'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'ice cubes'
union select 'club bread'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
go 

insert MeasurementType(MeasurementTypeName)
      select 'tsp'
union select 'tbsp'
union select 'cup'
union select 'cups'
union select 'oz'
union select 'lb'
union select 'can'
union select 'package'
union select 'packages'
union select 'bag'
union select 'jar'
union select 'bar'
union select 'small'
union select 'medium'
union select 'large'
union select 'extra-large'
union select 'pinch'
union select 'dash'
union select 'sprinkle'
union select 'to taste'
union select 'regular'
union select 'squares'
union select 'stalks'
union select 'slices'
union select 'cloves'
union select 'as necessary'
union select 'capful'
union select 'stick'
go 

insert Users(UserFirstName, UserLastName, UserName)
      select 'Susie', 'Fishbein', 'SusFish6576!'
union select 'Victoria', 'Dweck', 'DweckVicy01'
union select 'Miriam', 'Pascal', 'MPK2020'
union select 'Chanie', 'Nayman', 'Chan613'
union select 'Libby', 'Gold', 'gl1000'
union select 'Pessi', 'Grun', 'Pg@1648'
union select 'Malky', 'Freidman', 'Malks69'
union select 'Malky', 'Freidman', 'Mf360'
go 
;
with x as(
        select UserName = 'SusFish6576!', CuisineName = 'American', RecipeName = 'Saucy Franks', CalorieCount = 320, DateDrafted = '2002-05-17', DatePublished = '2002-05-17', DateArchived = null
    union select 'SusFish6576!', 'British', 'Potato Bourekas', 140, '2007-05-16', '2007-08-13', '2010-09-30'
    union select 'DweckVicy01', 'French', 'French Onion Soup', 180, '2000-03-02', '2000-03-02', null
    union select 'DweckVicy01', 'Mediterranean', 'Vegetable-Squash Soup', 60, '2015-12-09', '2015-12-10', null
    union select 'SusFish6576!', 'American', 'Sweet Cheese Toasts', 220, '2022-01-11', null, null
    union select 'MPK2020', 'Italian', 'Pina Colada Drink', 150, '2018-05-07', '2018-05-09', '2020-09-21'
    union select 'MPK2020', 'Israeli', 'Sweet Lokshen Kugel', 180, '2004-07-08', '2005-04-20', null
    union select 'Chan613', 'Greek', 'Sweet Potato Chips', 360, '2000-01-17', '2000-01-17', null
    union select 'Chan613', 'Moroccan', 'Spicy Orzo', 110, '2019-05-04', '2019-05-31', null
    union select 'gl1000', 'Chinese', 'Sesame Chicken', 320, '2021-02-28', '2021-03-18', null
    union select 'gl1000', 'American', 'Sweet ''N Sour Tongue', 260, '2022-01-15', '2022-01-27', null
    union select 'gl1000', 'American', 'Glazed Corned Beef', 240, '2021-11-22', '2022-02-12', null
    union select 'gl1000', 'Italian', 'Baked Ziti', 420, '2010-01-07', '2010-03-13', null
    union select 'gl1000', 'French', 'White Wine Doughnuts', 400, '2020-03-07', null, '2021-12-13'
    union select 'Pg@1648', 'British', 'Old-Fashioned Oatmeal Cookies', 260, '2003-07-21', '2003-07-21', null
    union select 'SusFish6576!', 'American', 'Thick & Rich Milkshakes', 500, '2015-03-16', '2015-03-16', null
    union select 'Malks69', 'American', 'Chocolate Chip Cookies', 150, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'French', 'Apple Yogurt Smoothie', 80, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'British', 'Cheese Bread', 250, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'American', 'Butter Muffins', 400, '2000-01-02', '2000-03-01', '2021-11-10'
)


insert Recipe(CuisineId, UsersID, RecipeName, CalorieCount, DateDrafted, DatePublished, DateArchived)
select c.CuisineId, u.UsersID, x.RecipeName, x.CalorieCount, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u 
on x.UserName = u.UserName
join Cuisine c 
on x.CuisineName = c.CuisineName
go 

;
with x as(
        select RecipeName = 'Saucy Franks', IngredientName ='franks', MeasurementTypeName = 'regular',  Amount = 6, SequenceNum =  1
    union select 'Saucy Franks', 'red currant jelly', 'jar', 1, 2
    union select 'Saucy Franks', 'spicy brown mustard', 'tbsp', 4, 3
    union select 'Potato Bourekas', 'puff pastry squares', 'squares', 12, 1
    union select 'Potato Bourekas', 'potatoes', 'medium', 3, 2
    union select 'Potato Bourekas', 'onions', 'small', 2, 3
    union select 'Potato Bourekas', 'oil', 'tbsp', 6, 4
    union select 'Potato Bourekas', 'portobello mushroom', 'medium', 1, 5
    union select 'Potato Bourekas', 'salt', 'to taste', null, 6
    union select 'Potato Bourekas', 'egg', 'extra-large', 1, 7
    union select 'Potato Bourekas', 'sesame seeds', 'sprinkle', null, 8
    union select 'French Onion Soup', 'butter', 'tbsp', 4, 1
    union select 'French Onion Soup', 'oil', 'tbsp', 2, 2
    union select 'French Onion Soup', 'onions', 'cups', 7, 3
    union select 'French Onion Soup', 'salt', 'tsp', 1, 4
    union select 'French Onion Soup', 'minced garlic', 'tbsp', 2, 5
    union select 'French Onion Soup', 'basil', 'tsp', 1, 6
    union select 'French Onion Soup', 'thyme', 'tsp', 1, 7
    union select 'French Onion Soup', 'flour', 'tbsp', 3, 8
    union select 'French Onion Soup', 'water', 'cups', 8, 9
    union select 'French Onion Soup', 'salt and pepper', 'to taste', null, 10
    union select 'Vegetable-Squash Soup', 'butternut squash', 'large', 1, 1
    union select 'Vegetable-Squash Soup', 'sweet potato', 'large', 1, 2
    union select 'Vegetable-Squash Soup', 'celery', 'stalks', 2, 3
    union select 'Vegetable-Squash Soup', 'carrots', 'medium', 3, 4
    union select 'Vegetable-Squash Soup', 'shredded cabbage', 'cup', 1, 5
    union select 'Vegetable-Squash Soup', 'zucchini', 'medium', 2, 6
    union select 'Vegetable-Squash Soup', 'water', 'cups', 2, 7
    union select 'Vegetable-Squash Soup', 'marjoram', 'tsp', 1, 8
    union select 'Vegetable-Squash Soup', 'cumin', 'tsp', .5, 9
    union select 'Vegetable-Squash Soup', 'salt', 'tsp', .5, 10
    union select 'Sweet Cheese Toasts', 'bread', 'slices', 2, 1
    union select 'Sweet Cheese Toasts', 'cottage cheese', 'cup', .5, 2
    union select 'Sweet Cheese Toasts', 'cinnamon', 'tsp', .5, 3
    union select 'Sweet Cheese Toasts', 'sugar', 'tsp', 3, 4
    union select 'Pina Colada Drink', 'pineapple juice', 'oz', 92, 1
    union select 'Pina Colada Drink', 'crushed pineapple', 'oz', 40, 2
    union select 'Pina Colada Drink', 'pina colada syrup', 'oz', 50, 3
    union select 'Pina Colada Drink', 'whip cream', 'oz', 20, 4
    union select 'Pina Colada Drink', 'kiwi', 'medium', 5, 5
    union select 'Sweet Lokshen Kugel', 'noodles', 'oz', 12, 1
    union select 'Sweet Lokshen Kugel', 'applesauce', 'cup', 1, 2
    union select 'Sweet Lokshen Kugel', 'eggs', 'extra-large', 3, 3
    union select 'Sweet Lokshen Kugel', 'vanilla sugar', 'package', 1, 4
    union select 'Sweet Lokshen Kugel', 'sugar', 'cup', 1, 5
    union select 'Sweet Lokshen Kugel', 'oil', 'cup', .5, 6
    union select 'Sweet Lokshen Kugel', 'cinnamon', 'sprinkle', null, 7
    union select 'Sweet Potato Chips', 'sweet potatoes', 'large', 5, 1
    union select 'Sweet Potato Chips', 'olive oil', 'tbsp', 4, 2
    union select 'Sweet Potato Chips', 'garlic powder', 'to taste', null, 3
    union select 'Sweet Potato Chips', 'salt and pepper', 'to taste', null, 4
    union select 'Spicy Orzo', 'orzo', 'lb', 1, 1
    union select 'Spicy Orzo', 'garlic', 'cloves', 6, 2
    union select 'Spicy Orzo', 'sugar', 'tbsp', 6, 3
    union select 'Spicy Orzo', 'oil', 'tbsp', 6, 4
    union select 'Spicy Orzo', 'vinager', 'tbsp', 6, 5
    union select 'Spicy Orzo', 'soy sauce', 'tbsp', 6, 6
    union select 'Spicy Orzo', 'olive oil', 'tbsp', 6, 7
    union select 'Spicy Orzo', 'crushed red pepper', 'tsp', 1, 8
    union select 'Spicy Orzo', 'sesame seeds', 'tsp', 1, 9
    union select 'Sesame Chicken', 'chicken cutlets', 'medium', 4, 1
    union select 'Sesame Chicken', 'ketchup', 'cup', .33, 2
    union select 'Sesame Chicken', 'mayonnaise', 'cup', .33, 3
    union select 'Sesame Chicken', 'apricot jam', 'cup', .33, 4
    union select 'Sesame Chicken', 'honey', 'cup', .33, 5
    union select 'Sesame Chicken', 'lemon juice', 'capful', 1, 6
    union select 'Sesame Chicken', 'onion soup mix', 'tsp', 1, 7
    union select 'Sesame Chicken', 'mustard', 'tbsp', 1, 8
    union select 'Sesame Chicken', 'sesame seeds', 'cup', .5, 9
    union select 'Sesame Chicken', 'eggs', 'extra-large', 2, 10
    union select 'Sesame Chicken', 'bread crumbs', 'as necessary', null, 11
    union select 'Sesame Chicken', 'oil', 'as necessary', null, 12
    union select 'Sweet ''N Sour Tongue', 'pickled tongue', 'medium', 1, 1
    union select 'Sweet ''N Sour Tongue', 'onions', 'large', 2, 2
    union select 'Sweet ''N Sour Tongue', 'tomatoe sauce', 'oz', 15, 3
    union select 'Sweet ''N Sour Tongue', 'water', 'cup', .5, 4
    union select 'Sweet ''N Sour Tongue', 'brown sugar', 'cup', .33, 5
    union select 'Sweet ''N Sour Tongue', 'lemon juice', 'tbsp', 2, 6
    union select 'Sweet ''N Sour Tongue', 'orange juice', 'cup', .5, 7
    union select 'Glazed Corned Beef', 'Corned beef', 'lb', 2.5, 1
    union select 'Glazed Corned Beef', 'oil', 'tbsp', 2, 2
    union select 'Glazed Corned Beef', 'mustard', 'tbsp', 1, 3
    union select 'Glazed Corned Beef', 'ketchup', 'tbsp', 5, 4
    union select 'Glazed Corned Beef', 'vinager', 'tbsp', 2, 5
    union select 'Glazed Corned Beef', 'brown sugar', 'cup', .5, 6
    union select 'Baked Ziti', 'ziti noodles', 'lb', 1, 1
    union select 'Baked Ziti', 'onions', 'small', 3, 2
    union select 'Baked Ziti', 'tomatoe paste', 'oz', 12, 3
    union select 'Baked Ziti', 'tomatoe sauce', 'oz', 8, 4
    union select 'Baked Ziti', 'water', 'cups', 1.5, 5
    union select 'Baked Ziti', 'salt', 'to taste', null, 6
    union select 'Baked Ziti', 'sugar', 'to taste', null, 7
    union select 'Baked Ziti', 'garlic powder', 'to taste', null, 8
    union select 'Baked Ziti', 'muenster cheese', 'packages', 2, 9
    union select 'White Wine Doughnuts', 'flour', 'cups', 7.5, 1
    union select 'White Wine Doughnuts', 'margarine', 'stick', .5, 2
    union select 'White Wine Doughnuts', 'eggs', 'extra-large', 3, 3
    union select 'White Wine Doughnuts', 'yeast', 'oz', 2, 4
    union select 'White Wine Doughnuts', 'warm water', 'cup', 1, 5
    union select 'White Wine Doughnuts', 'vanilla sugar', 'package', 1, 6
    union select 'White Wine Doughnuts', 'sugar', 'tbsp', 4, 7
    union select 'White Wine Doughnuts', 'orange juice', 'cup', .67, 8
    union select 'White Wine Doughnuts', 'white wine', 'cup', .33, 9
    union select 'Old-Fashioned Oatmeal Cookies', 'margarine', 'cup', .75, 1
    union select 'Old-Fashioned Oatmeal Cookies', 'sugar', 'cups', 1.5, 2
    union select 'Old-Fashioned Oatmeal Cookies', 'eggs', 'extra-large', 2, 3
    union select 'Old-Fashioned Oatmeal Cookies', 'vanilla extract', 'tsp', 1, 4
    union select 'Old-Fashioned Oatmeal Cookies', 'water', 'cup', 1, 5
    union select 'Old-Fashioned Oatmeal Cookies', 'chocolate chips', 'cup', 1, 6
    union select 'Old-Fashioned Oatmeal Cookies', 'flour', 'cups', 2.5, 7
    union select 'Old-Fashioned Oatmeal Cookies', 'baking soda', 'tsp', .5, 8
    union select 'Old-Fashioned Oatmeal Cookies', 'baking powder', 'tsp', 1, 9
    union select 'Old-Fashioned Oatmeal Cookies', 'oats', 'cups', 2, 10
    union select 'Thick & Rich Milkshakes', 'vanilla ice cream', 'cups', 2, 1
    union select 'Thick & Rich Milkshakes', 'milk', 'cup', .5, 2
    union select 'Thick & Rich Milkshakes', 'heavy cream', 'cup', .5, 3
    union select 'Thick & Rich Milkshakes', 'vanilla extract', 'tsp', 1, 4
    union select 'Chocolate Chip Cookies', 'sugar', 'cup', 1, 1
    union select 'Chocolate Chip Cookies', 'oil', 'cup', .5, 2
    union select 'Chocolate Chip Cookies', 'eggs', null, 3, 3
    union select 'Chocolate Chip Cookies', 'flour', 'cups', 2, 4
    union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 1, 5
    union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 2, 6
    union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', .5, 7
    union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 1, 8
    union select 'Apple Yogurt Smoothie', 'granny smith apples', null, 3, 1
    union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cups', 2, 2
    union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
    union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', .5, 4
    union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
    union select 'Apple Yogurt Smoothie', 'ice cubes', 'medium', 6, 6
    union select 'Cheese Bread', 'club bread', null, 1, 1
    union select 'Cheese Bread', 'butter', 'oz', 4, 2
    union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
    union select 'Cheese Bread', 'garlic', 'cloves', 2, 4
    union select 'Cheese Bread', 'black pepper', 'tsp', .25, 5
    union select 'Cheese Bread', 'salt', 'pinch', 1, 6
    union select 'Butter Muffins', 'butter', 'stick', 1, 1
    union select 'Butter Muffins', 'sugar', 'cups', 3, 2
    union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3
    union select 'Butter Muffins', 'eggs', null, 4, 4
    union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5
    union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
    union select 'Butter Muffins', 'flour', 'cup', 1, 7
    union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, RISequence)
select r.RecipeId, i.IngredientId, m.MeasurementTypeId, x.Amount, x.SequenceNum
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
left join MeasurementType m 
on x.MeasurementTypeName = m.MeasurementTypeName
go 

;
with x as (
        select RecipeName = 'Saucy Franks', SequenceNum = 1, SepDetails = 'Cut the hot dogs into 1 inch thick slices and place into pot.'
    union select 'Saucy Franks', 2, 'Add red currant jelly and mustard.'
    union select 'Saucy Franks', 3, 'Cook on medium flame, uncovered for 15-20 minutes, stirring as necessary. Enjoy!'
    union select 'Potato Bourekas', 1, 'Peel and dice potatoes, cook covered in salted water until soft.'
    union select 'Potato Bourekas', 2, 'While potatoes are cooking, dice onions and mushrooms and saute` in oil, add salt to taste.'
    union select 'Potato Bourekas', 3, 'Once potatoes are done, drain water and mash potatoes with fork.'
    union select 'Potato Bourekas', 4, 'Mix mashed potatoes with onion and mushroom mixture.'
    union select 'Potato Bourekas', 5, 'Spread out puff pastry squares on a flat surface, stretching them slightly.'
    union select 'Potato Bourekas', 6, 'Scoop 1 tablespoon of mashed potatoes onto upper right corner of pasty square leaving 1 cm of the upper and right side still visable.'
    union select 'Potato Bourekas', 7, 'Bring lower left corner, over mashed potatoes, to the upper right corner, seal the edges (side and top) shut with a metal fork.'
    union select 'Potato Bourekas', 8, 'Brush bourekas with scrampled egg and top with sesame seeds.'
    union select 'Potato Bourekas', 9, 'Bake at 350 until golden brown. Enjoy!'
    union select 'French Onion Soup', 1, 'In a 4 quart pot, melt butthe and oil over moderate heat.'
    union select 'French Onion Soup', 2, 'Add onions and seasonings and cook, stirring occasionally for 20-30 minutes until onions are golden brown.'
    union select 'French Onion Soup', 3, 'Sprinkle flour over onions and continue stirring for 2-3 minutes.'
    union select 'French Onion Soup', 4, 'While stirring, add water gradually and simmer, covered, for 40 more minutes.'
    union select 'French Onion Soup', 5, 'Add salt and pepper to taste. Enjoy!'
    union select 'Vegetable-Squash Soup', 1, 'Peel, seed, and dice squash and vegatables.'
    union select 'Vegetable-Squash Soup', 2, 'Place all vegatable in a 4 quart pot; add water and seasonings.'
    union select 'Vegetable-Squash Soup', 3, 'Bring to a boil and simmer until vegatables are tender, approximately 1 hour.'
    union select 'Vegetable-Squash Soup', 4, 'When cool, use an immersion blender to puree vegatables.'
    union select 'Vegetable-Squash Soup', 5, 'Reheat when ready to serve. Enjoy!'
    union select 'Sweet Cheese Toasts', 1, 'Toast the two slices of bread and set aside on a piece of aluminum foil.'
    union select 'Sweet Cheese Toasts', 2, 'Mix cottage cheese, sugar and cinnamon in a bowl.'
    union select 'Sweet Cheese Toasts', 3, 'Spread the cottage cheese mixture over the bread and place in toaster oven on toast for 1 cycle on medium heat. Enjoy!'
    union select 'Pina Colada Drink', 1, 'In a blender on high speed, blend the crushed pineapple until smooth.'
    union select 'Pina Colada Drink', 2, 'Beat the whip cream until stiff.'
    union select 'Pina Colada Drink', 3, 'Combine all ingredients except kiwi and mix by hand.'
    union select 'Pina Colada Drink', 4, 'Pour into individual parfait glasses.'
    union select 'Pina Colada Drink', 5, 'Garnish with a slice of kiwi and serve with a thin straw. Enjoy!'
    union select 'Sweet Lokshen Kugel', 1, 'Cook and drain noodles.'
    union select 'Sweet Lokshen Kugel', 2, 'Add remaining ingredients and mix well.'
    union select 'Sweet Lokshen Kugel', 3, 'Sprinkle with cinnamon.'
    union select 'Sweet Lokshen Kugel', 4, 'Bake in 9x13 for 1 hour at 350. Enjoy!'
    union select 'Sweet Potato Chips', 1, 'Peel and slice sweet potatoes.'
    union select 'Sweet Potato Chips', 2, 'Brush sweet potatoes on both sides with olive oil, place flat on baking sheets or pans, and sprinke with seasoning to taste.'
    union select 'Sweet Potato Chips', 3, 'Bake at 350 for 45 minutes to an hour. Enjoy!'
    union select 'Spicy Orzo', 1, 'Cook and drain orzo;  place in a 9x13 pan.'
    union select 'Spicy Orzo', 2, 'Place remaining ingredients in a small pot, cook on a low heat until it starts bubbling.'
    union select 'Spicy Orzo', 3, 'Remove cloves of garlic and pour sauce mixture over orzo and mix.'
    union select 'Spicy Orzo', 4, 'Reheat when ready to serve. Enjoy!'
    union select 'Sesame Chicken', 1, 'Cut chicken into bite-size nuggets.'
    union select 'Sesame Chicken', 2, 'Dip nuggets into beaten eggs, then into breadcrumbs and fry in hot oil.'
    union select 'Sesame Chicken', 3, 'Combine remaining ingredients, excluding sesame seeds, in medium saucepan and cook for 10 minutes.'
    union select 'Sesame Chicken', 4, 'Place fried nuggets on the bottom of a 9x13 baking pan.'
    union select 'Sesame Chicken', 5, 'Pour cooked mixture over chicken. Chicken should be completely covered with sauce.'
    union select 'Sesame Chicken', 6, 'Cover well and bake at 350 for 1 hour.'
    union select 'Sesame Chicken', 7, 'Remove from oven and sprinkle with sesame seeds while hot. Enjoy!'
    union select 'Sweet ''N Sour Tongue', 1, 'Cook tongue in water until tender.'
    union select 'Sweet ''N Sour Tongue', 2, 'Remove tongue from water and peel while still hot.'
    union select 'Sweet ''N Sour Tongue', 3, 'Cool completely and slice.'
    union select 'Sweet ''N Sour Tongue', 4, 'Bring onions, tomatoe sauce and water to a boil.'
    union select 'Sweet ''N Sour Tongue', 5, 'Add tongue slices and remaining ingredients.'
    union select 'Sweet ''N Sour Tongue', 6, 'Cook for 2-2.5 hours. Enjoy!'
    union select 'Glazed Corned Beef', 1, 'Cook corned beef in a 4 quart pot, covered in water on a medium flame for 45 minutes.'
    union select 'Glazed Corned Beef', 2, 'Combind the rest of the ingredients in a pot and stir until it boils.'
    union select 'Glazed Corned Beef', 3, 'Slice corned beef and pour glaze over it.'
    union select 'Glazed Corned Beef', 4, 'Bake in oven at 325 for half an hour. Enjoy!'
    union select 'Baked Ziti', 1, 'Cook noodles and drain.'
    union select 'Baked Ziti', 2, 'Saute` onions, adding tomatoe paste, sauce and water. Mix well and cook for half an hour.'
    union select 'Baked Ziti', 3, 'Add spices and sugar to taste.'
    union select 'Baked Ziti', 4, 'Pour half of sauce into 10x15 pan.'
    union select 'Baked Ziti', 5, 'Lay one package of muenster cheese over the sauce. Then put in the noodles. Then then other half of the sauce. Then top with remaining package of cheese.'
    union select 'Baked Ziti', 6, 'Bake covered at 350 for half an hour. Enjoy!'
    union select 'White Wine Doughnuts', 1, 'Dissolve yeast in warm water.'
    union select 'White Wine Doughnuts', 2, 'Knead all ingredients in a large bowl.'
    union select 'White Wine Doughnuts', 3, 'Let rise for 1 hour.'
    union select 'White Wine Doughnuts', 4, 'Roll out on board, cut round or doughnut shapes and place on greased surface.'
    union select 'White Wine Doughnuts', 5, 'Allow to rise for another half hour.'
    union select 'White Wine Doughnuts', 6, 'Heat oil in heavy, deep pot. When hot, drop doughnuts in, dry side down.'
    union select 'White Wine Doughnuts', 7, 'Turn doughnuts in oil to brown on both sides. When done, place on paper towel to drain.'
    union select 'White Wine Doughnuts', 8, 'Sprinkle with confectioners'' sugar when cooled. Enjoy!'
    union select 'Old-Fashioned Oatmeal Cookies', 1, 'Preheat oven to 400.'
    union select 'Old-Fashioned Oatmeal Cookies', 2, 'Combine margarine, sugar, eggs, and vanilla; mix well.'
    union select 'Old-Fashioned Oatmeal Cookies', 3, 'Blend in remaining ingredients and mix well.'
    union select 'Old-Fashioned Oatmeal Cookies', 4, 'Drop dough by rounded tablespoons, 2" apart, onto ungreased cookie sheet.'
    union select 'Old-Fashioned Oatmeal Cookies', 5, 'Bake about 15 minutes until lightly browned. Enjoy!'
    union select 'Thick & Rich Milkshakes', 1, 'Place all ingredients into blender; cover and blend until smooth.'
    union select 'Thick & Rich Milkshakes', 2, 'Pour into tall glass and serve. Enjoy!'
    union select 'Chocolate Chip Cookies', 1, 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'mix well'
    union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes'
)

Insert Step(RecipeId, StepSequence, StepDetail)
select r.RecipeId, x.SequenceNum, x.SepDetails
from x
join Recipe r 
on x.RecipeName = r.RecipeName
go 

insert Course(CourseName, CourseSequence)
    select 'Appetizer/Entree', 1
union select 'Soup', 2
union select 'Main', 3
union select 'Dessert', 4
go 

;
with x as(
      select UserName = 'DweckVicy01', MealName = 'Signature Family Anniversary Dinner', cdate = GETDATE(), MealActive = 1
    union select 'SusFish6576!', 'Patio Picnic Lunch', '2020-02-24', 1
    union select 'Malks69', 'Quick-fix Breakfast', '2018-09-08', 0
    union select 'gl1000', 'Breakfast bash', '2023-04-17', 1 
)

insert Meal(UsersID, MealName, MCreateDate, MealActive)
select u.UsersID, x.MealName, x.cdate, x.MealActive
from x 
join Users u
on x.UserName = u.UserName
go 

insert MealCourse(MealId, CourseId)
      select m.MealId, c.CourseId from Meal m cross join Course c where m.MealName not in('Quick-fix Breakfast', 'Breakfast bash') 
union select (select m.MealId from Meal m where m.MealName = 'Quick-fix Breakfast'), (select c.CourseId from Course c where c.CourseName = 'Main')
union select (select m.MealId from Meal m where m.MealName = 'Breakfast bash'), (select c.CourseId from Course c where c.CourseName = 'Main')
union select (select m.MealId from Meal m where m.MealName = 'Breakfast bash'), (select c.CourseId from Course c where c.CourseName = 'Appetizer/Entree')
go 

;
with x as(
    select RecipeName = 'Saucy Franks', MealTitle = 'Signature Family Anniversary Dinner', CourseName = 'Appetizer/Entree', MainDish = 0
union select 'Potato Bourekas', 'Signature Family Anniversary Dinner', 'Appetizer/Entree', 1
union select 'Pina Colada Drink', 'Signature Family Anniversary Dinner', 'Appetizer/Entree', 0
union select 'Sweet ''N Sour Tongue', 'Signature Family Anniversary Dinner', 'Appetizer/Entree', 1
union select 'Vegetable-Squash Soup', 'Signature Family Anniversary Dinner', 'Soup', 1
union select 'Sesame Chicken', 'Signature Family Anniversary Dinner', 'Main', 1
union select 'Glazed Corned Beef', 'Signature Family Anniversary Dinner', 'Main', 1
union select 'Sweet Potato Chips', 'Signature Family Anniversary Dinner', 'Main', 0
union select 'Spicy Orzo', 'Signature Family Anniversary Dinner', 'Main', 0
union select 'Sweet Lokshen Kugel', 'Signature Family Anniversary Dinner', 'Main', 0
union select 'White Wine Doughnuts', 'Signature Family Anniversary Dinner', 'Dessert', 1
union select 'Old-Fashioned Oatmeal Cookies', 'Signature Family Anniversary Dinner', 'Dessert',0
union select 'Thick & Rich Milkshakes', 'Patio Picnic Lunch', 'Appetizer/Entree', 1
union select 'Pina Colada Drink', 'Patio Picnic Lunch', 'Appetizer/Entree', 0
union select 'French Onion Soup', 'Patio Picnic Lunch', 'Soup', 1
union select 'Baked Ziti', 'Patio Picnic Lunch', 'Main', 1
union select 'Sweet Cheese Toasts', 'Patio Picnic Lunch', 'Main', 0
union select 'Sweet Potato Chips', 'Patio Picnic Lunch', 'Main', 0
union select 'Old-Fashioned Oatmeal Cookies', 'Patio Picnic Lunch', 'Dessert', 1
union select 'White Wine Doughnuts', 'Patio Picnic Lunch', 'Dessert', 0
union select 'Sweet Cheese Toasts', 'Quick-fix Breakfast', 'Main', 1
union select 'Thick & Rich Milkshakes', 'Quick-fix Breakfast', 'Main', 0
union select 'Cheese Bread', 'Breakfast bash', 'Main', 1
union select 'Butter Muffins', 'Breakfast bash', 'Main', 0
union select 'Apple Yogurt Smoothie', 'Breakfast bash', 'Appetizer/Entree', 1
)


insert MealCourseRecipe(MealCourseId, RecipeId, MainDish)
select mc.MealCourseId, r.RecipeId, x.MainDish
from x
join Meal m 
on x.MealTitle = m.MealName
join Course c 
on x.CourseName = c.CourseName
join MealCourse mc 
on m.MealId = mc.MealId and c.CourseId = mc.CourseId
join Recipe r 
on x.RecipeName = r.RecipeName
go 

;
with x as(
      select UsersID ='gl1000', CookbookName = 'Mom''s Kitchen', Price = 39.99, CookbookActive = 1, CBCreateDate = '2021-02-13'
union select 'MPK2020', 'DIY Restaurant Favorites', 42.99, 1, '2022-01-15'
union select 'MPK2020', 'Easy Dinners', 24.99, 0, '2022-02-03'
union select 'Malks69', 'Treats for two', 30, 1, '2023-11-21'
)

insert Cookbook(UsersID, CookbookName, CBCreateDate, Price, CookbookActive)
select u.UsersID, x.CookbookName, x.CBCreateDate, x.Price, x.CookbookActive
from x 
join Users u 
on x.UsersID = u.UserName
go

;
with x as(
    select CookbookTitle = 'Mom''s Kitchen', RecipeName = 'Saucy Franks', CBRSeq = 1
union select 'Mom''s Kitchen', 'Vegetable-Squash Soup', 2
union select 'Mom''s Kitchen', 'Sweet Potato Chips', 3
union select 'Mom''s Kitchen', 'Sweet Cheese Toasts', 4
union select 'Mom''s Kitchen', 'Sweet Lokshen Kugel', 5
union select 'Mom''s Kitchen', 'Glazed Corned Beef', 6
union select 'Mom''s Kitchen', 'Baked Ziti', 7
union select 'Mom''s Kitchen', 'Old-Fashioned Oatmeal Cookies', 8
union select 'DIY Restaurant Favorites', 'Pina Colada Drink', 1
union select 'DIY Restaurant Favorites', 'Potato Bourekas', 2
union select 'DIY Restaurant Favorites', 'French Onion Soup', 3
union select 'DIY Restaurant Favorites', 'Spicy Orzo', 4
union select 'DIY Restaurant Favorites', 'Sesame Chicken', 5
union select 'DIY Restaurant Favorites', 'Sweet ''N Sour Tongue', 6
union select 'DIY Restaurant Favorites', 'White Wine Doughnuts', 7
union select 'Easy Dinners', 'Baked Ziti', 1
union select 'Treats for two', 'Chocolate Chip Cookies', 1
union select 'Treats for two', 'Apple Yogurt Smoothie', 2
union select 'Treats for two', 'Cheese Bread', 3
union select 'Treats for two', 'Butter Muffins', 4
)

insert CookbookRecipe(CookbookId, RecipeId, CBRSequence)
select c.CookbookId, r.RecipeId, x.CBRSeq
from x
join Cookbook c 
on x.CookbookTitle = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName
go