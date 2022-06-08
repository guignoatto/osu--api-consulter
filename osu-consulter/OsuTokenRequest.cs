using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_consulter
{
    [Serializable]
    class OsuTokenRequest
    {
        public int client_id { get; set; }
        public string client_secret { get; set; }
        public string grant_type { get; set; }
        public string scope { get; set; }

        public OsuTokenRequest()
        {
            client_id = 15157;
            client_secret = "jwhcyv6wAjwJF58g83Y1gMnURtvbzsJ4M9P2aE4r";
            grant_type = "client_credentials";
            scope = "public";
        }
    }
}
