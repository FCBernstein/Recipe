namespace RecipeWinForms
{
    partial class frmRecipeDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDisplay));
            tblDislpayMain = new TableLayoutPanel();
            tblDisplayHeader = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCalorieCount = new Label();
            lblCaptionIngredientCount = new Label();
            lblIngredientCount = new Label();
            lblCaptionStepCount = new Label();
            lblStepCount = new Label();
            lblRecipeName = new Label();
            lblCalorieCount = new Label();
            tblDisplayIngredients = new TableLayoutPanel();
            lblCaptionIngredients = new Label();
            tblDisplaySteps = new TableLayoutPanel();
            lblCaptionSteps = new Label();
            tblDislpayMain.SuspendLayout();
            tblDisplayHeader.SuspendLayout();
            tblDisplayIngredients.SuspendLayout();
            tblDisplaySteps.SuspendLayout();
            SuspendLayout();
            // 
            // tblDislpayMain
            // 
            tblDislpayMain.ColumnCount = 1;
            tblDislpayMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDislpayMain.Controls.Add(tblDisplayHeader, 0, 0);
            tblDislpayMain.Controls.Add(tblDisplayIngredients, 0, 1);
            tblDislpayMain.Controls.Add(tblDisplaySteps, 0, 2);
            tblDislpayMain.Dock = DockStyle.Fill;
            tblDislpayMain.Location = new Point(0, 0);
            tblDislpayMain.Name = "tblDislpayMain";
            tblDislpayMain.RowCount = 3;
            tblDislpayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8596487F));
            tblDislpayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 52.63158F));
            tblDislpayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblDislpayMain.Size = new Size(914, 570);
            tblDislpayMain.TabIndex = 0;
            // 
            // tblDisplayHeader
            // 
            tblDisplayHeader.ColumnCount = 8;
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.13475F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.86525F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblDisplayHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tblDisplayHeader.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblDisplayHeader.Controls.Add(lblCaptionCalorieCount, 2, 0);
            tblDisplayHeader.Controls.Add(lblCaptionIngredientCount, 4, 0);
            tblDisplayHeader.Controls.Add(lblIngredientCount, 5, 0);
            tblDisplayHeader.Controls.Add(lblCaptionStepCount, 6, 0);
            tblDisplayHeader.Controls.Add(lblStepCount, 7, 0);
            tblDisplayHeader.Controls.Add(lblRecipeName, 1, 0);
            tblDisplayHeader.Controls.Add(lblCalorieCount, 3, 0);
            tblDisplayHeader.Dock = DockStyle.Fill;
            tblDisplayHeader.Location = new Point(3, 3);
            tblDisplayHeader.Name = "tblDisplayHeader";
            tblDisplayHeader.RowCount = 1;
            tblDisplayHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDisplayHeader.Size = new Size(908, 73);
            tblDisplayHeader.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(91, 19);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalorieCount
            // 
            lblCaptionCalorieCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCaptionCalorieCount.AutoSize = true;
            lblCaptionCalorieCount.Location = new Point(439, 54);
            lblCaptionCalorieCount.Name = "lblCaptionCalorieCount";
            lblCaptionCalorieCount.Size = new Size(97, 19);
            lblCaptionCalorieCount.TabIndex = 2;
            lblCaptionCalorieCount.Text = "Calorie Count";
            // 
            // lblCaptionIngredientCount
            // 
            lblCaptionIngredientCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCaptionIngredientCount.AutoSize = true;
            lblCaptionIngredientCount.Location = new Point(589, 54);
            lblCaptionIngredientCount.Name = "lblCaptionIngredientCount";
            lblCaptionIngredientCount.Size = new Size(120, 19);
            lblCaptionIngredientCount.TabIndex = 4;
            lblCaptionIngredientCount.Text = "Ingredient Count";
            // 
            // lblIngredientCount
            // 
            lblIngredientCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIngredientCount.AutoSize = true;
            lblIngredientCount.BackColor = Color.WhiteSmoke;
            lblIngredientCount.Location = new Point(715, 54);
            lblIngredientCount.Name = "lblIngredientCount";
            lblIngredientCount.Size = new Size(43, 19);
            lblIngredientCount.TabIndex = 5;
            // 
            // lblCaptionStepCount
            // 
            lblCaptionStepCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCaptionStepCount.AutoSize = true;
            lblCaptionStepCount.Location = new Point(772, 54);
            lblCaptionStepCount.Name = "lblCaptionStepCount";
            lblCaptionStepCount.Size = new Size(86, 19);
            lblCaptionStepCount.TabIndex = 6;
            lblCaptionStepCount.Text = "Step Count";
            // 
            // lblStepCount
            // 
            lblStepCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStepCount.AutoSize = true;
            lblStepCount.BackColor = Color.WhiteSmoke;
            lblStepCount.Location = new Point(864, 54);
            lblStepCount.Name = "lblStepCount";
            lblStepCount.Size = new Size(41, 19);
            lblStepCount.TabIndex = 7;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.WhiteSmoke;
            lblRecipeName.Location = new Point(181, 3);
            lblRecipeName.Margin = new Padding(3, 3, 3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(249, 19);
            lblRecipeName.TabIndex = 1;
            // 
            // lblCalorieCount
            // 
            lblCalorieCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCalorieCount.AutoSize = true;
            lblCalorieCount.BackColor = Color.WhiteSmoke;
            lblCalorieCount.Location = new Point(542, 54);
            lblCalorieCount.Name = "lblCalorieCount";
            lblCalorieCount.Size = new Size(40, 19);
            lblCalorieCount.TabIndex = 3;
            // 
            // tblDisplayIngredients
            // 
            tblDisplayIngredients.AutoSize = true;
            tblDisplayIngredients.ColumnCount = 1;
            tblDisplayIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDisplayIngredients.Controls.Add(lblCaptionIngredients, 0, 0);
            tblDisplayIngredients.Dock = DockStyle.Fill;
            tblDisplayIngredients.Location = new Point(3, 82);
            tblDisplayIngredients.Name = "tblDisplayIngredients";
            tblDisplayIngredients.RowCount = 2;
            tblDisplayIngredients.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblDisplayIngredients.RowStyles.Add(new RowStyle());
            tblDisplayIngredients.Size = new Size(908, 294);
            tblDisplayIngredients.TabIndex = 1;
            // 
            // lblCaptionIngredients
            // 
            lblCaptionIngredients.Anchor = AnchorStyles.Left;
            lblCaptionIngredients.AutoSize = true;
            lblCaptionIngredients.Location = new Point(3, 4);
            lblCaptionIngredients.Margin = new Padding(3, 3, 3, 0);
            lblCaptionIngredients.Name = "lblCaptionIngredients";
            lblCaptionIngredients.Size = new Size(88, 19);
            lblCaptionIngredients.TabIndex = 0;
            lblCaptionIngredients.Text = "Ingredients:";
            // 
            // tblDisplaySteps
            // 
            tblDisplaySteps.AutoSize = true;
            tblDisplaySteps.ColumnCount = 1;
            tblDisplaySteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDisplaySteps.Controls.Add(lblCaptionSteps, 0, 0);
            tblDisplaySteps.Dock = DockStyle.Fill;
            tblDisplaySteps.Location = new Point(3, 382);
            tblDisplaySteps.Name = "tblDisplaySteps";
            tblDisplaySteps.RowCount = 2;
            tblDisplaySteps.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblDisplaySteps.RowStyles.Add(new RowStyle());
            tblDisplaySteps.Size = new Size(908, 185);
            tblDisplaySteps.TabIndex = 2;
            // 
            // lblCaptionSteps
            // 
            lblCaptionSteps.Anchor = AnchorStyles.Left;
            lblCaptionSteps.AutoSize = true;
            lblCaptionSteps.Location = new Point(3, 4);
            lblCaptionSteps.Margin = new Padding(3, 3, 3, 0);
            lblCaptionSteps.Name = "lblCaptionSteps";
            lblCaptionSteps.Size = new Size(54, 19);
            lblCaptionSteps.TabIndex = 0;
            lblCaptionSteps.Text = "Steps:";
            // 
            // frmRecipeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(tblDislpayMain);
            Font = new Font("Tekton Pro", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecipeDisplay";
            Text = "Recipe Display";
            tblDislpayMain.ResumeLayout(false);
            tblDislpayMain.PerformLayout();
            tblDisplayHeader.ResumeLayout(false);
            tblDisplayHeader.PerformLayout();
            tblDisplayIngredients.ResumeLayout(false);
            tblDisplayIngredients.PerformLayout();
            tblDisplaySteps.ResumeLayout(false);
            tblDisplaySteps.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDislpayMain;
        private TableLayoutPanel tblDisplayHeader;
        private Label lblCaptionRecipeName;
        private Label lblRecipeName;
        private Label lblCaptionCalorieCount;
        private Label lblCalorieCount;
        private Label lblCaptionIngredientCount;
        private Label lblIngredientCount;
        private Label lblCaptionStepCount;
        private Label lblStepCount;
        private TableLayoutPanel tblDisplayIngredients;
        private TableLayoutPanel tblDisplaySteps;
        private Label lblCaptionIngredients;
        private Label lblCaptionSteps;
    }
}