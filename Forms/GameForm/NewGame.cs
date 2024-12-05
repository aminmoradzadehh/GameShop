#nullable disable
using BaseBackend.Business;
using BaseBackend.Entities;
using BaseBackend.Enums;
using GameShop.Dtos;

namespace GameShop.Forms.Game
{
    public partial class NewGame : Form
    {
        private readonly NewGameBusiness _gameBuisness;
        public delegate void ReloadData(List<BaseBackend.Entities.Game> students);
        public event ReloadData ReloadDataEvent;

        List<BaseBackend.Entities.Game> games;
        BaseBackend.Entities.Game currentGame;
        public NewGame()
        {
            InitializeComponent();
            ReloadDataEvent += FillDataIntoDataGridView; 
            _gameBuisness = new NewGameBusiness();
            games = _gameBuisness.GetAll();
            ReloadDataEvent.Invoke(games);
            FillOnlineOfflineComoboBox();
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidRegistrationForm())
                return;
            AddGame addStudent = new AddGame()
            {
                GameName = gameNameTxtBox.Text,
                GameYear = gameYearTxtBox.Text,
                Company = companyTxtBox.Text,
            };
            games = _gameBuisness.GetAll();
            ReloadDataEvent.Invoke(games);
            MessageBox.Show("Register Successfully");
            ResetRegistrationForm();
        }
        private bool IsValidRegistrationForm()
        {
            if (string.IsNullOrEmpty(gameNameTxtBox.Text) ||
                string.IsNullOrEmpty(gameYearTxtBox.Text) ||
                string.IsNullOrEmpty(companyTxtBox.Text))
            {
                MessageBox.Show("Please enter valid inputs");
                return false;
            }
            else
                return true;
        }
        private void ResetRegistrationForm()
        {
            gameNameTxtBox.Text = string.Empty;
            gameYearTxtBox.Text = string.Empty;
            companyTxtBox.Text = string.Empty;
        }
        public void FillDataIntoDataGridView(List<BaseBackend.Entities.Game> students)
        {
            gameListDataGridView.DataSource = null;
            gameListDataGridView.DataSource = games;
            gameListDataGridView.Refresh();
        }

        private void FillOnlineOfflineComoboBox()
        {
            List<string> comboList = new List<string>();
            onlineOfflineComboBox.DataSource = comboList;
            onlineOfflineComboBox.DataSource = Enum.GetValues(typeof(OnlineOffline));
        }
        public void AddGame(AddGame addGame)
        {
            BaseBackend.Entities.Game game = new(gameName: addGame.GameName, gameYear: addGame.GameYear, company: addGame.Company);
            _gameBuisness.Add(game);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
