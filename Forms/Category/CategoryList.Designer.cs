namespace GameShop.Forms.Category
{
    partial class CategoryList
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
            CategoryListDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CategoryListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CategoryListDataGridView
            // 
            CategoryListDataGridView.BackgroundColor = Color.DarkSlateBlue;
            CategoryListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryListDataGridView.Dock = DockStyle.Fill;
            CategoryListDataGridView.Location = new Point(0, 0);
            CategoryListDataGridView.Name = "CategoryListDataGridView";
            CategoryListDataGridView.Size = new Size(800, 450);
            CategoryListDataGridView.TabIndex = 0;
            // 
            // CategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(CategoryListDataGridView);
            Name = "CategoryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryList";
            ((System.ComponentModel.ISupportInitialize)CategoryListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CategoryListDataGridView;
    }
}