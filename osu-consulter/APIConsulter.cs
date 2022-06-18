using System.Text;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace osu_consulter;
public static class APIConsulter
{
    static private HttpClient client;
    private static int clientID;
    private static string authorize;
    private static string accessToken;
    private static string clientSecret;
    private static string code;
    private static string token;
    private static string refreshToken;
    static APIConsulter()
    {
        authorize = "https://osu.ppy.sh/oauth/authorize?response_type=code&client_id=15157&redirect_uri=https://guiperinoguiperino.com&scope=public";
    }

    public static async Task<string> GetTest(string s)
    {
        client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://osu.ppy.sh/api/v2/");
        return await response.Content.ReadAsStringAsync();
    }

    public static async Task<PlayerScore> GetBeatmapScore(int playerID, int beatmapID)
    {
        client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://osu.ppy.sh/api/v2/beatmaps/{beatmapID}/scores/users/{playerID}");

        var response = await client.SendAsync(request);
        string responseJson = await response.Content.ReadAsStringAsync();

        PlayerScore playerScore = JsonConvert.DeserializeObject<PlayerScore>(responseJson);
        if (playerScore.score is null)
            return null;
        return playerScore;
    }

    public async static void GetFirstToken()
    {
        OsuTokenRequest osuTokenRequestClass = new OsuTokenRequest();

        var osuTokenClassSerialized = JsonConvert.SerializeObject(osuTokenRequestClass);

        client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var request = new HttpRequestMessage(HttpMethod.Post, "https://osu.ppy.sh/oauth/token");
        request.Content = new StringContent(osuTokenClassSerialized, Encoding.UTF8, "application/json");
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await client.SendAsync(request);
        string responseJson = await response.Content.ReadAsStringAsync();

        token = JsonConvert.DeserializeObject<OsuToken>(responseJson).access_token;
    }

    public async static Task<UserData> GetUserData(string user = "1")
    {
        if (user == "1")
            user = "6346223";
        client = new HttpClient();

        var request = new HttpRequestMessage(HttpMethod.Get, $"https://osu.ppy.sh/api/v2/users/{user}");
        var content = new { key = "username" };
        request.Content = new StringContent(JsonConvert.SerializeObject(content));
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await client.SendAsync(request);
        string responseJson = await response.Content.ReadAsStringAsync();

        UserData userData = JsonConvert.DeserializeObject<UserData>(responseJson);
        return userData ?? new UserData();
    }
}

