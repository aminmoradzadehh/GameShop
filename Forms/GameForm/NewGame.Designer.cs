namespace GameShop.Forms.Game
{
    partial class NewGame
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
            SubmitBtn = new Button();
            CancelBtn = new Button();
            GameNameLabel = new Label();
            GameYearLabel = new Label();
            GameCompanyLabel = new Label();
            GameNameTxtBox = new TextBox();
            GameYearTxtBox = new TextBox();
            companyTxtBox = new TextBox();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 192, 0);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(75, 176);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(126, 43);
            SubmitBtn.TabIndex = 4;
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
            CancelBtn.Location = new Point(549, 176);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(126, 43);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.ForeColor = SystemColors.ButtonHighlight;
            GameNameLabel.Location = new Point(75, 33);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(73, 15);
            GameNameLabel.TabIndex = 6;
            GameNameLabel.Text = "Game Name";
            // 
            // GameYearLabel
            // 
            GameYearLabel.AutoSize = true;
            GameYearLabel.ForeColor = SystemColors.ButtonHighlight;
            GameYearLabel.Location = new Point(75, 76);
            GameYearLabel.Name = "GameYearLabel";
            GameYearLabel.Size = new Size(29, 15);
            GameYearLabel.TabIndex = 7;
            GameYearLabel.Text = "Year";
            // 
            // GameCompanyLabel
            // 
            GameCompanyLabel.AutoSize = true;
            GameCompanyLabel.ForeColor = SystemColors.ButtonHighlight;
            GameCompanyLabel.Location = new Point(75, 118);
            GameCompanyLabel.Name = "GameCompanyLabel";
            GameCompanyLabel.Size = new Size(59, 15);
            GameCompanyLabel.TabIndex = 8;
            GameCompanyLabel.Text = "Company";
            // 
            // GameNameTxtBox
            // 
            GameNameTxtBox.BackColor = Color.Gold;
            GameNameTxtBox.Location = new Point(378, 25);
            GameNameTxtBox.Name = "GameNameTxtBox";
            GameNameTxtBox.Size = new Size(297, 23);
            GameNameTxtBox.TabIndex = 9;
            // 
            // GameYearTxtBox
            // 
            GameYearTxtBox.BackColor = Color.Gold;
            GameYearTxtBox.Location = new Point(378, 73);
            GameYearTxtBox.Name = "GameYearTxtBox";
            GameYearTxtBox.Size = new Size(297, 23);
            GameYearTxtBox.TabIndex = 10;
            // 
            // companyTxtBox
            // 
            companyTxtBox.BackColor = Color.Gold;
            companyTxtBox.Location = new Point(378, 118);
            companyTxtBox.Name = "companyTxtBox";
            companyTxtBox.Size = new Size(297, 23);
            companyTxtBox.TabIndex = 12;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(712, 271);
            Controls.Add(companyTxtBox);
            Controls.Add(GameYearTxtBox);
            Controls.Add(GameNameTxtBox);
            Controls.Add(GameCompanyLabel);
            Controls.Add(GameYearLabel);
            Controls.Add(GameNameLabel);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Name = "NewGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Button CancelBtn;
        private Label GameNameLabel;
        private Label GameYearLabel;
        private Label GameCompanyLabel;
        private TextBox GameNameTxtBox;
        private TextBox GameYearTxtBox;
        private TextBox companyTxtBox;
    }
}