
namespace GameShop.Forms.Master
{
    public partial class NewMaster : Form
    {
        public NewMaster()
        {
            InitializeComponent();
        }
        
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string masterPhoneNumber = MasterPhoneNumberTxtBox.Text;
            string masterId = MasterIdTxtBox.Text;
            if (masterPhoneNumber.Length != 11 && masterId.Length != 10)
            {
                MessageBox.Show("invalid Value", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MasterFirstNameMasterTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string masterFirstName = MasterFirstNameMasterTxtBox.Text;
            if (string.IsNullOrEmpty(masterFirstName)) {
                MessageBox.Show("Empty input!");
                return;
            }
           
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MasterLastNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string masterLastName = MasterLastNameTxtBox.Text;
            if (string.IsNullOrEmpty(masterLastName)) {
                MessageBox.Show("Empty input!");
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MasterIdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           string masterId = MasterIdTxtBox.Text;
            if (string.IsNullOrEmpty(masterId)) {
                MessageBox.Show("Empty input!");
                return;
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void MasterPhoneNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           string masterPhoneNumber = MasterPhoneNumberTxtBox.Text;
            if (string.IsNullOrEmpty(masterPhoneNumber))
            {
                MessageBox.Show("Empty input!");
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
         
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("you didn't CHOOSE Gender.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("you must CHOOSE the Gender.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
        }
    }
}
