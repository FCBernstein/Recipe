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

        public static DataTable LoadByRecipeId(int recipeid, string sprocname)
        {
            DataTable loadrecipedt = new();
            SqlCommand lrcmd = SQLUtility.GetSQLCommand(sprocname);
            lrcmd.Parameters["@RecipeId"].Value = recipeid;
            loadrecipedt = SQLUtility.GetDataTable(lrcmd);
            return loadrecipedt;
        }

        public static DataTable LoadListAll(string sprocname)
        {
            DataTable listdt = new();
            SqlCommand listcmd = SQLUtility.GetSQLCommand(sprocname);
            listcmd.Parameters["@All"].Value = 1;
            listdt = SQLUtility.GetDataTable(listcmd);
            return listdt;
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

        public static DataTable GetDashboard()
        {
            SqlCommand getdcmd = SQLUtility.GetSQLCommand("DashboardGet");
            return SQLUtility.GetDataTable(getdcmd);
        }
    }
}
