namespace GameShop.Forms.Game
{
    partial class GameList
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
            GameListDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GameListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // GameListDataGridView
            // 
            GameListDataGridView.BackgroundColor = Color.DarkSlateBlue;
            GameListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GameListDataGridView.Dock = DockStyle.Fill;
            GameListDataGridView.GridColor = Color.MediumPurple;
            GameListDataGridView.Location = new Point(0, 0);
            GameListDataGridView.Name = "GameListDataGridView";
            GameListDataGridView.Size = new Size(800, 450);
            GameListDataGridView.TabIndex = 0;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(GameListDataGridView);
            Name = "GameList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameList";
            ((System.ComponentModel.ISupportInitialize)GameListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GameListDataGridView;
    }
}