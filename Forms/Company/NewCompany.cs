
namespace GameShop.Forms.Company
{
    public partial class NewCompany : Form
    {
        public NewCompany()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            
            string companyName = CompanyNameTxtBox.Text;
            string companyYear = CompanyYearTxtBox.Text;
            
            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyYear)) {
                MessageBox.Show("Empty!");
                DialogResult = DialogResult.Cancel;
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

        private void YearLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyYearTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
