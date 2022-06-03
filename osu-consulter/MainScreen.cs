using System.Net.Http;
using System.Runtime.InteropServices;
using osu_consulter.Controllers;

namespace osu_consulter
{
    public partial class MainScreen : Form
    {
        private readonly MainScreenController controller = new MainScreenController();
        public MainScreen()
        {
            InitializeComponent();
        }

        private async void BTN_CONSULT_Click(object sender, EventArgs e)
        {
            var playerScore = await controller.GetPlayerScore(6346223, 456986);

            label1.Text = playerScore.position.ToString();
            TXT_OSU_NAME.Text = playerScore.score.user.username;
            PB_IMAGE.Image = Image.FromFile(@"c:\temp\userImage.png");
        }
    }
}