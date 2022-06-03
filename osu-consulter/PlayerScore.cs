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
    public UserOsu user { get; set; }
}

[Serializable]
public class UserOsu
{
    public string username { get; set; }
    public string avatar_url { get; set; }
}

