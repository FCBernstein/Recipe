using CPUFramework;
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
    public partial class frmRecipeDetail : Form
    {
        DataTable dtrecipe = new DataTable();
        DataTable dtingredients = new DataTable();
        DataTable dtsteps = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolumnname = "deletecol";
        int recipeid = 0;
        int usersid = 0;
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.Shown += FrmRecipeDetail_Shown;
            this.Activated += FrmRecipeDetail_Activated;
        }

        
        private void FrmRecipeDetail_Activated(object? sender, EventArgs e)
        {
            if (recipeid == 0) return;
            dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            bindsource.DataSource = dtrecipe;
        }

        public void RecipeLoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = DataMaintenance.GetDataList("UsersList",true);
            DataTable dtcuisine = DataMaintenance.GetDataList("CuisineList", true);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUser, dtusers, dtrecipe,"Users");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCalorieCount, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            this.Text = GetRecipeName();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void FrmRecipeDetail_Shown(object? sender, EventArgs e)
        {
            LoadIngredients();
            LoadSteps();
        }

        public void LoadIngredients()
        {
            dtingredients = Recipe.LoadByRecipeId(recipeid, "RecipeIngredientGet");
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtingredients;
            foreach (DataColumn col in dtingredients.Columns)
            {
                if (col.ReadOnly == true)
                {
                    col.ReadOnly = false;
                }
            }
            WindowsFormsUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("IngredientList"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementTypeList"), "MeasurementType", "MeasurementTypeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");

        }

        private void LoadSteps()
        {
            dtsteps = Recipe.LoadByRecipeId(recipeid, "RecipeStepGet");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtsteps;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "Step");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe, "Recipe");
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
                bindsource.DataSource = dtrecipe;
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
        }
        private string GetRecipeName()
        {
            string rname = "New Recipe";
            int pkval = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkval > 0) 
            {
                rname = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return rname;
        }

        private void DeleteRowFromGrid(int rowindex, DataGridView dgv, string tablename)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(dgv, rowindex, tablename + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(tablename, id);
                    if (dgv == gIngredients)
                    {
                        LoadIngredients();
                    }
                    else
                    {
                        LoadSteps();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < dgv.Rows.Count)
            {
                dgv.Rows.Remove(dgv.Rows[rowindex]);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Recipe.DeleteRecipe(dtrecipe);
            this.Close();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus), recipeid);
            }
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            Recipe.SaveTable(dtsteps, recipeid, "Step");
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            Recipe.SaveTable(dtingredients, recipeid, "RecipeIngredient");
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                DeleteRowFromGrid(e.RowIndex, gSteps, "Step");
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                DeleteRowFromGrid(e.RowIndex, gIngredients, "RecipeIngredient");
            }
        }



    }
}
