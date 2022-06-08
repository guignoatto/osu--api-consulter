using System.Net.Http;
using System.Runtime.InteropServices;
using osu_consulter.Controllers;

namespace osu_consulter;
public partial class MainScreen : Form
{
    private readonly MainScreenController controller = new MainScreenController();
    public MainScreen()
    {
        InitializeComponent();
        controller.GetFirstToken();

        //VISUAL
        TXT_USER_ID.Text = controller.guiperinoID;
        TXT_BEATMAP_ID.Text = controller.defaultMap;
    }

    private async void BTN_CONSULT_Click(object sender, EventArgs e)
    {
        int beatmapId = 0;
        int userId = 0;
        if (!int.TryParse(this.TXT_USER_ID.Text, out userId) && !int.TryParse(this.TXT_BEATMAP_ID.Text, out beatmapId))
        {
            ResetScreen();
            ShowMessageBoxOk("No data found", "Error");
            return;
        }

        var playerScore = await controller.GetPlayerScore(userId, beatmapId);
        if (playerScore is null)
        {
            ResetScreen();
            ShowMessageBoxOk("No data found", "Error");
            return;
        }
        PB_IMAGE.ImageLocation = await controller.GetPlayerImage(playerScore);
        PB_BG_IMAGE.ImageLocation = await controller.GetPlayerBgImage(playerScore);
        label1.Text = playerScore.position.ToString();
        TXT_OSU_NAME.Text = playerScore.score.user.username;
    }

    private void ResetScreen()
    {
        label1.Text = "";
        TXT_OSU_NAME.Text = "";
        PB_IMAGE.Image = null;
        PB_BG_IMAGE.Image = null;
    }

    private void ShowMessageBoxOk(string message, string header)
    {
        MessageBox.Show(message, header, MessageBoxButtons.OK);
    }

    private void BT_GET_ACCESS_TOKEN_Click(object sender, EventArgs e)
    {
        controller.GetFirstToken();
    }

    private async void BTN_CONSULT_USER_Click(object sender, EventArgs e)
    {
        int userId = 0;
        if (!int.TryParse(this.TXT_USER_ID.Text, out userId))
        {
            ResetScreen();
            ShowMessageBoxOk("No data found", "Error");
            return;
        }

        var userData = await controller.GetUserData(userId);
        if (userData is null)
        {
            ResetScreen();
            ShowMessageBoxOk("No data found", "Error");
            return;

        }

        PB_IMAGE.ImageLocation = userData.avatar_url;
        PB_BG_IMAGE.ImageLocation = userData.cover.url;
        label1.Text = "";
        TXT_OSU_NAME.Text = userData.username;
    }
}
