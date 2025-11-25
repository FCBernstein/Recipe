namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoCreateCookbook));
            tblMain = new TableLayoutPanel();
            lstUserName = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(537, 102);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(40, 39);
            lstUserName.Margin = new Padding(40, 3, 3, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(225, 28);
            lstUserName.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Location = new Point(293, 36);
            btnCreateCookbook.Margin = new Padding(25, 3, 3, 3);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(163, 30);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "&Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 102);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmAutoCreateCookbook";
            Text = "Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserName;
        private Button btnCreateCookbook;
    }
}