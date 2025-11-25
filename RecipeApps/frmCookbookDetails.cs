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
        BindingSource bindsource = new BindingSource();
        string deletecolumnname = "deletecol";
        int cookbookid = 0;
        public frmCookbookDetails()
        {
            InitializeComponent();
        }

        public void LoadForm(int recipeidval)
        {
            cookbookid = recipeidval;
            this.Tag = cookbookid;
            dtcookbook = Recipe.LoadByRecipeId(cookbookid, "CookbookGet");
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            /* still need to add cookbook data equivalents for:
             DataTable dtparties = President.GetPartyList();
            WindowsFormsUtility.SetListBinding(lstPartyName, dtparties, dtpresident, "Party");
            WindowsFormsUtility.SetControlBinding(txtNum, bindsource);
            WindowsFormsUtility.SetControlBinding(txtLastName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtFirstName, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateBorn, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDied, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermStart, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermEnd, bindsource);
            this.Text = GetPresidentDesc();
            LoadPresidentMedals();
            SetButtonsEnabledBasedOnNewRecord();
             */
        }
    }
}
