namespace osu_consulter.DB_Config.Entities;
[Serializable]
public class PlayerData
{
    public int ID { get; set; }
    public string NAME { get; set; }
    public long GLOBAL_RANK { get; set; }
    public long COUNTRY_RANK { get; set; }
    public string IMAGE_URL { get; set; }
    public string BG_IMAGE_URL { get; set; }
}