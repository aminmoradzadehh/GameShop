namespace GameShop.Forms.Company
{
    partial class NewCompany
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
            PublisherLabel = new Label();
            CompanyNameTxtBox = new TextBox();
            CompanyYearTxtBox = new TextBox();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.ForeColor = SystemColors.ButtonHighlight;
            CompanyNameLabel.Location = new Point(55, 55);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(94, 15);
            CompanyNameLabel.TabIndex = 7;
            CompanyNameLabel.Text = "Company Name";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.ForeColor = SystemColors.ButtonHighlight;
            PublisherLabel.Location = new Point(55, 122);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(56, 15);
            PublisherLabel.TabIndex = 8;
            PublisherLabel.Text = "Publisher";
            PublisherLabel.Click += YearLabel_Click;
            // 
            // CompanyNameTxtBox
            // 
            CompanyNameTxtBox.BackColor = Color.Gold;
            CompanyNameTxtBox.Location = new Point(357, 55);
            CompanyNameTxtBox.Name = "CompanyNameTxtBox";
            CompanyNameTxtBox.Size = new Size(297, 23);
            CompanyNameTxtBox.TabIndex = 10;
            CompanyNameTxtBox.KeyPress += CompanyNameTxtBox_KeyPress;
            // 
            // CompanyYearTxtBox
            // 
            CompanyYearTxtBox.BackColor = Color.Gold;
            CompanyYearTxtBox.Location = new Point(357, 114);
            CompanyYearTxtBox.Name = "CompanyYearTxtBox";
            CompanyYearTxtBox.Size = new Size(297, 23);
            CompanyYearTxtBox.TabIndex = 11;
            CompanyYearTxtBox.KeyPress += CompanyYearTxtBox_KeyPress;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 192, 0);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(55, 180);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(126, 43);
            SubmitBtn.TabIndex = 12;
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
            CancelBtn.Location = new Point(528, 180);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(126, 43);
            CancelBtn.TabIndex = 13;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // NewCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(712, 271);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(CompanyYearTxtBox);
            Controls.Add(CompanyNameTxtBox);
            Controls.Add(PublisherLabel);
            Controls.Add(CompanyNameLabel);
            Name = "NewCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CompanyNameLabel;
        private Label PublisherLabel;
        private TextBox CompanyNameTxtBox;
        private TextBox CompanyYearTxtBox;
        private Button SubmitBtn;
        private Button CancelBtn;
    }
}