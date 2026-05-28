namespace RecipeWinForms
{
    partial class frmCookbookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookbookDetails));
            tblMain = new TableLayoutPanel();
            tblCookbookInfo = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            txtCookbookName = new TextBox();
            lblUser = new Label();
            lstUserName = new ComboBox();
            lblDateCreated = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            txtCBCreateDate = new TextBox();
            lblActive = new Label();
            chkCookbookActive = new CheckBox();
            tblCookbookRecipeInfo = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            gCbrecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblCookbookInfo.SuspendLayout();
            tblCookbookRecipeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCbrecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblCookbookInfo, 0, 0);
            tblMain.Controls.Add(tblCookbookRecipeInfo, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(618, 790);
            tblMain.TabIndex = 0;
            // 
            // tblCookbookInfo
            // 
            tblCookbookInfo.ColumnCount = 3;
            tblCookbookInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCookbookInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCookbookInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCookbookInfo.Controls.Add(btnSave, 0, 0);
            tblCookbookInfo.Controls.Add(btnDelete, 1, 0);
            tblCookbookInfo.Controls.Add(lblCookbookName, 0, 1);
            tblCookbookInfo.Controls.Add(txtCookbookName, 1, 1);
            tblCookbookInfo.Controls.Add(lblUser, 0, 2);
            tblCookbookInfo.Controls.Add(lstUserName, 1, 2);
            tblCookbookInfo.Controls.Add(lblDateCreated, 2, 3);
            tblCookbookInfo.Controls.Add(lblPrice, 0, 4);
            tblCookbookInfo.Controls.Add(txtPrice, 1, 4);
            tblCookbookInfo.Controls.Add(txtCBCreateDate, 2, 4);
            tblCookbookInfo.Controls.Add(lblActive, 0, 5);
            tblCookbookInfo.Controls.Add(chkCookbookActive, 1, 5);
            tblCookbookInfo.Dock = DockStyle.Fill;
            tblCookbookInfo.Location = new Point(3, 3);
            tblCookbookInfo.Name = "tblCookbookInfo";
            tblCookbookInfo.RowCount = 6;
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.RowStyles.Add(new RowStyle());
            tblCookbookInfo.Size = new Size(612, 254);
            tblCookbookInfo.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(10, 10);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(214, 10);
            btnDelete.Margin = new Padding(10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(10, 63);
            lblCookbookName.Margin = new Padding(10, 10, 3, 10);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(141, 20);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblCookbookInfo.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Location = new Point(207, 60);
            txtCookbookName.Margin = new Padding(3, 10, 10, 10);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(395, 27);
            txtCookbookName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(10, 111);
            lblUser.Margin = new Padding(10, 10, 3, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblCookbookInfo.SetColumnSpan(lstUserName, 2);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(207, 107);
            lstUserName.Margin = new Padding(3, 10, 10, 10);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(395, 28);
            lstUserName.TabIndex = 5;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(411, 148);
            lblDateCreated.Margin = new Padding(3);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(198, 20);
            lblDateCreated.TabIndex = 6;
            lblDateCreated.Text = "Date Created:";
            lblDateCreated.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 177);
            lblPrice.Margin = new Padding(10, 0, 3, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(207, 174);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtCBCreateDate
            // 
            txtCBCreateDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCBCreateDate.Enabled = false;
            txtCBCreateDate.Location = new Point(428, 174);
            txtCBCreateDate.Margin = new Padding(20, 3, 20, 3);
            txtCBCreateDate.Name = "txtCBCreateDate";
            txtCBCreateDate.Size = new Size(164, 27);
            txtCBCreateDate.TabIndex = 9;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.BackColor = SystemColors.Control;
            lblActive.Location = new Point(10, 214);
            lblActive.Margin = new Padding(10, 10, 3, 10);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(64, 20);
            lblActive.TabIndex = 10;
            lblActive.Text = "Active";
            // 
            // chkCookbookActive
            // 
            chkCookbookActive.AutoSize = true;
            chkCookbookActive.Location = new Point(207, 214);
            chkCookbookActive.Margin = new Padding(3, 10, 3, 10);
            chkCookbookActive.Name = "chkCookbookActive";
            chkCookbookActive.Size = new Size(15, 14);
            chkCookbookActive.TabIndex = 11;
            chkCookbookActive.UseVisualStyleBackColor = true;
            // 
            // tblCookbookRecipeInfo
            // 
            tblCookbookRecipeInfo.ColumnCount = 1;
            tblCookbookRecipeInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbookRecipeInfo.Controls.Add(btnSaveRecipe, 0, 0);
            tblCookbookRecipeInfo.Controls.Add(gCbrecipe, 0, 1);
            tblCookbookRecipeInfo.Dock = DockStyle.Fill;
            tblCookbookRecipeInfo.Location = new Point(3, 263);
            tblCookbookRecipeInfo.Name = "tblCookbookRecipeInfo";
            tblCookbookRecipeInfo.RowCount = 2;
            tblCookbookRecipeInfo.RowStyles.Add(new RowStyle());
            tblCookbookRecipeInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbookRecipeInfo.Size = new Size(612, 524);
            tblCookbookRecipeInfo.TabIndex = 1;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(10, 10);
            btnSaveRecipe.Margin = new Padding(10);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(90, 30);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "S&ave";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gCbrecipe
            // 
            gCbrecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCbrecipe.Dock = DockStyle.Fill;
            gCbrecipe.Location = new Point(3, 53);
            gCbrecipe.Name = "gCbrecipe";
            gCbrecipe.Size = new Size(606, 468);
            gCbrecipe.TabIndex = 1;
            // 
            // frmCookbookDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 790);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmCookbookDetails";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblCookbookInfo.ResumeLayout(false);
            tblCookbookInfo.PerformLayout();
            tblCookbookRecipeInfo.ResumeLayout(false);
            tblCookbookRecipeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCbrecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblCookbookInfo;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private TextBox txtCookbookName;
        private Label lblUser;
        private ComboBox lstUserName;
        private Label lblDateCreated;
        private Label lblPrice;
        private TextBox txtPrice;
        private TextBox txtCBCreateDate;
        private Label lblActive;
        private CheckBox chkCookbookActive;
        private TableLayoutPanel tblCookbookRecipeInfo;
        private Button btnSaveRecipe;
        private DataGridView gCbrecipe;
    }
}