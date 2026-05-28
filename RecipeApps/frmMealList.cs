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
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gMealList.DataSource = Recipe.LoadListAll("MealGet");
            WindowsFormsUtility.FormatGridForSearchResults(gMealList, "Meal");
        }
    }
}
