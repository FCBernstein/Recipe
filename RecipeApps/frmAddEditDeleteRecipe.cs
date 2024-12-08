using CPUFramework;
using CPUWindowsFormFramework;
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
        public frmAddEditDeleteRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        
        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.CuisineName, u.UserName from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join Users u on r.UsersId = u.UsersId where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineId, CuisineName from Cuisine");
            DataTable dtusers = SQLUtility.GetDataTable("select UsersId, UserName from Users");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalorieCount, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, 
                    $"update Recipe set",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"UsersId = '{r["UsersId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"CalorieCount = '{r["CalorieCount"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}',",
                    $"DatePublished = '{r["DatePublished"]}',",
                    $"DateArchived = '{r["DateArchived"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(CuisineId, UsersId, RecipeName, CalorieCount, DateDrafted, DatePublished, DateArchived) ";
                sql += $"select '{r["CuisineId"]}', '{r["UsersId"]}', '{r["RecipeName"]}', '{r["CalorieCount"]}', '{r["DateDrafted"]}', '{r["DatePublished"]}', '{r["DateArchived"]}'";
            }
            
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
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
