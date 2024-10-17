namespace GameShop.Forms.Company
{
    partial class CompanyList
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
            CompanyListDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CompanyListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CompanyListDataGridView
            // 
            CompanyListDataGridView.BackgroundColor = Color.DarkSlateBlue;
            CompanyListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompanyListDataGridView.Dock = DockStyle.Fill;
            CompanyListDataGridView.Location = new Point(0, 0);
            CompanyListDataGridView.Name = "CompanyListDataGridView";
            CompanyListDataGridView.Size = new Size(800, 450);
            CompanyListDataGridView.TabIndex = 0;
            // 
            // ComanyList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(CompanyListDataGridView);
            Name = "ComanyList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComanyList";
            ((System.ComponentModel.ISupportInitialize)CompanyListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CompanyListDataGridView;
    }
}