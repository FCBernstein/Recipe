using Microsoft.IdentityModel.Protocols;
using System.Data;

namespace RecipeTest
{
    public class RecicpeTests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;

        }

        private int GetFirstColumnFirstRowValueInt(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValueInt(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }
        private string GetFirstColumnFirstRowValueString(string sql)
        {
            string n = "";
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValueString(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        private DateTime GetFirstColumnFirstRowValueDate(string sql)
        {
            DateTime n = DateTime.Now;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValueDate(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        private void ExecuteSQL(string sql)
        {
            DBManager.SetConnectionString(testconnstring, false);
            SQLUtility.ExecuteSQL(sql);
            DBManager.SetConnectionString(connstring, false);
        }

        [Test]
        [TestCase("Recipe Test", 5, "2025-1-1")]
        public void InsertNewRecipe(string recipename, int caloriecount, DateTime datedrafted)
        {
            recipename = recipename + DateTime.Now.ToString();
            DataTable dt = GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = GetFirstColumnFirstRowValueInt("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "can't run test no cuisines in the DB");
            int usersid = GetFirstColumnFirstRowValueInt("select top 1 usersid from users");
            Assume.That(usersid > 0, "can't run test no users in the DB");

            TestContext.WriteLine("insert recipe with recipename = " + recipename);

            r["CuisineId"] = cuisineid;
            r["UsersId"] = usersid;
            r["RecipeName"] = recipename;
            r["CalorieCount"] = caloriecount;
            r["DateDrafted"] = datedrafted;
            Recipe.Save(dt, "Recipe");

            int newid = SQLUtility.GetFirstColumnFirstRowValueInt("select * from recipe where recipename = '" + recipename + "'");

            Assert.IsTrue(newid > 0, "recipe with recipename = " + recipename + " is not found in DB");
            TestContext.WriteLine("Recipe with " + recipename + " is found in DB with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeCuisine()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int cuisineid = GetFirstColumnFirstRowValueInt("select cuisineid from recipe where recipeid = " + recipeid);
            int cuisinecount = GetFirstColumnFirstRowValueInt("select total = count(*) from cuisine");
            TestContext.WriteLine("cuisineid for recipeid " + recipeid + " is " + cuisineid);
            if (cuisineid == cuisinecount)
            {
                cuisineid = cuisineid - 1;
            }
            else
            {
                cuisineid = cuisineid + 1;
            }
            TestContext.WriteLine("change cuisineid to " + cuisineid);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["CuisineId"] = cuisineid;
            Recipe.Save(dt, "Recipe");

            int newcuisineid = GetFirstColumnFirstRowValueInt("select cuisineid from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcuisineid == cuisineid, "cuisineid for recipe (" + recipeid + ") = " + newcuisineid);
            TestContext.WriteLine("cuisineid for recipe (" + recipeid + ") = " + newcuisineid);
        }

        [Test]
        public void ChangeExistingRecipeUser()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int usersid = GetFirstColumnFirstRowValueInt("select usersid from recipe where recipeid = " + recipeid);
            int userscount = GetFirstColumnFirstRowValueInt("select total = count(*) from users");
            TestContext.WriteLine("usersid for recipeid " + recipeid + " is " + usersid);
            if (usersid == userscount)
            {
                usersid = usersid - 1;
            }
            else
            {
                usersid = usersid + 1;
            }
            TestContext.WriteLine("change usersid to " + usersid);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["UsersId"] = usersid;
            Recipe.Save(dt, "Recipe");

            int newusersid = GetFirstColumnFirstRowValueInt("select usersid from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newusersid == usersid, "usersid for recipe (" + recipeid + ") = " + newusersid);
            TestContext.WriteLine("usersid for recipe (" + recipeid + ") = " + newusersid);
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);
            recipename = recipename + "added to name";
            TestContext.WriteLine("change recipename to " + recipename);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["RecipeName"] = recipename;
            Recipe.Save(dt, "Recipe");

            string newrecipename = GetFirstColumnFirstRowValueString("select recipename from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newrecipename == recipename, "recipename for recipe (" + recipeid + ") = " + newrecipename);
            TestContext.WriteLine("recipename for recipe (" + recipeid + ") = " + newrecipename);
        }

        [Test]
        public void ChangeExistingRecipeNameToInvalidNameNotUnique()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueString("select recipename from recipe where recipeid <> " + recipeid);
            string currentrecipename = GetFirstColumnFirstRowValueString("select recipename from recipe where recipeid = " + recipeid);
            Assume.That(recipename is not null, "Cannot run test because there are no other recipes in the DB");
            TestContext.WriteLine("Change recipename for recipeid " + recipeid + " from " + currentrecipename + " to " + recipename + " which is a recipe name already in use by a different recipe");

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["RecipeName"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeNameToInvalidNameBlank()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            string currentrecipename = GetFirstColumnFirstRowValueString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + currentrecipename);
            string newrecipename = "";
            TestContext.WriteLine("Change recipename for recipeid " + recipeid + " to " + newrecipename + " (blank)");

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["RecipeName"] = newrecipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeDateDrafted()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            DateTime datedrafted = GetFirstColumnFirstRowValueDate("select datedrafted from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("datedrafted for recipeid " + recipeid + " is " + datedrafted);
            datedrafted = datedrafted.AddDays(-1);
            TestContext.WriteLine("change datedrafted to " + datedrafted);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["DateDrafted"] = datedrafted;
            Recipe.Save(dt, "Recipe");

            DateTime newdatedrafted = GetFirstColumnFirstRowValueDate("select datedrafted from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newdatedrafted == datedrafted, "datedrafted for recipe (" + recipeid + ") = " + newdatedrafted);
            TestContext.WriteLine("datedrafted for recipe (" + recipeid + ") = " + newdatedrafted);
        }

        [Test]
        public void ChangeExistingRecipeCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int caloriecount = GetFirstColumnFirstRowValueInt("select caloriecount from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriecount for recipeid " + recipeid + " is " + caloriecount);
            caloriecount = caloriecount + 1;
            TestContext.WriteLine("change caloriecount to " + caloriecount);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["CalorieCount"] = caloriecount;
            Recipe.Save(dt, "Recipe");

            int newcaloriecount = GetFirstColumnFirstRowValueInt("select caloriecount from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcaloriecount == caloriecount, "caloriecount for recipe (" + recipeid + ") = " + newcaloriecount);
            TestContext.WriteLine("caloriecount for recipe (" + recipeid + ") = " + newcaloriecount);
        }

        [Test]
        public void ChangeExistingRecipeCalorieCountInvalid()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            int caloriecount = GetFirstColumnFirstRowValueInt("select caloriecount from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriecount for recipeid " + recipeid + " is " + caloriecount);
            int newcaloriecount = -1;
            TestContext.WriteLine("change caloriecount to " + newcaloriecount);

            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            dt.Rows[0]["CalorieCount"] = newcaloriecount;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeNOTPublishedorLessThan30DaysArchive()
        {
            string sql = @"select top 1 r.recipeid, RecipeName from recipe r
                left join recipeingredient ri on r.recipeid = ri.recipeid
                left join step s on r.recipeid = s.recipeid
                left join mealcourserecipe mcr on r.recipeid = mcr.recipeid
                left join cookbookrecipe cr on r.recipeid = cr.recipeid
                where mcr.mealcourserecipeid is null
                and cr.cookbookrecipeid is null
                and (r.RecipeStatus <> 'Published' or DateDiff(day, r.DateArchived, getdate()) > 30)";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = (string)dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "No recipes without related data that are not Published or > 30 days archived in DB, can't run test");
            TestContext.WriteLine("existing recipe without related data not Published or > 30 days archived, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.DeleteRecipe(dt);
            DataTable dtafterdelete = GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipePublishedorLessThan30DaysArchive()
        {
            string sql = @"select top 1 r.recipeid, RecipeName from recipe r
                left join recipeingredient ri on r.recipeid = ri.recipeid
                left join step s on r.recipeid = s.recipeid
                left join mealcourserecipe mcr on r.recipeid = mcr.recipeid
                left join cookbookrecipe cr on r.recipeid = cr.recipeid
                where mcr.mealcourserecipeid is null
                and cr.cookbookrecipeid is null
                and (r.RecipeStatus = 'Published' or DateDiff(day, r.DateArchived, getdate()) < 30)";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = (string)dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "No recipes (without related data) that are Published or < 30 days archived in DB, can't run test");
            TestContext.WriteLine("existing recipe (without related data) that is Published or < 30 days archived, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Assert.Throws<Exception>(() => Recipe.DeleteRecipe(dt));

            TestContext.WriteLine("Unable to delete recipe because of exception");
        }

        [Test]
        public void DeleteRecipeWithRelatedData()
        {
            DataTable dt = GetDataTable(string.Join(Environment.NewLine, $"select top 1 r.recipeid, RecipeName from recipe r ",
                $"join mealcourserecipe mcr on r.recipeid = mcr.recipeid ",
                $"join cookbookrecipe cr on r.recipeid = cr.recipeid "));
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = (string)dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "No recipes with related data in DB, can't run test");
            TestContext.WriteLine("existing recipe with related data, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Assert.Throws<Exception>(() => Recipe.DeleteRecipe(dt));

            TestContext.WriteLine("Unable to delete recipe because of exception");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, (int)dt.Rows[0]["recipeid"] + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        [Test]
        public void SearchRecipes()
        {
            string criterea = "a";
            int num = GetFirstColumnFirstRowValueInt("select total = count(*) from recipe where recipename like '%" + criterea + "%'");
            Assume.That(num > 0, "There are no recipes that match the search for " + criterea);
            TestContext.WriteLine(num + " recipes that match " + criterea);
            TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");
            DataTable dt = Recipe.SearchRecipe(criterea);
            int results = dt.Rows.Count;
            Assert.IsTrue(results == num, "Results of recipe search does not match number of recipes, " + results + "<>" + num);
            TestContext.WriteLine("Number of rows returned by recipe search is " + results);
        }

        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = GetFirstColumnFirstRowValueInt("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + cuisinecount);

            DataTable dt = Recipe.LoadListAll("CuisineGet");

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "number of rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Nunber of rows in Cuisine returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfUsers()
        {
            int userscount = GetFirstColumnFirstRowValueInt("select total = count(*) from users");
            Assume.That(userscount > 0, "No users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + userscount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + userscount);

            DataTable dt = Recipe.LoadListAll("UsersGet");

            Assert.IsTrue(dt.Rows.Count == userscount, "number of rows returned by app (" + dt.Rows.Count + ") <> " + userscount);
            TestContext.WriteLine("Nunber of rows in Users returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValueInt("select top 1 recipeid from recipe");
        }
    }
}