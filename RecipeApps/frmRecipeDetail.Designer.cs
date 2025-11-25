namespace RecipeWinForms
{
    partial class frmRecipeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetail));
            tblMain = new TableLayoutPanel();
            tblTopButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            tblRecipeHeaderData = new TableLayoutPanel();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblUser = new Label();
            lstUser = new ComboBox();
            lblCuisine = new Label();
            lstCuisineName = new ComboBox();
            lblNumCalories = new Label();
            txtCalorieCount = new TextBox();
            lblCurrentStatus = new Label();
            txtRecipeStatus = new TextBox();
            tblStatus = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblDateArchived = new Label();
            tbRecipeDetails = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            tblTopButtons.SuspendLayout();
            tblRecipeHeaderData.SuspendLayout();
            tblStatus.SuspendLayout();
            tbRecipeDetails.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblTopButtons, 0, 0);
            tblMain.Controls.Add(tblRecipeHeaderData, 0, 1);
            tblMain.Controls.Add(tbRecipeDetails, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(797, 953);
            tblMain.TabIndex = 0;
            // 
            // tblTopButtons
            // 
            tblTopButtons.AutoSize = true;
            tblTopButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblTopButtons.ColumnCount = 3;
            tblTopButtons.ColumnStyles.Add(new ColumnStyle());
            tblTopButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTopButtons.ColumnStyles.Add(new ColumnStyle());
            tblTopButtons.Controls.Add(btnSave, 0, 0);
            tblTopButtons.Controls.Add(btnDelete, 1, 0);
            tblTopButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblTopButtons.Dock = DockStyle.Fill;
            tblTopButtons.Location = new Point(3, 3);
            tblTopButtons.Name = "tblTopButtons";
            tblTopButtons.RowCount = 1;
            tblTopButtons.RowStyles.Add(new RowStyle());
            tblTopButtons.Size = new Size(791, 50);
            tblTopButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 10);
            btnSave.Margin = new Padding(3, 10, 3, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(84, 10);
            btnDelete.Margin = new Padding(3, 10, 3, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Left;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(639, 10);
            btnChangeStatus.Margin = new Padding(3, 10, 3, 10);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(149, 30);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "&Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tblRecipeHeaderData
            // 
            tblRecipeHeaderData.AutoSize = true;
            tblRecipeHeaderData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblRecipeHeaderData.ColumnCount = 2;
            tblRecipeHeaderData.ColumnStyles.Add(new ColumnStyle());
            tblRecipeHeaderData.ColumnStyles.Add(new ColumnStyle());
            tblRecipeHeaderData.Controls.Add(lblRecipeName, 0, 0);
            tblRecipeHeaderData.Controls.Add(txtRecipeName, 1, 0);
            tblRecipeHeaderData.Controls.Add(lblUser, 0, 1);
            tblRecipeHeaderData.Controls.Add(lstUser, 1, 1);
            tblRecipeHeaderData.Controls.Add(lblCuisine, 0, 2);
            tblRecipeHeaderData.Controls.Add(lstCuisineName, 1, 2);
            tblRecipeHeaderData.Controls.Add(lblNumCalories, 0, 3);
            tblRecipeHeaderData.Controls.Add(txtCalorieCount, 1, 3);
            tblRecipeHeaderData.Controls.Add(lblCurrentStatus, 0, 4);
            tblRecipeHeaderData.Controls.Add(txtRecipeStatus, 1, 4);
            tblRecipeHeaderData.Controls.Add(tblStatus, 0, 5);
            tblRecipeHeaderData.Dock = DockStyle.Fill;
            tblRecipeHeaderData.Location = new Point(3, 59);
            tblRecipeHeaderData.Name = "tblRecipeHeaderData";
            tblRecipeHeaderData.RowCount = 6;
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle());
            tblRecipeHeaderData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblRecipeHeaderData.Size = new Size(791, 226);
            tblRecipeHeaderData.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 6);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(117, 20);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeName.Location = new Point(161, 3);
            txtRecipeName.Margin = new Padding(10, 3, 10, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(620, 27);
            txtRecipeName.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 40);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // lstUser
            // 
            lstUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(161, 36);
            lstUser.Margin = new Padding(10, 3, 10, 3);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(620, 28);
            lstUser.TabIndex = 3;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 74);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(70, 20);
            lblCuisine.TabIndex = 4;
            lblCuisine.Text = "Cuisine";
            // 
            // lstCuisineName
            // 
            lstCuisineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(161, 70);
            lstCuisineName.Margin = new Padding(10, 3, 10, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(620, 28);
            lstCuisineName.TabIndex = 5;
            // 
            // lblNumCalories
            // 
            lblNumCalories.Anchor = AnchorStyles.Left;
            lblNumCalories.AutoSize = true;
            lblNumCalories.Location = new Point(3, 107);
            lblNumCalories.Name = "lblNumCalories";
            lblNumCalories.Size = new Size(116, 20);
            lblNumCalories.TabIndex = 6;
            lblNumCalories.Text = "NumCalories";
            // 
            // txtCalorieCount
            // 
            txtCalorieCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCalorieCount.Location = new Point(161, 104);
            txtCalorieCount.Margin = new Padding(10, 3, 10, 3);
            txtCalorieCount.Name = "txtCalorieCount";
            txtCalorieCount.Size = new Size(620, 27);
            txtCalorieCount.TabIndex = 7;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 140);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(145, 20);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecipeStatus.Location = new Point(161, 137);
            txtRecipeStatus.Margin = new Padding(10, 3, 10, 3);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(620, 27);
            txtRecipeStatus.TabIndex = 9;
            // 
            // tblStatus
            // 
            tblStatus.AutoSize = true;
            tblStatus.ColumnCount = 4;
            tblRecipeHeaderData.SetColumnSpan(tblStatus, 2);
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.Controls.Add(lblStatusDates, 0, 1);
            tblStatus.Controls.Add(lblDateDrafted, 1, 0);
            tblStatus.Controls.Add(lblDatePublished, 2, 0);
            tblStatus.Controls.Add(txtDateDrafted, 1, 1);
            tblStatus.Controls.Add(txtDatePublished, 2, 1);
            tblStatus.Controls.Add(txtDateArchived, 3, 1);
            tblStatus.Controls.Add(lblDateArchived, 3, 0);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(3, 170);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.Size = new Size(785, 53);
            tblStatus.TabIndex = 10;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 20);
            lblStatusDates.MinimumSize = new Size(145, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(145, 20);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "StatusDates";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(154, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(78, 20);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.Text = "Drafted";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(260, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(90, 20);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.Text = "Published";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Location = new Point(154, 23);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(100, 27);
            txtDateDrafted.TabIndex = 4;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(260, 23);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(100, 27);
            txtDatePublished.TabIndex = 5;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(366, 23);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(100, 27);
            txtDateArchived.TabIndex = 6;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(366, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(83, 20);
            lblDateArchived.TabIndex = 3;
            lblDateArchived.Text = "Archived";
            // 
            // tbRecipeDetails
            // 
            tbRecipeDetails.Controls.Add(tbIngredients);
            tbRecipeDetails.Controls.Add(tbSteps);
            tbRecipeDetails.Dock = DockStyle.Fill;
            tbRecipeDetails.Location = new Point(3, 291);
            tbRecipeDetails.Name = "tbRecipeDetails";
            tbRecipeDetails.SelectedIndex = 0;
            tbRecipeDetails.Size = new Size(791, 659);
            tbRecipeDetails.TabIndex = 2;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 29);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(783, 626);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.AutoSize = true;
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.Size = new Size(777, 620);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.AutoSize = true;
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(75, 30);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 39);
            gIngredients.Name = "gIngredients";
            gIngredients.Size = new Size(771, 578);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(783, 626);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.AutoSize = true;
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.Size = new Size(777, 620);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(90, 30);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 39);
            gSteps.Name = "gSteps";
            gSteps.Size = new Size(771, 614);
            gSteps.TabIndex = 1;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(797, 953);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmRecipeDetail";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblTopButtons.ResumeLayout(false);
            tblTopButtons.PerformLayout();
            tblRecipeHeaderData.ResumeLayout(false);
            tblRecipeHeaderData.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tbRecipeDetails.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tbIngredients.PerformLayout();
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tbSteps.PerformLayout();
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblTopButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
        private TableLayoutPanel tblRecipeHeaderData;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Label lblUser;
        private ComboBox lstUser;
        private Label lblCuisine;
        private ComboBox lstCuisineName;
        private Label lblNumCalories;
        private TextBox txtCalorieCount;
        private Label lblCurrentStatus;
        private TextBox txtRecipeStatus;
        private TabControl tbRecipeDetails;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
        private TableLayoutPanel tblStatus;
        private Label lblStatusDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
    }
}