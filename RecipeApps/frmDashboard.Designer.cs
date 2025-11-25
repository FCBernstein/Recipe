namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            gTypeCount = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gTypeCount).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblTitle, 0, 0);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Controls.Add(gTypeCount, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(640, 525);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Tekton Pro Ext", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(634, 138);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hearty Hearth Desktop App";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(3, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(634, 138);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gTypeCount
            // 
            gTypeCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gTypeCount.Dock = DockStyle.Fill;
            gTypeCount.Location = new Point(3, 279);
            gTypeCount.Name = "gTypeCount";
            gTypeCount.Size = new Size(634, 132);
            gTypeCount.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 417);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(634, 105);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(149, 10);
            btnRecipeList.Margin = new Padding(3, 10, 3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(113, 30);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Top;
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(268, 10);
            btnMealList.Margin = new Padding(3, 10, 3, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(97, 30);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(371, 10);
            btnCookbookList.Margin = new Padding(3, 10, 3, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(137, 30);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 525);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gTypeCount).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblDescription;
        private DataGridView gTypeCount;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}