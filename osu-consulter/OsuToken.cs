using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_consulter
{
    [Serializable]
    class OsuToken
    {
        public int client_id { get; set; }
        public string client_secret { get; set; }
        public string code { get; set; }
        public string grant_type { get; set; }
        public string redirect_uri { get; set; }

        public OsuToken()
        {
            code =
                "def50200b9e6ddb2d88303cdd3ccf90c65348799b4d70d01c948e9db6f8c518752e7585af7f5f85d6fa657ba210cf15dc05acf489f17a814fc5dc4af99a2a14045c1f479e4e6f158b41c6ad46632044c4a23e5838f271e2725442fa8e039022fa2149279a0d89c7ee28ca87cab51a215b30bcfec5870b54af021e9977e5d4be40a088996056ef715278e77a98d90819faba41724a11476cbb1949b3e05de621184b056f2081cd9cb32434a4d3f4ab12bb03b709f01d2632c3a70edb0723ff6608da8116c7c35b01619ff60fca322cc4e57391e17f99330c51b6f22d77263d011d4dc445c8ec74dece8ce9edbab8a7ccd53bbf8629b9580d648d9cf96360f0d662c5e0f95c8d070e7dd5ea375491a95d77242fb6258cef1acdfa450df0f36d9261f693eedb9731322851e71e0d9db4d05c3eff07f98a0114f83c8d6275babfa71dfdadd05cb6f1641245a1fa5a78a94e6fa2f6f02d420fe7b2a34d5d4ba99263768ab1631a8422ac38aebe6902ad0a212773c562799a2af3bb88e";
            client_secret = "jwhcyv6wAjwJF58g83Y1gMnURtvbzsJ4M9P2aE4r";
            grant_type = "authorization_code";
            redirect_uri = "https://guiperinoguiperino.com";
        }
    }
}
