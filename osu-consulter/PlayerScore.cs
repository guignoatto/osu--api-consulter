using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public int id { get; set; }
    public string username { get; set; }
    public string avatar_url { get; set; }
    public CoverOsu cover { get; set; }
    public UserStatistics statistics { get; set; }
}

[Serializable]
public class CoverOsu
{
    public string custom_url { get; set; }
    public string url { get; set; }
    public object id { get; set; }
}

[Serializable]
public class UserStatistics
{
    public string pp { get; set; }
    public UserRank rank { get; set; }
    public string hit_accuracy { get; set; }

    public int ?global_rank { get; set; }
}

[Serializable]
public class UserLevel
{
    public int current { get; set; }
    public int progress { get; set; }

}

[Serializable]
public class UserRank
{
    public int global { get; set; }
    public int ?country { get; set; }

}


