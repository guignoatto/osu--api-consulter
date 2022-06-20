using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace osu_consulter.Controllers;
public class MainScreenController
{
    public readonly string guiperinoID = "6346223";
    public readonly string defaultMap = "1149638";
    public async Task<string> FindBaseUrl()
    {
        return await APIConsulter.GetTest("");
    }

    public async Task<PlayerScore> GetPlayerScore(int playerID, int beatmapID)
    {
        var playerScore = await APIConsulter.GetBeatmapScore(playerID, beatmapID);

        return playerScore ?? new PlayerScore();
    }

    public async Task<UserData> GetUserData(string playerID)
    {
        UserData userData = await APIConsulter.GetUserData(playerID);
        if (userData.username is null)
            return null;
        return userData;
    }

    public void GetFirstToken()
    {
        APIConsulter.GetFirstToken();
    }

    public async Task<string> GetPlayerImage(PlayerScore playerScore)
    {
        string userImgUrl = playerScore.score.user.avatar_url;
        return userImgUrl;
    }

    public async Task<string> GetPlayerBgImage(PlayerScore playerScore)
    {
        string userBgImgUrl = playerScore.score.user.cover.url;
        return userBgImgUrl;
    }


    private Image DownloadImage(string url, bool isBackground = false)
    {
        string background = "";
        if (isBackground)
            background = "Background";

        WebClient client = new WebClient();
        client.DownloadFile(new Uri(url), Path.GetTempPath() + $"user{background}Image.jpeg");

        if (File.Exists(Path.GetTempPath() + $"user{background}Image.jpeg"))
        {
            Image image;
            using (Stream stream = File.OpenRead(Path.GetTempPath() + $"user{background}Image.jpeg"))
            {
                image = Image.FromStream(stream);
            }

            File.Delete(Path.GetTempPath() + $"user{background}Image.jpeg");
            return image;
        }

        return null;
    }
}
