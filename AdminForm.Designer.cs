namespace GameShop
{
    partial class AdminForm
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
            NewMasterBtn = new Button();
            SuspendLayout();
            // 
            // NewGameBtn
            // 
            NewGameBtn.BackColor = Color.Gold;
            NewGameBtn.Cursor = Cursors.Hand;
            NewGameBtn.FlatAppearance.BorderSize = 0;
            NewGameBtn.FlatStyle = FlatStyle.Flat;
            NewGameBtn.Location = new Point(94, 47);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(186, 43);
            NewGameBtn.TabIndex = 0;
            NewGameBtn.Text = "New Game";
            NewGameBtn.UseVisualStyleBackColor = false;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // NewMasterBtn
            // 
            NewMasterBtn.BackColor = Color.Gold;
            NewMasterBtn.Cursor = Cursors.Hand;
            NewMasterBtn.FlatAppearance.BorderSize = 0;
            NewMasterBtn.FlatStyle = FlatStyle.Flat;
            NewMasterBtn.Location = new Point(94, 133);
            NewMasterBtn.Name = "NewMasterBtn";
            NewMasterBtn.Size = new Size(186, 43);
            NewMasterBtn.TabIndex = 3;
            NewMasterBtn.Text = "New Master";
            NewMasterBtn.UseVisualStyleBackColor = false;
            NewMasterBtn.Click += NewMasterBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(357, 251);
            Controls.Add(NewMasterBtn);
            Controls.Add(NewGameBtn);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NewGameBtn;
        private Button NewMasterBtn;
    }
}
