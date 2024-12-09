namespace RecipeWinForms
{
    partial class frmAddEditDeleteRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditDeleteRecipe));
            tsAddRecipe = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain = new TableLayoutPanel();
            lblAddRecipeHeading = new Label();
            tblRecipeData = new TableLayoutPanel();
            lblCuisineCaption = new Label();
            lblUserCaption = new Label();
            lblRecipeNameCaption = new Label();
            lblCalorieCountCaption = new Label();
            lblDateDraftedCaption = new Label();
            lblDatePublishedCaption = new Label();
            lblDateArchivedCaption = new Label();
            lstCuisineName = new ComboBox();
            lstUserName = new ComboBox();
            txtRecipeName = new TextBox();
            txtCalorieCount = new TextBox();
            dtpDateDrafted = new DateTimePicker();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tsAddRecipe.SuspendLayout();
            tblMain.SuspendLayout();
            tblRecipeData.SuspendLayout();
            SuspendLayout();
            // 
            // tsAddRecipe
            // 
            tsAddRecipe.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsAddRecipe.Location = new Point(0, 0);
            tsAddRecipe.Name = "tsAddRecipe";
            tsAddRecipe.Size = new Size(536, 26);
            tsAddRecipe.TabIndex = 0;
            tsAddRecipe.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Tekton Pro", 11.9999981F, FontStyle.Bold);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(45, 23);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 26);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Tekton Pro", 11.9999981F, FontStyle.Bold);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(55, 23);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 26);
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblAddRecipeHeading, 0, 0);
            tblMain.Controls.Add(tblRecipeData, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 26);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(536, 426);
            tblMain.TabIndex = 1;
            // 
            // lblAddRecipeHeading
            // 
            lblAddRecipeHeading.AutoSize = true;
            lblAddRecipeHeading.Dock = DockStyle.Fill;
            lblAddRecipeHeading.Location = new Point(4, 0);
            lblAddRecipeHeading.Margin = new Padding(4, 0, 4, 0);
            lblAddRecipeHeading.Name = "lblAddRecipeHeading";
            lblAddRecipeHeading.Size = new Size(528, 19);
            lblAddRecipeHeading.TabIndex = 0;
            lblAddRecipeHeading.Text = "Add Recipe Data:";
            lblAddRecipeHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblRecipeData
            // 
            tblRecipeData.ColumnCount = 2;
            tblRecipeData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeData.Controls.Add(lblCuisineCaption, 0, 0);
            tblRecipeData.Controls.Add(lblUserCaption, 0, 1);
            tblRecipeData.Controls.Add(lblRecipeNameCaption, 0, 2);
            tblRecipeData.Controls.Add(lblCalorieCountCaption, 0, 3);
            tblRecipeData.Controls.Add(lblDateDraftedCaption, 0, 4);
            tblRecipeData.Controls.Add(lblDatePublishedCaption, 0, 5);
            tblRecipeData.Controls.Add(lblDateArchivedCaption, 0, 6);
            tblRecipeData.Controls.Add(lstCuisineName, 1, 0);
            tblRecipeData.Controls.Add(lstUserName, 1, 1);
            tblRecipeData.Controls.Add(txtRecipeName, 1, 2);
            tblRecipeData.Controls.Add(txtCalorieCount, 1, 3);
            tblRecipeData.Controls.Add(dtpDateDrafted, 1, 4);
            tblRecipeData.Controls.Add(txtDatePublished, 1, 5);
            tblRecipeData.Controls.Add(txtDateArchived, 1, 6);
            tblRecipeData.Dock = DockStyle.Fill;
            tblRecipeData.Location = new Point(3, 22);
            tblRecipeData.Name = "tblRecipeData";
            tblRecipeData.RowCount = 7;
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tblRecipeData.Size = new Size(530, 401);
            tblRecipeData.TabIndex = 1;
            // 
            // lblCuisineCaption
            // 
            lblCuisineCaption.Anchor = AnchorStyles.Left;
            lblCuisineCaption.AutoSize = true;
            lblCuisineCaption.Location = new Point(3, 19);
            lblCuisineCaption.Name = "lblCuisineCaption";
            lblCuisineCaption.Size = new Size(59, 19);
            lblCuisineCaption.TabIndex = 0;
            lblCuisineCaption.Text = "Cuisine:";
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 76);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(84, 19);
            lblUserCaption.TabIndex = 1;
            lblUserCaption.Text = "User Name:";
            // 
            // lblRecipeNameCaption
            // 
            lblRecipeNameCaption.Anchor = AnchorStyles.Left;
            lblRecipeNameCaption.AutoSize = true;
            lblRecipeNameCaption.Location = new Point(3, 133);
            lblRecipeNameCaption.Name = "lblRecipeNameCaption";
            lblRecipeNameCaption.Size = new Size(95, 19);
            lblRecipeNameCaption.TabIndex = 2;
            lblRecipeNameCaption.Text = "Recipe Name:";
            // 
            // lblCalorieCountCaption
            // 
            lblCalorieCountCaption.Anchor = AnchorStyles.Left;
            lblCalorieCountCaption.AutoSize = true;
            lblCalorieCountCaption.Location = new Point(3, 190);
            lblCalorieCountCaption.Name = "lblCalorieCountCaption";
            lblCalorieCountCaption.Size = new Size(101, 19);
            lblCalorieCountCaption.TabIndex = 3;
            lblCalorieCountCaption.Text = "Calorie Count:";
            // 
            // lblDateDraftedCaption
            // 
            lblDateDraftedCaption.Anchor = AnchorStyles.Left;
            lblDateDraftedCaption.AutoSize = true;
            lblDateDraftedCaption.Location = new Point(3, 247);
            lblDateDraftedCaption.Name = "lblDateDraftedCaption";
            lblDateDraftedCaption.Size = new Size(102, 19);
            lblDateDraftedCaption.TabIndex = 4;
            lblDateDraftedCaption.Text = "Date Drafted:";
            // 
            // lblDatePublishedCaption
            // 
            lblDatePublishedCaption.Anchor = AnchorStyles.Left;
            lblDatePublishedCaption.AutoSize = true;
            lblDatePublishedCaption.Location = new Point(3, 304);
            lblDatePublishedCaption.Name = "lblDatePublishedCaption";
            lblDatePublishedCaption.Size = new Size(110, 19);
            lblDatePublishedCaption.TabIndex = 5;
            lblDatePublishedCaption.Text = "Date Published:";
            // 
            // lblDateArchivedCaption
            // 
            lblDateArchivedCaption.Anchor = AnchorStyles.Left;
            lblDateArchivedCaption.AutoSize = true;
            lblDateArchivedCaption.Location = new Point(3, 362);
            lblDateArchivedCaption.Name = "lblDateArchivedCaption";
            lblDateArchivedCaption.Size = new Size(105, 19);
            lblDateArchivedCaption.TabIndex = 6;
            lblDateArchivedCaption.Text = "Date Archived:";
            // 
            // lstCuisineName
            // 
            lstCuisineName.Anchor = AnchorStyles.Left;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(268, 17);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(121, 27);
            lstCuisineName.TabIndex = 7;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(268, 74);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(121, 27);
            lstUserName.TabIndex = 8;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left;
            txtRecipeName.Location = new Point(268, 129);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(259, 27);
            txtRecipeName.TabIndex = 9;
            // 
            // txtCalorieCount
            // 
            txtCalorieCount.Anchor = AnchorStyles.Left;
            txtCalorieCount.Location = new Point(268, 186);
            txtCalorieCount.Name = "txtCalorieCount";
            txtCalorieCount.Size = new Size(259, 27);
            txtCalorieCount.TabIndex = 10;
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Anchor = AnchorStyles.Left;
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(268, 243);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(200, 27);
            dtpDateDrafted.TabIndex = 11;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left;
            txtDatePublished.Enabled = false;
            txtDatePublished.Location = new Point(268, 300);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(259, 27);
            txtDatePublished.TabIndex = 12;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.Enabled = false;
            txtDateArchived.Location = new Point(268, 358);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(259, 27);
            txtDateArchived.TabIndex = 13;
            // 
            // frmAddEditDeleteRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 452);
            Controls.Add(tblMain);
            Controls.Add(tsAddRecipe);
            Font = new Font("Tekton Pro", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmAddEditDeleteRecipe";
            Text = "Add Recipe";
            tsAddRecipe.ResumeLayout(false);
            tsAddRecipe.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRecipeData.ResumeLayout(false);
            tblRecipeData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsAddRecipe;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private TableLayoutPanel tblMain;
        private Label lblAddRecipeHeading;
        private TableLayoutPanel tblRecipeData;
        private Label lblCuisineCaption;
        private Label lblUserCaption;
        private Label lblRecipeNameCaption;
        private Label lblCalorieCountCaption;
        private Label lblDateDraftedCaption;
        private Label lblDatePublishedCaption;
        private Label lblDateArchivedCaption;
        private ComboBox lstCuisineName;
        private ComboBox lstUserName;
        private TextBox txtRecipeName;
        private TextBox txtCalorieCount;
        private DateTimePicker dtpDateDrafted;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
    }
}