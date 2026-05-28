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
    public partial class frmChangeRecipeStatus : Form
    {
        DataTable dtrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void ChangeStatusLoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            this.Text = this.Text + " - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            SetButtonEnabledOrDisabled();
        }

        private void SetButtonEnabledOrDisabled()
        {
            bindsource.ResetBindings(false);
            btnDraft.Enabled = true;
            btnPublish.Enabled = true;
            btnArchive.Enabled = true;
            DateTime drafted = SQLUtility.GetValueFromFirstRowAsDate(dtrecipe, "DateDrafted");
            DateTime published = SQLUtility.GetValueFromFirstRowAsDate(dtrecipe, "DatePublished");
            DateTime archived = SQLUtility.GetValueFromFirstRowAsDate(dtrecipe, "DateArchived");
            if (published == new DateTime() && archived == new DateTime())
            {
                btnDraft.Enabled = false;
            }
            else if (published != new DateTime() && archived == new DateTime())
            {
                btnPublish.Enabled = false;
            }
            else if (archived != new DateTime())
            {
                btnArchive.Enabled = false;
            }
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe, "Recipe");
                b = true;
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                dtrecipe = Recipe.LoadByRecipeId(recipeid, "RecipeGet");
                bindsource.DataSource = dtrecipe;
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
        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to change this recipe to Drafted?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Yes:
                    dtrecipe.Rows[0]["DateDrafted"] = DateTime.UtcNow;
                    dtrecipe.Rows[0]["DatePublished"] = DBNull.Value;
                    dtrecipe.Rows[0]["DateArchived"] = DBNull.Value;
                    bool b = Save();
                    if (b == false)
                    {
                        MessageBox.Show("Status Change was not successful. Please check connection to Database and/or if this update violated DB rules.");
                    }
                    break;
                default:return;
            }
           SetButtonEnabledOrDisabled();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to change this recipe to Published?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Yes:
                    dtrecipe.Rows[0]["DatePublished"] = DateTime.UtcNow;
                    dtrecipe.Rows[0]["DateArchived"] = DBNull.Value;
                    bool b = Save();
                    if (b == false)
                    {
                        MessageBox.Show("Status Change was not successful. Please check connection to Database and/or if this update violated DB rules.");
                    }
                    break;
                default: return;
            }
            SetButtonEnabledOrDisabled();
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to change this recipe to Archived", Application.ProductName, MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Yes:
                    dtrecipe.Rows[0]["DateArchived"] = DateTime.UtcNow;
                    bool b = Save();
                    if (b == false)
                    {
                        MessageBox.Show("Status Change was not successful. Please check connection to Database and/or if this update violated DB rules.");
                    }
                    break;
                default: return;
            }
            SetButtonEnabledOrDisabled(); 
        }
    }
}
