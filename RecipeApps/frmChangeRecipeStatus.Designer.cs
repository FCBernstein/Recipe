namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeRecipeStatus));
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblCurrentStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblStatus.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblStatus, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(725, 442);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Tekton Pro Ext", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(719, 110);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Tekton Pro Ext", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(3, 110);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(719, 110);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status: ";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 4;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.Controls.Add(lblDateDrafted, 1, 0);
            tblStatus.Controls.Add(lblDatePublished, 2, 0);
            tblStatus.Controls.Add(lblDateArchived, 3, 0);
            tblStatus.Controls.Add(txtDateDrafted, 1, 1);
            tblStatus.Controls.Add(txtDatePublished, 2, 1);
            tblStatus.Controls.Add(txtDateArchived, 3, 1);
            tblStatus.Controls.Add(lblStatusDates, 0, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(3, 223);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.Size = new Size(719, 104);
            tblStatus.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 30);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(131, 20);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(182, 0);
            lblDateDrafted.Margin = new Padding(3, 0, 3, 10);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(173, 20);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.Text = "Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(361, 0);
            lblDatePublished.Margin = new Padding(3, 0, 3, 10);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(173, 20);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.Text = "Published";
            lblDatePublished.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(540, 0);
            lblDateArchived.Margin = new Padding(3, 0, 3, 10);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(176, 20);
            lblDateArchived.TabIndex = 3;
            lblDateArchived.Text = "Archived";
            lblDateArchived.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDateDrafted.Location = new Point(182, 33);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(173, 27);
            txtDateDrafted.TabIndex = 4;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.Location = new Point(361, 33);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(173, 27);
            txtDatePublished.TabIndex = 5;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.Location = new Point(540, 33);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(176, 27);
            txtDateArchived.TabIndex = 6;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 333);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(719, 106);
            tblButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(146, 10);
            btnDraft.Margin = new Padding(3, 10, 3, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(90, 30);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "&Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top;
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(313, 10);
            btnPublish.Margin = new Padding(3, 10, 3, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(90, 30);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "&Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.AutoSize = true;
            btnArchive.Location = new Point(481, 10);
            btnArchive.Margin = new Padding(3, 10, 3, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(90, 30);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "&Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 442);
            Controls.Add(tblMain);
            Font = new Font("Tekton Pro Ext", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmChangeRecipeStatus";
            Text = "Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblStatus;
        private Label lblStatusDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}