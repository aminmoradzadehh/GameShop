namespace GameShop.Forms.Master
{
    partial class MasterList
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
            MasterListDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MasterListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MasterListDataGridView
            // 
            MasterListDataGridView.BackgroundColor = Color.DarkSlateBlue;
            MasterListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasterListDataGridView.Dock = DockStyle.Fill;
            MasterListDataGridView.Location = new Point(0, 0);
            MasterListDataGridView.Name = "MasterListDataGridView";
            MasterListDataGridView.Size = new Size(800, 450);
            MasterListDataGridView.TabIndex = 0;
            // 
            // MasterList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(MasterListDataGridView);
            Name = "MasterList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterList";
            ((System.ComponentModel.ISupportInitialize)MasterListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MasterListDataGridView;
    }
}