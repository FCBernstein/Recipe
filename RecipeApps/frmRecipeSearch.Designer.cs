namespace RecipeWinForms
{
    partial class frmRecipeSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeSearch));
            tblSearchMain = new TableLayoutPanel();
            tblSearchHeader = new TableLayoutPanel();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            btnSearch = new Button();
            gRecipe = new DataGridView();
            tblSearchMain.SuspendLayout();
            tblSearchHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblSearchMain
            // 
            tblSearchMain.ColumnCount = 1;
            tblSearchMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSearchMain.Controls.Add(tblSearchHeader, 0, 0);
            tblSearchMain.Controls.Add(gRecipe, 0, 1);
            tblSearchMain.Dock = DockStyle.Fill;
            tblSearchMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblSearchMain.Location = new Point(0, 0);
            tblSearchMain.Margin = new Padding(4);
            tblSearchMain.Name = "tblSearchMain";
            tblSearchMain.RowCount = 2;
            tblSearchMain.RowStyles.Add(new RowStyle());
            tblSearchMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSearchMain.Size = new Size(420, 448);
            tblSearchMain.TabIndex = 0;
            // 
            // tblSearchHeader
            // 
            tblSearchHeader.Anchor = AnchorStyles.Left;
            tblSearchHeader.AutoSize = true;
            tblSearchHeader.ColumnCount = 3;
            tblSearchHeader.ColumnStyles.Add(new ColumnStyle());
            tblSearchHeader.ColumnStyles.Add(new ColumnStyle());
            tblSearchHeader.ColumnStyles.Add(new ColumnStyle());
            tblSearchHeader.Controls.Add(lblRecipeName, 0, 0);
            tblSearchHeader.Controls.Add(txtRecipeName, 1, 0);
            tblSearchHeader.Controls.Add(btnSearch, 2, 0);
            tblSearchHeader.Font = new Font("Tekton Pro", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tblSearchHeader.Location = new Point(4, 4);
            tblSearchHeader.Margin = new Padding(4);
            tblSearchHeader.Name = "tblSearchHeader";
            tblSearchHeader.RowCount = 1;
            tblSearchHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSearchHeader.Size = new Size(388, 41);
            tblSearchHeader.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(4, 11);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(91, 19);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Left;
            txtRecipeName.Location = new Point(103, 7);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(155, 27);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(266, 4);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 52);
            gRecipe.Name = "gRecipe";
            gRecipe.Size = new Size(414, 393);
            gRecipe.TabIndex = 1;
            // 
            // frmRecipeSearch
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 448);
            Controls.Add(tblSearchMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmRecipeSearch";
            Text = "Recipe Search";
            tblSearchMain.ResumeLayout(false);
            tblSearchMain.PerformLayout();
            tblSearchHeader.ResumeLayout(false);
            tblSearchHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblSearchMain;
        private TableLayoutPanel tblSearchHeader;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private DataGridView gRecipe;
    }
}