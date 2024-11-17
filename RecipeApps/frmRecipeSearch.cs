using CPUFramework;
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
            FormatGrid();
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select RecipeID, RecipeName from recipe r where r.RecipeName like '%" + recipename + "%'";
            Debug.Print(sql);
            DataTable recipenamesdt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = recipenamesdt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void DisplayRecipeDetail(int rowindex)
        {
            int recipeid = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            frmRecipeDisplay frm = new frmRecipeDisplay();
            frm.ShowRecipeDetailsForm(recipeid);
        }

        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            DisplayRecipeDetail(e.RowIndex);
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
    }
}
