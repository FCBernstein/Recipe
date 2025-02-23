using System.Data;



namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable recipenamesdt = new();
            SqlCommand srcmd = SQLUtility.GetSQLCommand("RecipeGet");
            srcmd.Parameters["@RecipeName"].Value = recipename;
            recipenamesdt = SQLUtility.GetDataTable(srcmd);
            return recipenamesdt;
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            DataTable loadrecipedt = new();
            SqlCommand lrcmd = SQLUtility.GetSQLCommand("RecipeGet");
            lrcmd.Parameters["@RecipeId"].Value = recipeid;
            loadrecipedt = SQLUtility.GetDataTable(lrcmd);
            return loadrecipedt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable cusinenamedt = new();
            SqlCommand gclcmd = SQLUtility.GetSQLCommand("CuisineGet");
            gclcmd.Parameters["@All"].Value = 1;
            cusinenamedt = SQLUtility.GetDataTable(gclcmd);
            return cusinenamedt;
        }

        public static DataTable GetUsersList()
        {
            DataTable usernamedt = new();
            SqlCommand gulcmd = SQLUtility.GetSQLCommand("UsersGet");
            gulcmd.Parameters["@All"].Value = 1;
            usernamedt = SQLUtility.GetDataTable(gulcmd);
            return usernamedt;
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
