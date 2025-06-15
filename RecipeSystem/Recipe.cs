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
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
            
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
