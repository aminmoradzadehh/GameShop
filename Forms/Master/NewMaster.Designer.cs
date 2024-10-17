namespace GameShop.Forms.Master
{
    partial class NewMaster
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
            MasterFirstNameLabel = new Label();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            MasterFirstNameMasterTxtBox = new TextBox();
            MasterLastNameTxtBox = new TextBox();
            MasterIdTxtBox = new TextBox();
            MasterPhoneNumberTxtBox = new TextBox();
            MasterLastNameLabel = new Label();
            MasterIdLabel = new Label();
            MasterPhoneNumberLabel = new Label();
            IdErrorLabel = new Label();
            MasterGenderLabel = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // MasterFirstNameLabel
            // 
            MasterFirstNameLabel.AutoSize = true;
            MasterFirstNameLabel.ForeColor = SystemColors.ButtonHighlight;
            MasterFirstNameLabel.Location = new Point(35, 49);
            MasterFirstNameLabel.Name = "MasterFirstNameLabel";
            MasterFirstNameLabel.Size = new Size(61, 15);
            MasterFirstNameLabel.TabIndex = 9;
            MasterFirstNameLabel.Text = "FirstName";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 192, 0);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(35, 321);
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
            CancelBtn.Location = new Point(439, 321);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(126, 43);
            CancelBtn.TabIndex = 14;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // MasterFirstNameMasterTxtBox
            // 
            MasterFirstNameMasterTxtBox.BackColor = Color.Gold;
            MasterFirstNameMasterTxtBox.Location = new Point(162, 49);
            MasterFirstNameMasterTxtBox.Name = "MasterFirstNameMasterTxtBox";
            MasterFirstNameMasterTxtBox.Size = new Size(403, 23);
            MasterFirstNameMasterTxtBox.TabIndex = 15;
            MasterFirstNameMasterTxtBox.KeyPress += MasterFirstNameMasterTxtBox_KeyPress;
            // 
            // MasterLastNameTxtBox
            // 
            MasterLastNameTxtBox.BackColor = Color.Gold;
            MasterLastNameTxtBox.Location = new Point(162, 98);
            MasterLastNameTxtBox.Name = "MasterLastNameTxtBox";
            MasterLastNameTxtBox.Size = new Size(403, 23);
            MasterLastNameTxtBox.TabIndex = 16;
            MasterLastNameTxtBox.KeyPress += MasterLastNameTxtBox_KeyPress;
            // 
            // MasterIdTxtBox
            // 
            MasterIdTxtBox.BackColor = Color.Gold;
            MasterIdTxtBox.Location = new Point(162, 147);
            MasterIdTxtBox.Name = "MasterIdTxtBox";
            MasterIdTxtBox.Size = new Size(403, 23);
            MasterIdTxtBox.TabIndex = 17;
            MasterIdTxtBox.KeyPress += MasterIdTxtBox_KeyPress;
            // 
            // MasterPhoneNumberTxtBox
            // 
            MasterPhoneNumberTxtBox.BackColor = Color.Gold;
            MasterPhoneNumberTxtBox.Location = new Point(162, 197);
            MasterPhoneNumberTxtBox.Name = "MasterPhoneNumberTxtBox";
            MasterPhoneNumberTxtBox.Size = new Size(403, 23);
            MasterPhoneNumberTxtBox.TabIndex = 18;
            MasterPhoneNumberTxtBox.KeyPress += MasterPhoneNumberTxtBox_KeyPress;
            // 
            // MasterLastNameLabel
            // 
            MasterLastNameLabel.AutoSize = true;
            MasterLastNameLabel.ForeColor = SystemColors.ButtonHighlight;
            MasterLastNameLabel.Location = new Point(36, 98);
            MasterLastNameLabel.Name = "MasterLastNameLabel";
            MasterLastNameLabel.Size = new Size(60, 15);
            MasterLastNameLabel.TabIndex = 19;
            MasterLastNameLabel.Text = "LastName";
            // 
            // MasterIdLabel
            // 
            MasterIdLabel.AutoSize = true;
            MasterIdLabel.ForeColor = SystemColors.ButtonHighlight;
            MasterIdLabel.Location = new Point(36, 147);
            MasterIdLabel.Name = "MasterIdLabel";
            MasterIdLabel.Size = new Size(18, 15);
            MasterIdLabel.TabIndex = 20;
            MasterIdLabel.Text = "ID";
            // 
            // MasterPhoneNumberLabel
            // 
            MasterPhoneNumberLabel.AutoSize = true;
            MasterPhoneNumberLabel.ForeColor = SystemColors.ButtonHighlight;
            MasterPhoneNumberLabel.Location = new Point(36, 197);
            MasterPhoneNumberLabel.Name = "MasterPhoneNumberLabel";
            MasterPhoneNumberLabel.Size = new Size(85, 15);
            MasterPhoneNumberLabel.TabIndex = 21;
            MasterPhoneNumberLabel.Text = "PhoneNumber";
            // 
            // IdErrorLabel
            // 
            IdErrorLabel.AutoSize = true;
            IdErrorLabel.ForeColor = Color.Red;
            IdErrorLabel.Location = new Point(162, 218);
            IdErrorLabel.Name = "IdErrorLabel";
            IdErrorLabel.Size = new Size(0, 15);
            IdErrorLabel.TabIndex = 22;
            // 
            // MasterGenderLabel
            // 
            MasterGenderLabel.AutoSize = true;
            MasterGenderLabel.ForeColor = SystemColors.ButtonHighlight;
            MasterGenderLabel.Location = new Point(36, 254);
            MasterGenderLabel.Name = "MasterGenderLabel";
            MasterGenderLabel.Size = new Size(45, 15);
            MasterGenderLabel.TabIndex = 23;
            MasterGenderLabel.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gold;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(162, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(403, 23);
            comboBox1.TabIndex = 24;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // NewMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(629, 418);
            Controls.Add(comboBox1);
            Controls.Add(MasterGenderLabel);
            Controls.Add(IdErrorLabel);
            Controls.Add(MasterPhoneNumberLabel);
            Controls.Add(MasterIdLabel);
            Controls.Add(MasterLastNameLabel);
            Controls.Add(MasterPhoneNumberTxtBox);
            Controls.Add(MasterIdTxtBox);
            Controls.Add(MasterLastNameTxtBox);
            Controls.Add(MasterFirstNameMasterTxtBox);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(MasterFirstNameLabel);
            Name = "NewMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMaster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MasterFirstNameLabel;
        private Button SubmitBtn;
        private Button CancelBtn;
        private TextBox MasterFirstNameMasterTxtBox;
        private TextBox MasterLastNameTxtBox;
        private TextBox MasterIdTxtBox;
        private TextBox MasterPhoneNumberTxtBox;
        private Label MasterLastNameLabel;
        private Label MasterIdLabel;
        private Label MasterPhoneNumberLabel;
        private Label IdErrorLabel;
        private Label MasterGenderLabel;
        private ComboBox comboBox1;
    }
}