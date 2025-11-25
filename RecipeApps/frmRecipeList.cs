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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
            this.Activated += FrmRecipeList_Activated;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipeList.DataSource = Recipe.LoadListAll("RecipeListGet");
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
        }

        private void ShowRecipeDetail(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain) 
            { 
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), id);
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetail(-1);
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeDetail(e.RowIndex);
        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeList.SelectedRows.Count > 0)
            {
                ShowRecipeDetail(gRecipeList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
