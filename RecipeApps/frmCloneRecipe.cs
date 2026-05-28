using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        int recipeid = 0;
        public frmCloneRecipe()
        {
            InitializeComponent();
            this.Shown += FrmCloneRecipe_Shown;
            btnClone.Click += BtnClone_Click;
        }

        private void FrmCloneRecipe_Shown(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dtrecipe = DataMaintenance.GetDataList("RecipeList", true);
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtrecipe, null, "Recipe");
        }

        private void CloneRecipe()
        {
            if (lstRecipeName.SelectedValue != null)
            {
                Application.UseWaitCursor = true;
                try
                {
                    int originalrecipeid;
                    bool result = int.TryParse(lstRecipeName.SelectedValue.ToString(), out originalrecipeid);
                    recipeid = originalrecipeid;
                    SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
                    SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
                    SQLUtility.ExecuteSQL(cmd);

                    recipeid = Convert.ToInt32(cmd.Parameters["@ClonedRecipeId"].Value);
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), recipeid);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }

        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
