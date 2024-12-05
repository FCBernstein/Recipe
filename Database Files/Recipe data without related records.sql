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