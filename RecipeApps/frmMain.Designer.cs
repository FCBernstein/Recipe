namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipesList = new ToolStripMenuItem();
            mnuRecipesNew = new ToolStripMenuItem();
            mnuRecipesClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuCookbooksNew = new ToolStripMenuItem();
            mnuCookbooksAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuWindowsCascade = new ToolStripMenuItem();
            mnuWindowsTiled = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(884, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(49, 24);
            mnuFile.Text = "&File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(171, 24);
            mnuFileDashboard.Text = "&Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipesList, mnuRecipesNew, mnuRecipesClone });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(88, 24);
            mnuRecipes.Text = "&Recipes";
            // 
            // mnuRecipesList
            // 
            mnuRecipesList.Name = "mnuRecipesList";
            mnuRecipesList.Size = new Size(198, 24);
            mnuRecipesList.Text = "&List";
            // 
            // mnuRecipesNew
            // 
            mnuRecipesNew.Name = "mnuRecipesNew";
            mnuRecipesNew.Size = new Size(198, 24);
            mnuRecipesNew.Text = "New Reci&pe";
            // 
            // mnuRecipesClone
            // 
            mnuRecipesClone.Name = "mnuRecipesClone";
            mnuRecipesClone.Size = new Size(198, 24);
            mnuRecipesClone.Text = "Cl&one a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(72, 24);
            mnuMeals.Text = "&Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(112, 24);
            mnuMealsList.Text = "L&ist";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuCookbooksNew, mnuCookbooksAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(112, 24);
            mnuCookbooks.Text = "&Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(198, 24);
            mnuCookbooksList.Text = "Li&st";
            // 
            // mnuCookbooksNew
            // 
            mnuCookbooksNew.Name = "mnuCookbooksNew";
            mnuCookbooksNew.Size = new Size(198, 24);
            mnuCookbooksNew.Text = "New Coo&kbook";
            // 
            // mnuCookbooksAutoCreate
            // 
            mnuCookbooksAutoCreate.Name = "mnuCookbooksAutoCreate";
            mnuCookbooksAutoCreate.Size = new Size(198, 24);
            mnuCookbooksAutoCreate.Text = "A&uto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(178, 24);
            mnuDataMaintenance.Text = "Data Mai&ntenance";
            // 
            // mnuDataMaintenanceEditData
            // 
            mnuDataMaintenanceEditData.Name = "mnuDataMaintenanceEditData";
            mnuDataMaintenanceEditData.Size = new Size(162, 24);
            mnuDataMaintenanceEditData.Text = "&Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowsCascade, mnuWindowsTiled });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(96, 24);
            mnuWindows.Text = "&Windows";
            // 
            // mnuWindowsCascade
            // 
            mnuWindowsCascade.Name = "mnuWindowsCascade";
            mnuWindowsCascade.Size = new Size(152, 24);
            mnuWindowsCascade.Text = "C&ascade";
            // 
            // mnuWindowsTiled
            // 
            mnuWindowsTiled.Name = "mnuWindowsTiled";
            mnuWindowsTiled.Size = new Size(152, 24);
            mnuWindowsTiled.Text = "&Tiled";
            // 
            // tsMain
            // 
            tsMain.BackColor = SystemColors.ControlLightLight;
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(884, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 711);
            Controls.Add(tsMain);
            Controls.Add(menuStrip1);
            Font = new Font("Tekton Pro Ext", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuRecipesNew;
        private ToolStripMenuItem mnuRecipesClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuCookbooksNew;
        private ToolStripMenuItem mnuCookbooksAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuWindowsCascade;
        private ToolStripMenuItem mnuWindowsTiled;
        private ToolStrip tsMain;
    }
}