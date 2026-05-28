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
    public partial class frmCookbookDetails : Form
    {
        DataTable dtcookbook= new DataTable();
        DataTable dtrecipes = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolumnname = "deletecol";
        int cookbookid = 0;
        public frmCookbookDetails()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gCbrecipe.CellContentClick += GCbrecipe_CellContentClick;
            this.Shown += FrmCookbookDetails_Shown;
            this.Activated += FrmCookbookDetails_Activated;
        }

        private void FrmCookbookDetails_Activated(object? sender, EventArgs e)
        {
            dtcookbook = Recipe.LoadByCookbookId(cookbookid, "CookbookGet");
            bindsource.DataSource = dtcookbook;
        }

        private void FrmCookbookDetails_Shown(object? sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            dtrecipes = Recipe.LoadByCookbookId(cookbookid, "CookbookRecipeGet");
            gCbrecipe.Columns.Clear();
            gCbrecipe.DataSource = dtrecipes;
            WindowsFormsUtility.AddComboboxToGrid(gCbrecipe, DataMaintenance.GetDataList("RecipeList"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCbrecipe, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gCbrecipe, "CookbookRecipe");
        }

        private void GCbrecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gCbrecipe.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                DeleteRowFromGrid(e.RowIndex);
            }
        }

        private void DeleteRowFromGrid(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCbrecipe, rowIndex, "CookbookRecipe");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow("CookbookRecipe", id);
                    LoadRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowIndex < gCbrecipe.Rows.Count)
            {
                gCbrecipe.Rows.Remove(gCbrecipe.Rows[rowIndex]);
            }
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Recipe.LoadByCookbookId(cookbookid, "CookbookGet");
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusers = DataMaintenance.GetDataList("UsersList", true);
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtcookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCBCreateDate, bindsource);
            WindowsFormsUtility.SetControlBinding(chkCookbookActive, bindsource);
            
            
            /*
            this.Text = GetPresidentDesc();
            LoadPresidentMedals();
            SetButtonsEnabledBasedOnNewRecord();
             */
        }
    }
}
