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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Recipe.GetDashboard();
            gTypeCount.Columns.Clear();
            gTypeCount.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gTypeCount, "");
        }

        private void ShowListForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowListForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowListForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowListForm(typeof(frmRecipeList));
        }
 
    }
}
