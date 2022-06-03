using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace osu_consulter.Controllers
{
    public class MainScreenController
    {
        public async Task<string> FindBaseUrl()
        {
            return await APIConsulter.GetTest("");
        }

        public async Task<PlayerScore> GetPlayerScore(int playerID, int beatmapID)
        {
            PlayerScore playerScore = await APIConsulter.GetBeatmapScore(playerID, beatmapID);
            GetImage(playerScore);
            return playerScore;
        }

        public async Task GetImage(PlayerScore playerScore)
        {
            var userImageUrl = playerScore.score.user.avatar_url;
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(userImageUrl), @"c:\temp\userImage.png");
        }
    }
}
