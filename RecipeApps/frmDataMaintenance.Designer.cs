namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataMaintenance));
            tblMain = new TableLayoutPanel();
            pnlOptionButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            gData = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblMain.Controls.Add(pnlOptionButtons, 0, 0);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(725, 622);
            tblMain.TabIndex = 0;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Anchor = AnchorStyles.Left;
            pnlOptionButtons.Controls.Add(optUsers);
            pnlOptionButtons.Controls.Add(optCuisines);
            pnlOptionButtons.Controls.Add(optIngredients);
            pnlOptionButtons.Controls.Add(optMeasurements);
            pnlOptionButtons.Controls.Add(optCourses);
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(4, 4);
            pnlOptionButtons.Margin = new Padding(4);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Padding = new Padding(0, 25, 0, 0);
            tblMain.SetRowSpan(pnlOptionButtons, 2);
            pnlOptionButtons.Size = new Size(209, 614);
            pnlOptionButtons.TabIndex = 0;
            // 
            // optUsers
            // 
            optUsers.Anchor = AnchorStyles.Left;
            optUsers.AutoSize = true;
            optUsers.Location = new Point(4, 29);
            optUsers.Margin = new Padding(4);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(79, 24);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.Anchor = AnchorStyles.Left;
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(4, 61);
            optCuisines.Margin = new Padding(4);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(99, 24);
            optCuisines.TabIndex = 1;
            optCuisines.TabStop = true;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.Anchor = AnchorStyles.Left;
            optIngredients.AutoSize = true;
            optIngredients.Location = new Point(4, 93);
            optIngredients.Margin = new Padding(4);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(125, 24);
            optIngredients.TabIndex = 2;
            optIngredients.TabStop = true;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.Anchor = AnchorStyles.Left;
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(4, 125);
            optMeasurements.Margin = new Padding(4);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(158, 24);
            optMeasurements.TabIndex = 3;
            optMeasurements.TabStop = true;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.Anchor = AnchorStyles.Left;
            optCourses.AutoSize = true;
            optCourses.Location = new Point(4, 157);
            optCourses.Margin = new Padding(4);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(99, 24);
            optCourses.TabIndex = 4;
            optCourses.TabStop = true;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(220, 3);
            gData.Name = "gData";
            gData.Size = new Size(502, 566);
            gData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(625, 582);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 622);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private DataGridView gData;
        private Button btnSave;
    }
}