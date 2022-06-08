using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace osu_consulter;

[Serializable]
public class PlayerScore
{
    public int position { get; set; }
    public Score score { get; set; }
}

[Serializable]
public class Score
{
    public UserData user { get; set; }
}

[Serializable]
public class UserData
{
    public string username { get; set; }
    public string avatar_url { get; set; }
    public CoverOsu cover { get; set; }
}
public class CoverOsu
{
    public string custom_url { get; set; }
    public string url { get; set; }
    public object id { get; set; }
}


