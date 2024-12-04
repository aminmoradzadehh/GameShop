using GameShop.Forms.Category;
using GameShop.Forms.Game;
using GameShop.Forms.Master;

namespace GameShop
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame form = new NewGame();
            form.Show();
        }

        private void GameListBtn_Click(object sender, EventArgs e)
        {
            GameList form = new GameList();
            form.Show();
        }
        private void NewCategoryBtn_Click(object sender, EventArgs e)
        {
            NewCategory form = new NewCategory();
            form.Show();
        }

        private void CatrgoryListBtn_Click(object sender, EventArgs e)
        {
            CategoryList form = new CategoryList();
            form.Show();
        }

        private void NewMasterBtn_Click(object sender, EventArgs e)
        {
            NewMaster form = new NewMaster();
            form.Show();
        }

        private void MasterListBtn_Click(object sender, EventArgs e)
        {
            MasterList form = new MasterList();
            form.Show();
        }
    }
}