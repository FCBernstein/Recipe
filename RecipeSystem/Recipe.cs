using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select RecipeID, RecipeName from recipe r where r.RecipeName like '%" + recipename + "%'";
            
            DataTable recipenamesdt = SQLUtility.GetDataTable(sql);
            return recipenamesdt;
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            string sql = "select r.*, c.CuisineName, u.UserName from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join Users u on r.UsersId = u.UsersId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineId, CuisineName from Cuisine");
        }

        public static DataTable GetUsersList()
        {
            return SQLUtility.GetDataTable("select UsersId, UserName from Users");
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                    $"update Recipe set",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"UsersId = '{r["UsersId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"CalorieCount = '{r["CalorieCount"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(CuisineId, UsersId, RecipeName, CalorieCount, DateDrafted) ";
                sql += $"select '{r["CuisineId"]}', '{r["UsersId"]}', '{r["RecipeName"]}', '{r["CalorieCount"]}', '{r["DateDrafted"]}'";
            }

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
