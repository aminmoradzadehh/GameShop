
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

        private void NewMasterBtn_Click(object sender, EventArgs e)
        {
            NewMaster form = new NewMaster();
            form.Show();
        }
    }
}
