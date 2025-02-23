using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipeSearch : Form
    {
        public frmRecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe);
        }


        private void SearchForRecipe(string recipename)
        {
            DataTable recipenamesdt = Recipe.SearchRecipe(recipename);
            gRecipe.DataSource = recipenamesdt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowAddEditDeleteRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmAddEditDeleteRecipe frmaed = new frmAddEditDeleteRecipe();
            frmaed.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowAddEditDeleteRecipeForm(e.RowIndex);
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowAddEditDeleteRecipeForm(-1);
        }

    }
}
