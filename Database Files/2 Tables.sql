-- SM Excellent! 100%
Use HeartyHearthDB
go

drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course 
drop table if exists Step 
drop table if exists RecipeIngredient
drop table if exists Recipe 
drop table if exists Users 
drop table if exists MeasurementType
drop table if exists Ingredient 
drop table if exists Cuisine
go  

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineName varchar(50)  not null 
        constraint ck_Cuisine_CuisineName_cannot_be_blank check (CuisineName <> '')
        constraint u_Cuisine_CuisineName unique
)
go 

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(50) not null
        constraint ck_Ingredient_IngredientName_cannot_be_blank check (IngredientName <> '')
        constraint u_Ingredient_IngredientName unique,
    ImageName as concat('Ingredient_', replace(IngredientName, ' ', '_'),'.jpg')
)
go 

create table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key,
    MeasurementTypeName varchar(30) not null
        constraint ck_MeasurementType_MeasurementTypeName_cannot_be_blank check (MeasurementTypeName <> '')
        constraint u_MeasurementType_MeasurementTypeName unique
)
go 

create table dbo.Users(
    UsersID int not null identity primary key,
    UserFirstName varchar(50) not null constraint ck_Users_UserFirstName_cannot_be_blank check (UserFirstName <> ''),
    UserLastName varchar(50) not null constraint ck_Users_UserLastName_cannot_be_blank check (UserLastName <> ''),
    UserName varchar(20) not null 
        constraint ck_UserName_cannot_be_blank check (UserName <> '')
        constraint u_Users_UserName unique
)
go 

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
	UsersID int not null constraint f_Users_Recipe foreign key references Users(UsersID),
    RecipeName varchar(50) not null
        constraint ck_Recipe_RecipeName_cannot_be_blank check (RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    CalorieCount int not null constraint ck_Recipe_CalorieCount_must_be_greater_than_or_equal_0 check(CalorieCount >= 0),
    DateDrafted datetime not null default getdate() constraint ck_Recipe_DateDrafted_cannot_be_future_date check(DateDrafted <= getdate()),
    DatePublished datetime null, 
    DateArchived datetime null,
    RecipeStatus as case
        when DatePublished is null and DateArchived is null then 'Draft'
        when DatePublished is not null and DateArchived is null then 'Published' 
        when DateArchived is not null then 'Archived' end,
    ImageName as concat('Recipe_', replace(RecipeName, ' ', '_'),'.jpg'),
    constraint ck_Recipe_DatePublished_must_be_between_DateDrafted_and_current_date_or_null 
            check(DatePublished is null or DatePublished between DateDrafted and getdate()),
    constraint ck_Recipe_DateArchived_must_be_between_DateDrafted_or_DatePublished_if_applicable_and_current_date_or_null 
            check(DateArchived is null or DateArchived between Isnull(DatePublished, DateDrafted) and getdate())
)
go 

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementTypeId int null constraint f_MeasurementType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
    Amount decimal(4,2) null constraint ck_RecipeIngredient_Amount_must_be_greater_than_0 check(Amount > 0),
    RISequence int not null constraint ck_RecipeIngredient_RISequence_must_be_greater_than_0 check(RISequence > 0),
        constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId, IngredientId),
        constraint u_RecipeIngredient_RecipeId_RISequence unique(RecipeId, RISequence)
)
go 

create table dbo.Step(
    StepId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_Step foreign key references Recipe(RecipeId),
    StepDetail Varchar(1000) not null constraint ck_Step_StepDetail_cannot_be_blank check (StepDetail <> ''),
    StepSequence int not null constraint ck_Step_StepSequence_must_be_greater_than_0 check (StepSequence > 0),
        constraint u_Step_RecipeId_StepSequence unique(RecipeId, StepSequence)
)
go 

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(30) not null 
        constraint ck_Course_CourseName_cannot_be_blank check (CourseName <> '')
        constraint u_Course_CourseName unique,
    CourseSequence int not null 
        constraint ck_Course_CourseSequence_must_be_greater_than_0 check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique
)
go 

create table dbo.Meal(
    MealId int not null identity primary key,
    UsersID int not null constraint f_Users_Meal foreign key references Users(UsersID),
    MealName varchar(50) not null 
        constraint ck_Meal_MealName_cannot_be_blank check (MealName <> '')
        constraint u_Meal_MealName unique,
    MCreateDate date not null default getdate() constraint ck_Meal_MCreateDate_cannot_be_future_date check(MCreateDate <= getdate()),
    MealActive bit not null default 1,
    ImageName as concat('Meal_', replace(MealName, ' ', '_'),'.jpg')
)
go 

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
        constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)
go 

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null default 1,
        constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)
go 

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UsersID int not null constraint f_Users_Cookbook foreign key references Users(UsersID),
    CookbookName varchar(50) not null
        constraint ck_Cookbook_CookbookName_cannot_be_blank check (CookbookName <> '')
        constraint u_Cookbook_CookbookName unique,
    Price decimal(5,2) not null constraint ck_Cookbook_Price_must_be_greater_than_0 check(Price > 0),
    CBCreateDate date not null default getdate() constraint ck_Cookbook_CBCreateDate_cannot_be_future_date check(CBCreateDate <= getdate()),
    CookbookActive bit not null default 1,
    ImageName as concat('Cookbook_', replace(CookbookName, ' ', '_'),'.jpg')
)
go 

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    CBRSequence int not null constraint ck_CookbookRecipe_CBRSequence_must_be_greater_than_0 check(CBRSequence > 0),
        constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId, RecipeId),
        constraint u_CookbookRecipe_CookbookId_CBRSequence unique(CookbookId, CBRSequence)
)