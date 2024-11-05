-- SM Excellent! Really good sketch! See comments, no need to resubmit. 
-- You can start creating the DB and do all constraints like blank and >0 for all columns that will need it. Good luck!!!
/*
Cuisine
    CuisineId pk
    CuisineName varchar 50 unique not null or blank
Ingredient
    IngredientId pk
    IName varchar unique not null or blank
    IImage as concat('Ingredient_', replace(IName, ' ', '_'),'.jpg')
MeasurementType
    MeasurementTypeId pk
    MeasureTypeName varchar 30 unique not null or blank
User
    UserID pk
    UserFirstName varchar 50 not null or blank
    UserLastName varchar 50 not null or blank
    UName varchar 20 not null or blank unique
Recipe
    RecipeId pk
    CuisineId fk Cuisine not null
    RCreatedBy fk User not null
    RName varchar 50 not null or blank unique
    CalorieCount int not null
    DateDrafted date not null default get date
    DatePublished date null 
        constraint- between draft and current date
    DateArchived date null
        constraint- between draft (or published date) and current date or null
(-- SM Should be computed column based on latest date.)
    RecipeStatus as case
        when DatePublished and DateArchived null then 'Draft'
        when DatePublished not null and DateArchived null then 'Published' 
        when DateArchived not null then 'Archived' end
    RImage as concat('Recipe_', replace(RName, ' ', '_'),'.jpg')
RecipeIngredient
    RecipeIngredientId pk
    RecipeId fk Recipe not null
    IngredientId fk Ingredient not null
(-- SM Measurement should allow null. Eggs don't have a measurement.)
    MeasureTypeId fk MeasureType null not blank
    Amount decimal 4,2 not null greater than 0
    RISequence int not null greater than 0
        constraint RecipeId,IngredientId unique
        constraint RecipeId, RISequence unique
Step
    StepId pk
    RecipeId fk recipe not null
    StepDetail Varchar 1000 not null or blank
    StepSequence int not null greater than 0
        constraint recipeId, StepSequence unique
Course
    CourseId pk
    CourseName varchar 30 not null or blank unique
    CourseSequence int not null greater than 0 unique
Meal
    MealId pk
    MName varchar 50 not null or blank unique
    MCreateBy fk User not null
    MCreateDate date default getdate
    MStatus bit (Active/inactive)
    MImage as concat('Meal_', replace(MName, ' ', '_'),'.jpg')
MealCourse
    MealCourseId pk
    MealId fk Meal not null
    CourseId fk Course not null
(-- SM This can be in course table. Dessert will never be before main. You might miss a course in some meals, but the order will always be the same.
 -- MealCourseSequence int not null greater than 0)
        constraint MealId, CourseId unique
MealCourseRecipe
    MealCourseRecipeId pk
    MealCourseId fk MealCourse not null
    RecipeId fk Recipe not null
(-- SM No need for this column. But you need a column to check if the recipe is main dish or side dish.
 -- CRSequence int not null greater than 0)
    MainDish bit not null default 1 (main)
        constraint MealCourseId, RecipeId unique
Cookbook
    CBName varchar 50 unique
    CBCreatedBy fk User not null
    CBCreateDate date default get date
    Price decimal 5,2 not null, greater than 0
    CBStatus bit
    CBImage as concat('Cookbook_', replace(CBName, ' ', '_'),'.jpg')
CookbookRecipe
    CookbookRecipeId pk
    CookbookId fk Cookbook not null
    RecipeId fk Recipe not null
    CBRSequence int not null greater than 0
(-- SM Should be split in 2 constraints.)
        constraint CookbookId, RecipeId unique
        constraint CookbookId, CBRSequence unique

*/