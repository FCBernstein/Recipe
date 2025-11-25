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
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            this.Shown += FrmRecipeDetail_Shown;
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Recipe.Save(dtrecipe);
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = DataMaintenance.GetDataList("Users",true);
            DataTable dtcuisine = DataMaintenance.GetDataList("Cuisine", true);
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
            WindowsFormsUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasurementTypeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            //still read only even after this
            gIngredients.Columns["Amount"].DisplayIndex = 0;
            gIngredients.Columns["RISequence"].DisplayIndex = 3;
            gIngredients.Columns[0].ReadOnly = false;
            gIngredients.Columns[3].ReadOnly = false;

        }

        private void LoadSteps()
        {
            dtsteps = Recipe.LoadByRecipeId(recipeid, "RecipeStepGet");
            gSteps.Columns.Clear();
            gSteps.DataSource = dtsteps;
            foreach (DataColumn col in dtsteps.Columns)
            {
                if (col.ReadOnly == true)
                {
                    col.ReadOnly = false;
                }
            }
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "Step");
            gSteps.Columns["StepDetail"].DisplayIndex = 0;
            gSteps.Columns["StepSequence"].DisplayIndex = 1;
            gSteps.Columns[0].ReadOnly = false;
            gSteps.Columns[1].ReadOnly = false;
            gSteps.Columns[2].ReadOnly = false;
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
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus));
            }
        }
    }
}
