;
with x as(
        select UserName = 'SusFish6576!', CuisineName = 'American', RecipeName = 'Saucy Franks NoRelatedRecords', CalorieCount = 320, DateDrafted = '2002-05-17', DatePublished = '2002-05-17', DateArchived = null
    union select 'SusFish6576!', 'British', 'Potato Bourekas NoRelatedRecords', 140, '2007-05-16', '2007-08-13', '2010-09-30'
    union select 'DweckVicy01', 'French', 'French Onion Soup NoRelatedRecords', 180, '2000-03-02', '2000-03-02', null
    union select 'DweckVicy01', 'Mediterranean', 'Vegetable-Squash Soup NoRelatedRecords', 60, '2015-12-09', '2015-12-10', null
    union select 'SusFish6576!', 'American', 'Sweet Cheese Toasts NoRelatedRecords', 220, '2022-01-11', null, null
    union select 'MPK2020', 'Italian', 'Pina Colada Drink NoRelatedRecords', 150, '2018-05-07', '2018-05-09', '2020-09-21'
    union select 'MPK2020', 'Israeli', 'Sweet Lokshen Kugel NoRelatedRecords', 180, '2004-07-08', '2005-04-20', null
    union select 'Chan613', 'Greek', 'Sweet Potato Chips NoRelatedRecords', 360, '2000-01-17', '2000-01-17', null
    union select 'Chan613', 'Moroccan', 'Spicy Orzo NoRelatedRecords', 110, '2019-05-04', '2019-05-31', null
    union select 'gl1000', 'Chinese', 'Sesame Chicken NoRelatedRecords', 320, '2021-02-28', '2021-03-18', null
    union select 'gl1000', 'American', 'Sweet ''N Sour Tongue NoRelatedRecords', 260, '2022-01-15', '2022-01-27', null
    union select 'gl1000', 'American', 'Glazed Corned Beef NoRelatedRecords', 240, '2021-11-22', '2022-02-12', null
    union select 'gl1000', 'Italian', 'Baked Ziti NoRelatedRecords', 420, '2010-01-07', '2010-03-13', null
    union select 'gl1000', 'French', 'White Wine Doughnuts NoRelatedRecords', 400, '2020-03-07', null, '2021-12-13'
    union select 'Pg@1648', 'British', 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 260, '2003-07-21', '2003-07-21', null
    union select 'SusFish6576!', 'American', 'Thick & Rich Milkshakes NoRelatedRecords', 500, '2015-03-16', '2015-03-16', null
    union select 'Malks69', 'American', 'Chocolate Chip Cookies NoRelatedRecords', 150, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'French', 'Apple Yogurt Smoothie NoRelatedRecords', 80, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'British', 'Cheese Bread NoRelatedRecords', 250, '2000-01-02', '2000-03-01', '2021-11-10'
    union select 'Malks69', 'American', 'Butter Muffins NoRelatedRecords', 400, '2000-01-02', '2000-03-01', '2021-11-10'
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
        select RecipeName = 'Saucy Franks NoRelatedRecords', IngredientName ='franks', MeasurementTypeName = 'regular',  Amount = 6, SequenceNum =  1
    union select 'Saucy Franks NoRelatedRecords', 'red currant jelly', 'jar', 1, 2
    union select 'Saucy Franks NoRelatedRecords', 'spicy brown mustard', 'tbsp', 4, 3
    union select 'Potato Bourekas NoRelatedRecords', 'puff pastry squares', 'squares', 12, 1
    union select 'Potato Bourekas NoRelatedRecords', 'potatoes', 'medium', 3, 2
    union select 'Potato Bourekas NoRelatedRecords', 'onions', 'small', 2, 3
    union select 'Potato Bourekas NoRelatedRecords', 'oil', 'tbsp', 6, 4
    union select 'Potato Bourekas NoRelatedRecords', 'portobello mushroom', 'medium', 1, 5
    union select 'Potato Bourekas NoRelatedRecords', 'salt', 'to taste', null, 6
    union select 'Potato Bourekas NoRelatedRecords', 'egg', 'extra-large', 1, 7
    union select 'Potato Bourekas NoRelatedRecords', 'sesame seeds', 'sprinkle', null, 8
    union select 'French Onion Soup NoRelatedRecords', 'butter', 'tbsp', 4, 1
    union select 'French Onion Soup NoRelatedRecords', 'oil', 'tbsp', 2, 2
    union select 'French Onion Soup NoRelatedRecords', 'onions', 'cups', 7, 3
    union select 'French Onion Soup NoRelatedRecords', 'salt', 'tsp', 1, 4
    union select 'French Onion Soup NoRelatedRecords', 'minced garlic', 'tbsp', 2, 5
    union select 'French Onion Soup NoRelatedRecords', 'basil', 'tsp', 1, 6
    union select 'French Onion Soup NoRelatedRecords', 'thyme', 'tsp', 1, 7
    union select 'French Onion Soup NoRelatedRecords', 'flour', 'tbsp', 3, 8
    union select 'French Onion Soup NoRelatedRecords', 'water', 'cups', 8, 9
    union select 'French Onion Soup NoRelatedRecords', 'salt and pepper', 'to taste', null, 10
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'butternut squash', 'large', 1, 1
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'sweet potato', 'large', 1, 2
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'celery', 'stalks', 2, 3
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'carrots', 'medium', 3, 4
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'shredded cabbage', 'cup', 1, 5
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'zucchini', 'medium', 2, 6
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'water', 'cups', 2, 7
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'marjoram', 'tsp', 1, 8
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'cumin', 'tsp', .5, 9
    union select 'Vegetable-Squash Soup NoRelatedRecords', 'salt', 'tsp', .5, 10
    union select 'Sweet Cheese Toasts NoRelatedRecords', 'bread', 'slices', 2, 1
    union select 'Sweet Cheese Toasts NoRelatedRecords', 'cottage cheese', 'cup', .5, 2
    union select 'Sweet Cheese Toasts NoRelatedRecords', 'cinnamon', 'tsp', .5, 3
    union select 'Sweet Cheese Toasts NoRelatedRecords', 'sugar', 'tsp', 3, 4
    union select 'Pina Colada Drink NoRelatedRecords', 'pineapple juice', 'oz', 92, 1
    union select 'Pina Colada Drink NoRelatedRecords', 'crushed pineapple', 'oz', 40, 2
    union select 'Pina Colada Drink NoRelatedRecords', 'pina colada syrup', 'oz', 50, 3
    union select 'Pina Colada Drink NoRelatedRecords', 'whip cream', 'oz', 20, 4
    union select 'Pina Colada Drink NoRelatedRecords', 'kiwi', 'medium', 5, 5
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'noodles', 'oz', 12, 1
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'applesauce', 'cup', 1, 2
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'eggs', 'extra-large', 3, 3
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'vanilla sugar', 'package', 1, 4
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'sugar', 'cup', 1, 5
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'oil', 'cup', .5, 6
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 'cinnamon', 'sprinkle', null, 7
    union select 'Sweet Potato Chips NoRelatedRecords', 'sweet potatoes', 'large', 5, 1
    union select 'Sweet Potato Chips NoRelatedRecords', 'olive oil', 'tbsp', 4, 2
    union select 'Sweet Potato Chips NoRelatedRecords', 'garlic powder', 'to taste', null, 3
    union select 'Sweet Potato Chips NoRelatedRecords', 'salt and pepper', 'to taste', null, 4
    union select 'Spicy Orzo NoRelatedRecords', 'orzo', 'lb', 1, 1
    union select 'Spicy Orzo NoRelatedRecords', 'garlic', 'cloves', 6, 2
    union select 'Spicy Orzo NoRelatedRecords', 'sugar', 'tbsp', 6, 3
    union select 'Spicy Orzo NoRelatedRecords', 'oil', 'tbsp', 6, 4
    union select 'Spicy Orzo NoRelatedRecords', 'vinager', 'tbsp', 6, 5
    union select 'Spicy Orzo NoRelatedRecords', 'soy sauce', 'tbsp', 6, 6
    union select 'Spicy Orzo NoRelatedRecords', 'olive oil', 'tbsp', 6, 7
    union select 'Spicy Orzo NoRelatedRecords', 'crushed red pepper', 'tsp', 1, 8
    union select 'Spicy Orzo NoRelatedRecords', 'sesame seeds', 'tsp', 1, 9
    union select 'Sesame Chicken NoRelatedRecords', 'chicken cutlets', 'medium', 4, 1
    union select 'Sesame Chicken NoRelatedRecords', 'ketchup', 'cup', .33, 2
    union select 'Sesame Chicken NoRelatedRecords', 'mayonnaise', 'cup', .33, 3
    union select 'Sesame Chicken NoRelatedRecords', 'apricot jam', 'cup', .33, 4
    union select 'Sesame Chicken NoRelatedRecords', 'honey', 'cup', .33, 5
    union select 'Sesame Chicken NoRelatedRecords', 'lemon juice', 'capful', 1, 6
    union select 'Sesame Chicken NoRelatedRecords', 'onion soup mix', 'tsp', 1, 7
    union select 'Sesame Chicken NoRelatedRecords', 'mustard', 'tbsp', 1, 8
    union select 'Sesame Chicken NoRelatedRecords', 'sesame seeds', 'cup', .5, 9
    union select 'Sesame Chicken NoRelatedRecords', 'eggs', 'extra-large', 2, 10
    union select 'Sesame Chicken NoRelatedRecords', 'bread crumbs', 'as necessary', null, 11
    union select 'Sesame Chicken NoRelatedRecords', 'oil', 'as necessary', null, 12
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'pickled tongue', 'medium', 1, 1
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'onions', 'large', 2, 2
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'tomatoe sauce', 'oz', 15, 3
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'water', 'cup', .5, 4
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'brown sugar', 'cup', .33, 5
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'lemon juice', 'tbsp', 2, 6
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 'orange juice', 'cup', .5, 7
    union select 'Glazed Corned Beef NoRelatedRecords', 'Corned beef', 'lb', 2.5, 1
    union select 'Glazed Corned Beef NoRelatedRecords', 'oil', 'tbsp', 2, 2
    union select 'Glazed Corned Beef NoRelatedRecords', 'mustard', 'tbsp', 1, 3
    union select 'Glazed Corned Beef NoRelatedRecords', 'ketchup', 'tbsp', 5, 4
    union select 'Glazed Corned Beef NoRelatedRecords', 'vinager', 'tbsp', 2, 5
    union select 'Glazed Corned Beef NoRelatedRecords', 'brown sugar', 'cup', .5, 6
    union select 'Baked Ziti NoRelatedRecords', 'ziti noodles', 'lb', 1, 1
    union select 'Baked Ziti NoRelatedRecords', 'onions', 'small', 3, 2
    union select 'Baked Ziti NoRelatedRecords', 'tomatoe paste', 'oz', 12, 3
    union select 'Baked Ziti NoRelatedRecords', 'tomatoe sauce', 'oz', 8, 4
    union select 'Baked Ziti NoRelatedRecords', 'water', 'cups', 1.5, 5
    union select 'Baked Ziti NoRelatedRecords', 'salt', 'to taste', null, 6
    union select 'Baked Ziti NoRelatedRecords', 'sugar', 'to taste', null, 7
    union select 'Baked Ziti NoRelatedRecords', 'garlic powder', 'to taste', null, 8
    union select 'Baked Ziti NoRelatedRecords', 'muenster cheese', 'packages', 2, 9
    union select 'White Wine Doughnuts NoRelatedRecords', 'flour', 'cups', 7.5, 1
    union select 'White Wine Doughnuts NoRelatedRecords', 'margarine', 'stick', .5, 2
    union select 'White Wine Doughnuts NoRelatedRecords', 'eggs', 'extra-large', 3, 3
    union select 'White Wine Doughnuts NoRelatedRecords', 'yeast', 'oz', 2, 4
    union select 'White Wine Doughnuts NoRelatedRecords', 'warm water', 'cup', 1, 5
    union select 'White Wine Doughnuts NoRelatedRecords', 'vanilla sugar', 'package', 1, 6
    union select 'White Wine Doughnuts NoRelatedRecords', 'sugar', 'tbsp', 4, 7
    union select 'White Wine Doughnuts NoRelatedRecords', 'orange juice', 'cup', .67, 8
    union select 'White Wine Doughnuts NoRelatedRecords', 'white wine', 'cup', .33, 9
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'margarine', 'cup', .75, 1
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'sugar', 'cups', 1.5, 2
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'eggs', 'extra-large', 2, 3
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'vanilla extract', 'tsp', 1, 4
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'water', 'cup', 1, 5
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'chocolate chips', 'cup', 1, 6
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'flour', 'cups', 2.5, 7
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'baking soda', 'tsp', .5, 8
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'baking powder', 'tsp', 1, 9
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 'oats', 'cups', 2, 10
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 'vanilla ice cream', 'cups', 2, 1
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 'milk', 'cup', .5, 2
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 'heavy cream', 'cup', .5, 3
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 'vanilla extract', 'tsp', 1, 4
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'sugar', 'cup', 1, 1
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'oil', 'cup', .5, 2
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'eggs', null, 3, 3
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'flour', 'cups', 2, 4
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'vanilla sugar', 'tsp', 1, 5
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'baking powder', 'tsp', 2, 6
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'baking soda', 'tsp', .5, 7
    union select 'Chocolate Chip Cookies NoRelatedRecords', 'chocolate chips', 'cup', 1, 8
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'granny smith apples', null, 3, 1
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'vanilla yogurt', 'cups', 2, 2
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'sugar', 'tsp', 2, 3
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'orange juice', 'cup', .5, 4
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'honey', 'tbsp', 2, 5
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 'ice cubes', 'medium', 6, 6
    union select 'Cheese Bread NoRelatedRecords', 'club bread', null, 1, 1
    union select 'Cheese Bread NoRelatedRecords', 'butter', 'oz', 4, 2
    union select 'Cheese Bread NoRelatedRecords', 'shredded cheese', 'oz', 8, 3
    union select 'Cheese Bread NoRelatedRecords', 'garlic', 'cloves', 2, 4
    union select 'Cheese Bread NoRelatedRecords', 'black pepper', 'tsp', .25, 5
    union select 'Cheese Bread NoRelatedRecords', 'salt', 'pinch', 1, 6
    union select 'Butter Muffins NoRelatedRecords', 'butter', 'stick', 1, 1
    union select 'Butter Muffins NoRelatedRecords', 'sugar', 'cups', 3, 2
    union select 'Butter Muffins NoRelatedRecords', 'vanilla pudding', 'tbsp', 2, 3
    union select 'Butter Muffins NoRelatedRecords', 'eggs', null, 4, 4
    union select 'Butter Muffins NoRelatedRecords', 'whipped cream cheese', 'oz', 8, 5
    union select 'Butter Muffins NoRelatedRecords', 'sour cream cheese', 'oz', 8, 6
    union select 'Butter Muffins NoRelatedRecords', 'flour', 'cup', 1, 7
    union select 'Butter Muffins NoRelatedRecords', 'baking powder', 'tsp', 2, 8
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
        select RecipeName = 'Saucy Franks NoRelatedRecords', SequenceNum = 1, SepDetails = 'Cut the hot dogs into 1 inch thick slices and place into pot.'
    union select 'Saucy Franks NoRelatedRecords', 2, 'Add red currant jelly and mustard.'
    union select 'Saucy Franks NoRelatedRecords', 3, 'Cook on medium flame, uncovered for 15-20 minutes, stirring as necessary. Enjoy!'
    union select 'Potato Bourekas NoRelatedRecords', 1, 'Peel and dice potatoes, cook covered in salted water until soft.'
    union select 'Potato Bourekas NoRelatedRecords', 2, 'While potatoes are cooking, dice onions and mushrooms and saute` in oil, add salt to taste.'
    union select 'Potato Bourekas NoRelatedRecords', 3, 'Once potatoes are done, drain water and mash potatoes with fork.'
    union select 'Potato Bourekas NoRelatedRecords', 4, 'Mix mashed potatoes with onion and mushroom mixture.'
    union select 'Potato Bourekas NoRelatedRecords', 5, 'Spread out puff pastry squares on a flat surface, stretching them slightly.'
    union select 'Potato Bourekas NoRelatedRecords', 6, 'Scoop 1 tablespoon of mashed potatoes onto upper right corner of pasty square leaving 1 cm of the upper and right side still visable.'
    union select 'Potato Bourekas NoRelatedRecords', 7, 'Bring lower left corner, over mashed potatoes, to the upper right corner, seal the edges (side and top) shut with a metal fork.'
    union select 'Potato Bourekas NoRelatedRecords', 8, 'Brush bourekas with scrampled egg and top with sesame seeds.'
    union select 'Potato Bourekas NoRelatedRecords', 9, 'Bake at 350 until golden brown. Enjoy!'
    union select 'French Onion Soup NoRelatedRecords', 1, 'In a 4 quart pot, melt butthe and oil over moderate heat.'
    union select 'French Onion Soup NoRelatedRecords', 2, 'Add onions and seasonings and cook, stirring occasionally for 20-30 minutes until onions are golden brown.'
    union select 'French Onion Soup NoRelatedRecords', 3, 'Sprinkle flour over onions and continue stirring for 2-3 minutes.'
    union select 'French Onion Soup NoRelatedRecords', 4, 'While stirring, add water gradually and simmer, covered, for 40 more minutes.'
    union select 'French Onion Soup NoRelatedRecords', 5, 'Add salt and pepper to taste. Enjoy!'
    union select 'Vegetable-Squash Soup NoRelatedRecords', 1, 'Peel, seed, and dice squash and vegatables.'
    union select 'Vegetable-Squash Soup NoRelatedRecords', 2, 'Place all vegatable in a 4 quart pot; add water and seasonings.'
    union select 'Vegetable-Squash Soup NoRelatedRecords', 3, 'Bring to a boil and simmer until vegatables are tender, approximately 1 hour.'
    union select 'Vegetable-Squash Soup NoRelatedRecords', 4, 'When cool, use an immersion blender to puree vegatables.'
    union select 'Vegetable-Squash Soup NoRelatedRecords', 5, 'Reheat when ready to serve. Enjoy!'
    union select 'Sweet Cheese Toasts NoRelatedRecords', 1, 'Toast the two slices of bread and set aside on a piece of aluminum foil.'
    union select 'Sweet Cheese Toasts NoRelatedRecords', 2, 'Mix cottage cheese, sugar and cinnamon in a bowl.'
    union select 'Sweet Cheese Toasts NoRelatedRecords', 3, 'Spread the cottage cheese mixture over the bread and place in toaster oven on toast for 1 cycle on medium heat. Enjoy!'
    union select 'Pina Colada Drink NoRelatedRecords', 1, 'In a blender on high speed, blend the crushed pineapple until smooth.'
    union select 'Pina Colada Drink NoRelatedRecords', 2, 'Beat the whip cream until stiff.'
    union select 'Pina Colada Drink NoRelatedRecords', 3, 'Combine all ingredients except kiwi and mix by hand.'
    union select 'Pina Colada Drink NoRelatedRecords', 4, 'Pour into individual parfait glasses.'
    union select 'Pina Colada Drink NoRelatedRecords', 5, 'Garnish with a slice of kiwi and serve with a thin straw. Enjoy!'
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 1, 'Cook and drain noodles.'
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 2, 'Add remaining ingredients and mix well.'
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 3, 'Sprinkle with cinnamon.'
    union select 'Sweet Lokshen Kugel NoRelatedRecords', 4, 'Bake in 9x13 for 1 hour at 350. Enjoy!'
    union select 'Sweet Potato Chips NoRelatedRecords', 1, 'Peel and slice sweet potatoes.'
    union select 'Sweet Potato Chips NoRelatedRecords', 2, 'Brush sweet potatoes on both sides with olive oil, place flat on baking sheets or pans, and sprinke with seasoning to taste.'
    union select 'Sweet Potato Chips NoRelatedRecords', 3, 'Bake at 350 for 45 minutes to an hour. Enjoy!'
    union select 'Spicy Orzo NoRelatedRecords', 1, 'Cook and drain orzo;  place in a 9x13 pan.'
    union select 'Spicy Orzo NoRelatedRecords', 2, 'Place remaining ingredients in a small pot, cook on a low heat until it starts bubbling.'
    union select 'Spicy Orzo NoRelatedRecords', 3, 'Remove cloves of garlic and pour sauce mixture over orzo and mix.'
    union select 'Spicy Orzo NoRelatedRecords', 4, 'Reheat when ready to serve. Enjoy!'
    union select 'Sesame Chicken NoRelatedRecords', 1, 'Cut chicken into bite-size nuggets.'
    union select 'Sesame Chicken NoRelatedRecords', 2, 'Dip nuggets into beaten eggs, then into breadcrumbs and fry in hot oil.'
    union select 'Sesame Chicken NoRelatedRecords', 3, 'Combine remaining ingredients, excluding sesame seeds, in medium saucepan and cook for 10 minutes.'
    union select 'Sesame Chicken NoRelatedRecords', 4, 'Place fried nuggets on the bottom of a 9x13 baking pan.'
    union select 'Sesame Chicken NoRelatedRecords', 5, 'Pour cooked mixture over chicken. Chicken should be completely covered with sauce.'
    union select 'Sesame Chicken NoRelatedRecords', 6, 'Cover well and bake at 350 for 1 hour.'
    union select 'Sesame Chicken NoRelatedRecords', 7, 'Remove from oven and sprinkle with sesame seeds while hot. Enjoy!'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 1, 'Cook tongue in water until tender.'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 2, 'Remove tongue from water and peel while still hot.'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 3, 'Cool completely and slice.'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 4, 'Bring onions, tomatoe sauce and water to a boil.'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 5, 'Add tongue slices and remaining ingredients.'
    union select 'Sweet ''N Sour Tongue NoRelatedRecords', 6, 'Cook for 2-2.5 hours. Enjoy!'
    union select 'Glazed Corned Beef NoRelatedRecords', 1, 'Cook corned beef in a 4 quart pot, covered in water on a medium flame for 45 minutes.'
    union select 'Glazed Corned Beef NoRelatedRecords', 2, 'Combind the rest of the ingredients in a pot and stir until it boils.'
    union select 'Glazed Corned Beef NoRelatedRecords', 3, 'Slice corned beef and pour glaze over it.'
    union select 'Glazed Corned Beef NoRelatedRecords', 4, 'Bake in oven at 325 for half an hour. Enjoy!'
    union select 'Baked Ziti NoRelatedRecords', 1, 'Cook noodles and drain.'
    union select 'Baked Ziti NoRelatedRecords', 2, 'Saute` onions, adding tomatoe paste, sauce and water. Mix well and cook for half an hour.'
    union select 'Baked Ziti NoRelatedRecords', 3, 'Add spices and sugar to taste.'
    union select 'Baked Ziti NoRelatedRecords', 4, 'Pour half of sauce into 10x15 pan.'
    union select 'Baked Ziti NoRelatedRecords', 5, 'Lay one package of muenster cheese over the sauce. Then put in the noodles. Then then other half of the sauce. Then top with remaining package of cheese.'
    union select 'Baked Ziti NoRelatedRecords', 6, 'Bake covered at 350 for half an hour. Enjoy!'
    union select 'White Wine Doughnuts NoRelatedRecords', 1, 'Dissolve yeast in warm water.'
    union select 'White Wine Doughnuts NoRelatedRecords', 2, 'Knead all ingredients in a large bowl.'
    union select 'White Wine Doughnuts NoRelatedRecords', 3, 'Let rise for 1 hour.'
    union select 'White Wine Doughnuts NoRelatedRecords', 4, 'Roll out on board, cut round or doughnut shapes and place on greased surface.'
    union select 'White Wine Doughnuts NoRelatedRecords', 5, 'Allow to rise for another half hour.'
    union select 'White Wine Doughnuts NoRelatedRecords', 6, 'Heat oil in heavy, deep pot. When hot, drop doughnuts in, dry side down.'
    union select 'White Wine Doughnuts NoRelatedRecords', 7, 'Turn doughnuts in oil to brown on both sides. When done, place on paper towel to drain.'
    union select 'White Wine Doughnuts NoRelatedRecords', 8, 'Sprinkle with confectioners'' sugar when cooled. Enjoy!'
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 1, 'Preheat oven to 400.'
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 2, 'Combine margarine, sugar, eggs, and vanilla; mix well.'
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 3, 'Blend in remaining ingredients and mix well.'
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 4, 'Drop dough by rounded tablespoons, 2" apart, onto ungreased cookie sheet.'
    union select 'Old-Fashioned Oatmeal Cookies NoRelatedRecords', 5, 'Bake about 15 minutes until lightly browned. Enjoy!'
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 1, 'Place all ingredients into blender; cover and blend until smooth.'
    union select 'Thick & Rich Milkshakes NoRelatedRecords', 2, 'Pour into tall glass and serve. Enjoy!'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 1, 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 2, 'mix well'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies NoRelatedRecords', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie NoRelatedRecords', 5, 'pour into glasses'
    union select 'Cheese Bread NoRelatedRecords', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread NoRelatedRecords', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread NoRelatedRecords', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread NoRelatedRecords', 4, 'wrap bread into a foil and bake for 30 minutes'
    union select 'Butter Muffins NoRelatedRecords', 1, 'Cream butter with sugars'
    union select 'Butter Muffins NoRelatedRecords', 2, 'Add eggs and mix well'
    union select 'Butter Muffins NoRelatedRecords', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins NoRelatedRecords', 4, 'fill muffin pans 3/4 full and bake for 30 minutes'
)

Insert Step(RecipeId, StepSequence, StepDetail)
select r.RecipeId, x.SequenceNum, x.SepDetails
from x
join Recipe r 
on x.RecipeName = r.RecipeName
go 