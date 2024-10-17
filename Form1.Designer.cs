namespace GameShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewGameBtn = new Button();
            NewCompanyBtn = new Button();
            NewCategoryBtn = new Button();
            NewMasterBtn = new Button();
            GameListBtn = new Button();
            CompanyListBtn = new Button();
            CatrgoryListBtn = new Button();
            MasterListBtn = new Button();
            SuspendLayout();
            // 
            // NewGameBtn
            // 
            NewGameBtn.BackColor = Color.Gold;
            NewGameBtn.Cursor = Cursors.Hand;
            NewGameBtn.FlatAppearance.BorderSize = 0;
            NewGameBtn.FlatStyle = FlatStyle.Flat;
            NewGameBtn.Location = new Point(70, 41);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(186, 43);
            NewGameBtn.TabIndex = 0;
            NewGameBtn.Text = "New Game";
            NewGameBtn.UseVisualStyleBackColor = false;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // NewCompanyBtn
            // 
            NewCompanyBtn.BackColor = Color.Gold;
            NewCompanyBtn.Cursor = Cursors.Hand;
            NewCompanyBtn.FlatAppearance.BorderSize = 0;
            NewCompanyBtn.FlatStyle = FlatStyle.Flat;
            NewCompanyBtn.Location = new Point(70, 140);
            NewCompanyBtn.Name = "NewCompanyBtn";
            NewCompanyBtn.Size = new Size(186, 43);
            NewCompanyBtn.TabIndex = 1;
            NewCompanyBtn.Text = "New Company";
            NewCompanyBtn.UseVisualStyleBackColor = false;
            NewCompanyBtn.Click += NewCompanyBtn_Click;
            // 
            // NewCategoryBtn
            // 
            NewCategoryBtn.BackColor = Color.Gold;
            NewCategoryBtn.Cursor = Cursors.Hand;
            NewCategoryBtn.FlatAppearance.BorderSize = 0;
            NewCategoryBtn.FlatStyle = FlatStyle.Flat;
            NewCategoryBtn.Location = new Point(70, 232);
            NewCategoryBtn.Name = "NewCategoryBtn";
            NewCategoryBtn.Size = new Size(186, 43);
            NewCategoryBtn.TabIndex = 2;
            NewCategoryBtn.Text = "New Category";
            NewCategoryBtn.UseVisualStyleBackColor = false;
            NewCategoryBtn.Click += NewCategoryBtn_Click;
            // 
            // NewMasterBtn
            // 
            NewMasterBtn.BackColor = Color.Gold;
            NewMasterBtn.Cursor = Cursors.Hand;
            NewMasterBtn.FlatAppearance.BorderSize = 0;
            NewMasterBtn.FlatStyle = FlatStyle.Flat;
            NewMasterBtn.Location = new Point(70, 320);
            NewMasterBtn.Name = "NewMasterBtn";
            NewMasterBtn.Size = new Size(186, 43);
            NewMasterBtn.TabIndex = 3;
            NewMasterBtn.Text = "New Master";
            NewMasterBtn.UseVisualStyleBackColor = false;
            NewMasterBtn.Click += NewMasterBtn_Click;
            // 
            // GameListBtn
            // 
            GameListBtn.BackColor = Color.Gold;
            GameListBtn.Cursor = Cursors.Hand;
            GameListBtn.FlatAppearance.BorderSize = 0;
            GameListBtn.FlatStyle = FlatStyle.Flat;
            GameListBtn.Location = new Point(454, 41);
            GameListBtn.Name = "GameListBtn";
            GameListBtn.Size = new Size(195, 43);
            GameListBtn.TabIndex = 4;
            GameListBtn.Text = "GameList";
            GameListBtn.UseVisualStyleBackColor = false;
            GameListBtn.Click += GameListBtn_Click;
            // 
            // CompanyListBtn
            // 
            CompanyListBtn.BackColor = Color.Gold;
            CompanyListBtn.Cursor = Cursors.Hand;
            CompanyListBtn.FlatAppearance.BorderSize = 0;
            CompanyListBtn.FlatStyle = FlatStyle.Flat;
            CompanyListBtn.Location = new Point(454, 140);
            CompanyListBtn.Name = "CompanyListBtn";
            CompanyListBtn.Size = new Size(195, 43);
            CompanyListBtn.TabIndex = 5;
            CompanyListBtn.Text = "Company List";
            CompanyListBtn.UseVisualStyleBackColor = false;
            CompanyListBtn.Click += CompanyListBtn_Click;
            // 
            // CatrgoryListBtn
            // 
            CatrgoryListBtn.BackColor = Color.Gold;
            CatrgoryListBtn.Cursor = Cursors.Hand;
            CatrgoryListBtn.FlatAppearance.BorderSize = 0;
            CatrgoryListBtn.FlatStyle = FlatStyle.Flat;
            CatrgoryListBtn.Location = new Point(454, 232);
            CatrgoryListBtn.Name = "CatrgoryListBtn";
            CatrgoryListBtn.Size = new Size(195, 43);
            CatrgoryListBtn.TabIndex = 6;
            CatrgoryListBtn.Text = "Category List";
            CatrgoryListBtn.UseVisualStyleBackColor = false;
            CatrgoryListBtn.Click += CatrgoryListBtn_Click;
            // 
            // MasterListBtn
            // 
            MasterListBtn.BackColor = Color.Gold;
            MasterListBtn.Cursor = Cursors.Hand;
            MasterListBtn.FlatAppearance.BorderSize = 0;
            MasterListBtn.FlatStyle = FlatStyle.Flat;
            MasterListBtn.Location = new Point(454, 320);
            MasterListBtn.Name = "MasterListBtn";
            MasterListBtn.Size = new Size(195, 43);
            MasterListBtn.TabIndex = 7;
            MasterListBtn.Text = "Master List";
            MasterListBtn.UseVisualStyleBackColor = false;
            MasterListBtn.Click += MasterListBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(MasterListBtn);
            Controls.Add(CatrgoryListBtn);
            Controls.Add(CompanyListBtn);
            Controls.Add(GameListBtn);
            Controls.Add(NewMasterBtn);
            Controls.Add(NewCategoryBtn);
            Controls.Add(NewCompanyBtn);
            Controls.Add(NewGameBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NewGameBtn;
        private Button NewCompanyBtn;
        private Button NewCategoryBtn;
        private Button NewMasterBtn;
        private Button GameListBtn;
        private Button CompanyListBtn;
        private Button CatrgoryListBtn;
        private Button MasterListBtn;
    }
}
