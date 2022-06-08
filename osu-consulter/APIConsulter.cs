using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        clientID = 15157;
        clientSecret = "jwhcyv6wAjwJF58g83Y1gMnURtvbzsJ4M9P2aE4r";
        authorize = "https://osu.ppy.sh/oauth/authorize?response_type=code&client_id=15157&redirect_uri=https://guiperinoguiperino.com&scope=public";

        code =
            "def5020088a00352e5574f7d20aceee2ee0d0df5d5672a2a0fab7f45d5b0c462d658d97b3d13bfa4d18f006e8360786638ea62f19e0d41f0d3e05c239a1b9eea2cce016c2c7bf26632eac3e050949a5a0ef85af71eb1fde0de9fff06b6f8d0de23ac9d7599d4d369c069a5f22ab659b506489adaaa5384f0e57fc77a32f285abe45f6567225613258e3e87ced4484c35151ce497b010237472d6ae031cb4cf0422e535d453b3a6cabdff5ec940648202f0353b08ef5c8c14a75c6fabe9de3de6d1ac3b664bb9013a6f5f2c8caf08b3cb9bdbf039a22e905d7c4aa30c90852919f3a9a6ac6c30fa602d1df69defacd4d4be4f2d18ba1086866188ea431e9c60668d7839957691211bf6cb8d8e6de64c142a50d12bf04e35e2a813c611dc43f3dc84824584abb7b1a62ad8e9fd34627c04859793d1007dc2b3e38d0466c9a4df4a8207d68b222fc58df87a78cc51f79002442ec3315e5a9f6731446a79ccec85735d3162cbf9ed97bb86ea9d58103f7838883f647c1b0fc24ef8bd";
        //token =
        //    "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxNTE1NyIsImp0aSI6IjJlZGIzNWY4NTZjMDM5ZDU4M2Y1MmZlODgyOWFiZTBmZTQ0NGJhYmQ0NjAzM2M0YWUyNTE1YWRiOGZjMTA5NWI2ZDkyNmI5NzEzZjdjYWRkIiwiaWF0IjoxNjU0NjE3ODI1Ljk1MDE2LCJuYmYiOjE2NTQ2MTc4MjUuOTUwMTY0LCJleHAiOjE2NTQ3MDQxNzkuMzU3MjgzLCJzdWIiOiI2MzQ2MjIzIiwic2NvcGVzIjpbImlkZW50aWZ5IiwicHVibGljIl19.QHSRkylPxb-weZ_nzDza50ZPpseHT6NEnYFA3h-Tv1L1-IMOeKHkkyHMgdVn6RWZ4q1hQDlJky-y_IOLyux8p0Bq0kyDZ3j36Zhe_EC99r6Fb2HT5xc-LH1sGcnj7Z3XsU5kmDRhaYHBCCn4qFvFf-eZ3xuY1wKuBF_e9sBEp0lb16lo-DcCpCScAoCk8vFny3M7PI4d6K4oN6pFrcBAFmWpkTn8vetZ244F4MKTj7V52ZbKYH5PlrCnvRb_FaTwSnfJ1Orh1D_BaU5R9aJZUICBn3OIBq8oYpGRxzANkgjICkIgBfrse5kXJ9erAC35J_xCBNDfIxhlSUCwB9cHYh6rGL7A-TAknRtBFe73ejsnkRBh8sPgJ4GqDwahZnmX_bmi6MZvLlZsA5IQdBj-aAEO94Nw2p7TN_4rlByattojdpCQrbXj_20b9Z_jLuVLeVrrpEuR8wI7AzUG_SOc7Ml3R0GeNE9VeR901nRTCzZ5Wkj0vq8-LsUaCB6Z7wMTaiKqPkkA-1M3y-TBQVrAmTv0WC_WtpkS60MVLC6lGbUzCDUzs4fIgr6f0OCSEEo6wqtv1QY7pPJe0igK-MiUv6qTX1LuSEEcPGJVNf4OJ5WpmRq5xm9KiEhW8K3heRG40DNzgHc1mJ2RMHPInmJYWUrdiP4dbvQhhH_NioUmJto";

        accessToken = $"https://osu.ppy.sh/oauth/token?client_id={clientID}&client_secret={clientSecret}&code:{code}&grant_type=authorization_code&redirect_uri=https://guiperinoguiperino.com";
        accessToken += "";
    }

    public static async Task<string> GetTest(string s)
    {
        client = new HttpClient();
        HttpResponseMessage response =  await client.GetAsync("https://osu.ppy.sh/api/v2/");
        return await response.Content.ReadAsStringAsync();
    }

    public static async Task<PlayerScore> GetBeatmapScore(int playerID, int beatmapID)
    {
        client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
            token);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await client.GetAsync($"https://osu.ppy.sh/api/v2/beatmaps/{beatmapID}/scores/users/{playerID}");
        string responseJson = await response.Content.ReadAsStringAsync();

        PlayerScore playerScore = JsonSerializer.Deserialize<PlayerScore>(responseJson);
        if (playerScore.score is null)
            return null;
        return playerScore;
    }

    public async static void GetFirstToken()
    {
        OsuTokenRequest osuTokenRequestClass = new OsuTokenRequest();

        var osuTokenClassSerialized = JsonSerializer.Serialize(osuTokenRequestClass);

        client = new HttpClient();
        client.BaseAddress = new Uri("https://osu.ppy.sh/oauth/token");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

        string uriString = "https://osu.ppy.sh/api/v2/";
        var response = await client.GetAsync(uriString);

        string responseJson =  await response.Content.ReadAsStringAsync();
        token = JsonSerializer.Deserialize<OsuToken>(responseJson).access_token;
    }

    public async static Task<UserData> GetUserData(int user = 1)
    {
        if (user == 1)
            user = 6346223;
        client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
            token);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var response = await client.GetAsync($"https://osu.ppy.sh/api/v2/users/{user}/osu?key={user}");
        string responseJson = await response.Content.ReadAsStringAsync();
        UserData userData = JsonSerializer.Deserialize<UserData>(responseJson);
        return userData;
    }
}

