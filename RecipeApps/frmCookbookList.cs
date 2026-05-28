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
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick;
            gCookbook.KeyDown += GCookbook_KeyDown;
            this.Activated += FrmCookbookList_Activated;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gCookbook.DataSource = Recipe.LoadListAll("CookbookListGet");
            WindowsFormsUtility.FormatGridForSearchResults(gCookbook, "Cookbook");
        }

        private void ShowCookbookDetail(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbook, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetails), id);
            }
        }

        private void GCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbook.SelectedRows.Count > 0) 
            {
                ShowCookbookDetail(gCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookDetail(e.RowIndex);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookDetail(-1);
        }

    }
}
