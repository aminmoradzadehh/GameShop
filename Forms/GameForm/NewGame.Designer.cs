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
            addBtn = new Button();
            GameNameLabel = new Label();
            GameYearLabel = new Label();
            GameCompanyLabel = new Label();
            gameNameTxtBox = new TextBox();
            gameYearTxtBox = new TextBox();
            companyTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gameListDataGridView = new DataGridView();
            onlineOfflineComboBox = new ComboBox();
            MultiSingleComboBox = new ComboBox();
            updateBtn = new Button();
            deleteBtn = new Button();
            resetBtn = new Button();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)gameListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(0, 192, 0);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = SystemColors.Control;
            addBtn.Location = new Point(548, 17);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(126, 28);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += SubmitBtn_Click;
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.ForeColor = SystemColors.ButtonHighlight;
            GameNameLabel.Location = new Point(23, 25);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(73, 15);
            GameNameLabel.TabIndex = 6;
            GameNameLabel.Text = "Game Name";
            // 
            // GameYearLabel
            // 
            GameYearLabel.AutoSize = true;
            GameYearLabel.ForeColor = SystemColors.ButtonHighlight;
            GameYearLabel.Location = new Point(23, 73);
            GameYearLabel.Name = "GameYearLabel";
            GameYearLabel.Size = new Size(29, 15);
            GameYearLabel.TabIndex = 7;
            GameYearLabel.Text = "Year";
            // 
            // GameCompanyLabel
            // 
            GameCompanyLabel.AutoSize = true;
            GameCompanyLabel.ForeColor = SystemColors.ButtonHighlight;
            GameCompanyLabel.Location = new Point(23, 118);
            GameCompanyLabel.Name = "GameCompanyLabel";
            GameCompanyLabel.Size = new Size(59, 15);
            GameCompanyLabel.TabIndex = 8;
            GameCompanyLabel.Text = "Company";
            // 
            // gameNameTxtBox
            // 
            gameNameTxtBox.BackColor = Color.Gold;
            gameNameTxtBox.Location = new Point(194, 22);
            gameNameTxtBox.Name = "gameNameTxtBox";
            gameNameTxtBox.Size = new Size(297, 23);
            gameNameTxtBox.TabIndex = 9;
            // 
            // gameYearTxtBox
            // 
            gameYearTxtBox.BackColor = Color.Gold;
            gameYearTxtBox.Location = new Point(194, 65);
            gameYearTxtBox.Name = "gameYearTxtBox";
            gameYearTxtBox.Size = new Size(297, 23);
            gameYearTxtBox.TabIndex = 10;
            // 
            // companyTxtBox
            // 
            companyTxtBox.BackColor = Color.Gold;
            companyTxtBox.Location = new Point(194, 110);
            companyTxtBox.Name = "companyTxtBox";
            companyTxtBox.Size = new Size(297, 23);
            companyTxtBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 157);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 13;
            label1.Text = "Online/Offline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 198);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 14;
            label2.Text = "Multiplayer/Singleplayer";
            // 
            // gameListDataGridView
            // 
            gameListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameListDataGridView.Location = new Point(12, 272);
            gameListDataGridView.Name = "gameListDataGridView";
            gameListDataGridView.Size = new Size(688, 287);
            gameListDataGridView.TabIndex = 15;
            // 
            // onlineOfflineComboBox
            // 
            onlineOfflineComboBox.BackColor = Color.Gold;
            onlineOfflineComboBox.FormattingEnabled = true;
            onlineOfflineComboBox.Location = new Point(194, 157);
            onlineOfflineComboBox.Name = "onlineOfflineComboBox";
            onlineOfflineComboBox.Size = new Size(297, 23);
            onlineOfflineComboBox.TabIndex = 16;
            // 
            // MultiSingleComboBox
            // 
            MultiSingleComboBox.BackColor = Color.Gold;
            MultiSingleComboBox.FormattingEnabled = true;
            MultiSingleComboBox.Location = new Point(194, 198);
            MultiSingleComboBox.Name = "MultiSingleComboBox";
            MultiSingleComboBox.Size = new Size(297, 23);
            MultiSingleComboBox.TabIndex = 17;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(192, 0, 192);
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.ForeColor = SystemColors.Control;
            updateBtn.Location = new Point(548, 60);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(126, 28);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(192, 0, 0);
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(548, 105);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 28);
            deleteBtn.TabIndex = 19;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Blue;
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.ForeColor = SystemColors.Control;
            resetBtn.Location = new Point(548, 150);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(126, 28);
            resetBtn.TabIndex = 20;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Gray;
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.FlatAppearance.BorderSize = 0;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.ForeColor = SystemColors.Control;
            refreshBtn.Location = new Point(548, 193);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(126, 28);
            refreshBtn.TabIndex = 21;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(712, 571);
            Controls.Add(refreshBtn);
            Controls.Add(resetBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(MultiSingleComboBox);
            Controls.Add(onlineOfflineComboBox);
            Controls.Add(gameListDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(companyTxtBox);
            Controls.Add(gameYearTxtBox);
            Controls.Add(gameNameTxtBox);
            Controls.Add(GameCompanyLabel);
            Controls.Add(GameYearLabel);
            Controls.Add(GameNameLabel);
            Controls.Add(addBtn);
            Name = "NewGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)gameListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label GameNameLabel;
        private Label GameYearLabel;
        private Label GameCompanyLabel;
        private TextBox gameNameTxtBox;
        private TextBox gameYearTxtBox;
        private TextBox companyTxtBox;
        private Label label1;
        private Label label2;
        private DataGridView gameListDataGridView;
        private ComboBox onlineOfflineComboBox;
        private ComboBox MultiSingleComboBox;
        private Button updateBtn;
        private Button deleteBtn;
        private Button resetBtn;
        private Button refreshBtn;
    }
}