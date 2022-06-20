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
    public CoverData cover { get; set; }
    public CountryData country { get; set; }
    public StatisticsData statistics { get; set; }
}
[Serializable]
public class CountryData
{
    public string code { get; set; }
    public string name { get; set; }
}
[Serializable]
public class CoverData
{
    public string custom_url { get; set; }
    public string url { get; set; }
    public object id { get; set; }
}

[Serializable]
public class StatisticsData
{
    public string pp { get; set; }
    public RankData rank { get; set; }
    public string hit_accuracy { get; set; }

    public int ?global_rank { get; set; }
}

[Serializable]
public class LevelData
{
    public int current { get; set; }
    public int progress { get; set; }

}

[Serializable]
public class RankData
{
    public int global { get; set; }
    public int ?country { get; set; }

}


