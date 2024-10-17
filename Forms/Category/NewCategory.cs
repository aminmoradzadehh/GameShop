
namespace GameShop.Forms.Category
{
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string newCategory = NewCategoryTxtBox.Text;
            if (string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show("Empty!");
                    return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewCategoryTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
   
        private void NewCategory_Load(object sender, EventArgs e)
        {

        }

        private void NewCategoryTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
