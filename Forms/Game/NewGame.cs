
namespace GameShop.Forms.Game
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string gameName = GameNameTxtBox.Text;
            string gameYear = GameYearTxtBox.Text;
            if(string.IsNullOrEmpty(gameName) )
            {
                MessageBox.Show("GameName is Empty!");
                return;
            }
            if (string.IsNullOrEmpty(gameYear)) {
                MessageBox.Show("GameYear is Empty!");
                return;
            }
            if (CompanyComboBox.SelectedIndex == -1) {
                MessageBox.Show("You didn't select COMPANY", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
            if (gameYear.Length != 4)
            {
                MessageBox.Show("Game Year is invalid");
                return;
            }
            if (gameYear.Length == 4)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GameNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameYearTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("invalid character", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CompanyComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("don't type here  (if the combo box is empty you should fill the company form first)", "choose!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string GameName
        {
            get { return GameNameTxtBox.Text; }
        }

        public int GameYear
        {
            get { return int.Parse(GameYearTxtBox.Text); }
        }


    }
}
