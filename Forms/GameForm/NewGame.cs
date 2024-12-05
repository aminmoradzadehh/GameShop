
using BaseBackend.Business;
using BaseBackend.Entities;
using BaseBackend.Enums;

namespace GameShop.Forms.Game
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            BaseBackend.Entities.Game newGame = new BaseBackend.Entities.Game();

            List<BaseBackend.Entities.Game> games = new List<BaseBackend.Entities.Game>();


        }
        private bool IsValidRegistrationForm()
        {
            if (string.IsNullOrEmpty(GameNameTxtBox.Text) ||
                string.IsNullOrEmpty(GameYearTxtBox.Text) ||
                string.IsNullOrEmpty(companyTxtBox.Text) )
            {
                MessageBox.Show("Please enter valid inputs");
                return false;
            }
            else
                return true;
        }
        private readonly NewGameBusiness _gameBusiness;
        public delegate void ReloadData(List<Game> games);
        public event ReloadData ReloadDataEvent;

        List<Game> games;
        Game currentGame;

        private void ResetRegistrationForm()
        {
            GameNameTxtBox.Text = string.Empty;
            GameYearTxtBox.Text = string.Empty;
            companyTxtBox.Text = string.Empty;
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
