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
        token =
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxNTE1NyIsImp0aSI6IjEzN2Q5NzY0YzI1ZThhZjBmYjdkZTA4NzYxMmMzY2I3ZDQ2NzdlMzNkYjMzNDJlZGU1OTdhNDAxNTMwMmJmYTljNTk0NDdlY2Y0OWViNzE2IiwiaWF0IjoxNjU0MTczNjYxLjIyMDI1NywibmJmIjoxNjU0MTczNjYxLjIyMDI2LCJleHAiOjE2NTQyNTk4NDMuMTU0MSwic3ViIjoiNjM0NjIyMyIsInNjb3BlcyI6WyJpZGVudGlmeSIsInB1YmxpYyJdfQ.fgFUhqV61mwc9KtsKT-CRaMCGsShZ4yrtP_jI98dS3a47Xa0HMvNqwLaKDmS_9sjYJydwGeu6bo-9KVcBmsFX9epkgvjks2aib2DPU548MwKibdlQspnL-y50I_otwL1-U3ol7Kog4EN4NqcLGWzD59T9gDDB9WnZSIjFRP1daGvMIdfIa_7Sg1ufyMwZ-qpJBTlHwr7akTJDnBi-yoNhO2pwonmdd8sOXe2wdeOcGwKfHV5lv_F_zHXkBR1xyJJmKGVjTxrba6pCuOtvasPMJEzSRot2yevdKYVKT7z0RrBMWm1_W6lzvfvDEdaU-Cye3G8rbXjwRh0VxIzkBwV_ZtDwO3OCnULXT0-Sknzig7hfEzkqENuvuH8MY53Np5dhRwRn-dFj-HVLxQGfH7snNc-Ab0A6OOZpjSzoTkRMtjoR2RH5hd2P4qbKR5BGhPi_MuOmTBzqMXvJWFO5lsXUrJtJmghHHD3cVWX5apYZGB8huRdKigMWHL7dDA18WnwXMLLw5haBWBgYwvT2UlVQAfhzkmQ-0xvnMr5-GDxH-VVQgJZpUmuMpAH-mjNdpNwcxm05OYLthlOh3GSSJGus5IuUeIuYvIskY0kS8MZgVYFK1wATSURV3cuuoxYIr_325MbYHHh25lLW06NvWF6HaSDBjIWKtrz0vDtPiqW-nY";

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
            "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxNTE1NyIsImp0aSI6IjEzN2Q5NzY0YzI1ZThhZjBmYjdkZTA4NzYxMmMzY2I3ZDQ2NzdlMzNkYjMzNDJlZGU1OTdhNDAxNTMwMmJmYTljNTk0NDdlY2Y0OWViNzE2IiwiaWF0IjoxNjU0MTczNjYxLjIyMDI1NywibmJmIjoxNjU0MTczNjYxLjIyMDI2LCJleHAiOjE2NTQyNTk4NDMuMTU0MSwic3ViIjoiNjM0NjIyMyIsInNjb3BlcyI6WyJpZGVudGlmeSIsInB1YmxpYyJdfQ.fgFUhqV61mwc9KtsKT-CRaMCGsShZ4yrtP_jI98dS3a47Xa0HMvNqwLaKDmS_9sjYJydwGeu6bo-9KVcBmsFX9epkgvjks2aib2DPU548MwKibdlQspnL-y50I_otwL1-U3ol7Kog4EN4NqcLGWzD59T9gDDB9WnZSIjFRP1daGvMIdfIa_7Sg1ufyMwZ-qpJBTlHwr7akTJDnBi-yoNhO2pwonmdd8sOXe2wdeOcGwKfHV5lv_F_zHXkBR1xyJJmKGVjTxrba6pCuOtvasPMJEzSRot2yevdKYVKT7z0RrBMWm1_W6lzvfvDEdaU-Cye3G8rbXjwRh0VxIzkBwV_ZtDwO3OCnULXT0-Sknzig7hfEzkqENuvuH8MY53Np5dhRwRn-dFj-HVLxQGfH7snNc-Ab0A6OOZpjSzoTkRMtjoR2RH5hd2P4qbKR5BGhPi_MuOmTBzqMXvJWFO5lsXUrJtJmghHHD3cVWX5apYZGB8huRdKigMWHL7dDA18WnwXMLLw5haBWBgYwvT2UlVQAfhzkmQ-0xvnMr5-GDxH-VVQgJZpUmuMpAH-mjNdpNwcxm05OYLthlOh3GSSJGus5IuUeIuYvIskY0kS8MZgVYFK1wATSURV3cuuoxYIr_325MbYHHh25lLW06NvWF6HaSDBjIWKtrz0vDtPiqW-nY");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Content_Type", "application/json");


        var response = await client.GetAsync($"https://osu.ppy.sh/api/v2/beatmaps/2245784/scores/users/6346223");
        string responseJson = await response.Content.ReadAsStringAsync();
        PlayerScore playerScore = JsonSerializer.Deserialize<PlayerScore>(responseJson);
        return playerScore;
    }

    public static async Task<string> GetFirstToken()
    {
        OsuToken osuTokenClass = new OsuToken()
        {
            client_id = 15157
        };

        var osuTokenClassSerialized = JsonSerializer.Serialize(osuTokenClass);

        client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("Content_Type", "application/json");

        string uriString =
            $"https://osu.ppy.sh/oauth/token";/*"?client_id={clientID}&client_secret={clientSecret}&code={code}&grant_type=authorization_code&redirect_uri=https://guiperinoguiperino.com";*/

        Uri uri = new Uri(uriString);
        var response = await client.PostAsJsonAsync(uri, osuTokenClassSerialized);
        return await response.Content.ReadAsStringAsync();
    }
}

