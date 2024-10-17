namespace GameShop.Forms.Category
{
    partial class NewCategory
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
            CompanyNameLabel = new Label();
            NewCategoryTxtBox = new TextBox();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.ForeColor = SystemColors.ButtonHighlight;
            CompanyNameLabel.Location = new Point(73, 30);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(61, 15);
            CompanyNameLabel.TabIndex = 8;
            CompanyNameLabel.Text = "Category :";
            // 
            // NewCategoryTxtBox
            // 
            NewCategoryTxtBox.BackColor = Color.Gold;
            NewCategoryTxtBox.Location = new Point(306, 27);
            NewCategoryTxtBox.Name = "NewCategoryTxtBox";
            NewCategoryTxtBox.Size = new Size(297, 23);
            NewCategoryTxtBox.TabIndex = 11;
            NewCategoryTxtBox.TextChanged += NewCategoryTxtBox_TextChanged;
            NewCategoryTxtBox.KeyPress += NewCategoryTxtBox_KeyPress;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 192, 0);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(73, 71);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(126, 43);
            SubmitBtn.TabIndex = 13;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(192, 0, 0);
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = SystemColors.Control;
            CancelBtn.Location = new Point(477, 71);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(126, 43);
            CancelBtn.TabIndex = 14;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // NewCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(712, 150);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(NewCategoryTxtBox);
            Controls.Add(CompanyNameLabel);
            Name = "NewCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewCategory";
            Load += NewCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CompanyNameLabel;
        private TextBox NewCategoryTxtBox;
        private Button SubmitBtn;
        private Button CancelBtn;
    }
}