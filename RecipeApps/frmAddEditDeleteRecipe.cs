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
    public partial class frmAddEditDeleteRecipe : Form
    {
        DataTable dtrecipe;
        BindingSource rbindsource = new BindingSource();
        public frmAddEditDeleteRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.LoadRecipe(recipeid);
            rbindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtusers = Recipe.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, rbindsource);
            WindowsFormsUtility.SetControlBinding(txtCalorieCount, rbindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, rbindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, rbindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, rbindsource);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this reicpe?", "Hearthy Hearth Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
