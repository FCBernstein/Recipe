use HeartyHearthDB
go
--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on RecipeUpdate to approle
grant execute on CuisineGet to approle
grant execute on CookbookGet to approle
grant execute on CourseGet to approle
grant execute on IngredientGet to approle
grant execute on MealGet to approle
grant execute on MeasurementTypeGet to approle
grant execute on IngredientNameGet to approle
grant execute on RecipeGet to approle
grant execute on UsersGet to approle
grant execute on StepGet to approle
grant execute on RecipeDelete to approle
grant execute on RecipeDesc to approle
grant execute on UsersUpdate to approle
grant execute on CaloriesPerMeal to approle
grant execute on UsersListGet to approle
grant execute on UsersDelete to approle
grant execute on StepUpdate to approle
grant execute on StepDelete to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on RecipeIngredientDelete to approle
grant execute on MeasurementTypeUpdate to approle
grant execute on MeasurementTypeListGet to approle
grant execute on MeasurementTypeDelete to approle
grant execute on IngredientUpdate to approle
grant execute on IngredientListGet to approle
grant execute on IngredientDelete to approle
grant execute on CuisineUpdate to approle
grant execute on CuisineDelete to approle
grant execute on CourseUpdate to approle
grant execute on DashboardGet to approle
grant execute on CourseDelete to approle
grant execute on FullNameofUser to approle
grant execute on NumIngPerRecipe to approle
grant execute on RecipeIngredientGet to approle
grant execute on RecipeStepGet to approle
grant execute on RecipeListGet to approle
grant execute on CuisineListGet to approle