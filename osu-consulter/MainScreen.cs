using System.Data;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using osu_consulter.Controllers;
using Newtonsoft.Json;
using osu_consulter.DB_Config;

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
        ResetScreen();
        int beatmapId = 0;
        string userId = "";
        if (!string.IsNullOrEmpty(this.TXT_USER_ID.Text) && !int.TryParse(this.TXT_BEATMAP_ID.Text, out beatmapId))
        {
            ShowMessageBoxOk("No data found", "Error");
            return;
        }

        userId = TXT_USER_ID.Text;

        var playerScore = await controller.GetPlayerScore(userId, beatmapId);
        if (playerScore.score is null)
        {
            ShowMessageBoxOk("No data found", "Error");
            return;
        }
        PB_IMAGE.ImageLocation = await controller.GetPlayerImage(playerScore);
        PB_BG_IMAGE.ImageLocation = await controller.GetPlayerBgImage(playerScore);
        LBL_BEATMAP_RANK.Text = playerScore.position.ToString();
        TXT_GLOBAL_RANK.Text = playerScore.score.user.statistics.global_rank.ToString();
        TXT_COUNTRY_RANK.Text = playerScore.score.user.statistics.rank.country.ToString();
        TXT_USERNAME_SHOW.Text = playerScore.score.user.username;
    }

    private void ResetScreen()
    {
        LBL_BEATMAP_RANK.Text = "";
        TXT_COUNTRY_RANK.Text = "";
        TXT_GLOBAL_RANK.Text = "";
        TXT_USERNAME_SHOW.Text = "";
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
        ResetScreen();
        string userId = "";
        if (String.IsNullOrEmpty(this.TXT_USER_ID.Text))
        {
            ShowMessageBoxOk("No data found", "Error");
            return;
        }

        userId = TXT_USER_ID.Text;

        var userData = await controller.GetUserData(userId);
        if (userData is null)
        {
            ShowMessageBoxOk("No data found", "Error");
            return;

        }
        DBConfig db = new DBConfig();
        db.SavePlayerData(userData);
        PB_IMAGE.ImageLocation = userData.avatar_url;
        PB_BG_IMAGE.ImageLocation = userData.cover.url;
        TXT_GLOBAL_RANK.Text = userData.statistics.global_rank.ToString();
        TXT_COUNTRY_RANK.Text = userData.statistics.rank.country.ToString();
        TXT_USERNAME_SHOW.Text = userData.username;
    }

    private void BTN_TEST_CONNECTION_Click(object sender, EventArgs e)
    {
        DBConfig db = new DBConfig();
        db.TestConnection();
    }
}
