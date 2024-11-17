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
    public partial class frmRecipeDisplay : Form
    {
        int tblingrow = 1;
        int tblsteprow = 1;
        public frmRecipeDisplay()
        {
            InitializeComponent();
        }

        public void ShowRecipeDetailsForm(int recipeid)
        {
            string sqlheader = "select r.RecipeName, r.CalorieCount, IngredientCount = count(distinct ri.RecipeIngredientId), StepCount = count(distinct s.StepId) from Step s join Recipe r on s.RecipeId = r.RecipeId join RecipeIngredient ri on r.RecipeId = ri.RecipeId where r.RecipeID =" + recipeid.ToString() + " group by r.RecipeName, r.CalorieCount";
            DataTable recipeheaderdt = SQLUtility.GetDataTable(sqlheader);
            lblRecipeName.DataBindings.Add("Text", recipeheaderdt, "RecipeName");
            lblCalorieCount.DataBindings.Add("Text", recipeheaderdt, "CalorieCount");
            lblIngredientCount.DataBindings.Add("Text", recipeheaderdt, "IngredientCount");
            lblStepCount.DataBindings.Add("Text", recipeheaderdt, "StepCount");

            string sqlingredients = "select IngredientList = case when ri.Amount is null then concat(i.IngredientName, ' ', m.MeasurementTypeName) else concat(ri.Amount, ' ', m.MeasurementTypeName, ' ', i.IngredientName) end from Recipe r join RecipeIngredient ri on r.RecipeId = ri.RecipeId join Ingredient i on ri.IngredientId = i.IngredientId join MeasurementType m on m.MeasurementTypeId = ri.MeasurementTypeId where r.RecipeID =" + recipeid.ToString() + " order by ri.RISequence";
            DataTable ingredientdt = SQLUtility.GetDataTable(sqlingredients);
            foreach (DataRow ingredient in ingredientdt.Rows)
            {
                Label lblingredient = new Label() { Text = ingredient["IngredientList"].ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.TopLeft };
                tblDisplayIngredients.Controls.Add(lblingredient, 0, tblingrow);
                tblingrow++;
            }

            string sqlsteps = "select s.StepDetail from Recipe r join Step s on r.RecipeId = s.RecipeId where r.RecipeID =" + recipeid.ToString() + " order by s.StepSequence";
            DataTable stepsdt = SQLUtility.GetDataTable(sqlsteps);
            foreach (DataRow step in stepsdt.Rows)
            {
                Label lblstep = new() { Text = step["StepDetail"].ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.TopLeft };
                tblDisplaySteps.Controls.Add(lblstep, 0, tblsteprow);
                tblsteprow++;
            }
            this.Show();
        }
    }
}
