using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Dapper;
using osu_consulter.DB_Config.Entities;

namespace osu_consulter.DB_Config;
public class DBConfig
{
    private string _connectionString;
    private SqlConnection cnn;
    public string ConnectionString
    {
        get { return _connectionString; }
    }
    public DBConfig()
    {
        _connectionString = "Data Source=34.151.253.60;Initial Catalog=Teste;User ID=sqlserver;Password=Guipe@2022";

    }
    public void SavePlayerData(UserData pData)
    {
        cnn = new SqlConnection(_connectionString);
        PlayerData playerData = new PlayerData()
        {
            ID = pData.id,
            NAME = pData.username,
            GLOBAL_RANK = pData.statistics.global_rank is null? 0: (int)pData.statistics.global_rank,
            COUNTRY_RANK = pData.statistics.rank.country is null? 0 : (int)pData.statistics.rank.country,
            IMAGE_URL = pData.avatar_url,
            BG_IMAGE_URL = pData.cover.url
        };

        if (!PlayerRegisterExists(pData.id))
            return;

        cnn.Execute(@"INSERT INTO PLAYER_DATA 
            (
            [ID]
           ,[NAME]
           ,[GLOBAL_RANK]
           ,[COUNTRY_RANK]
           ,[IMAGE_URL]
           ,[BG_IMAGE_URL]
            ) 
            VALUES( @ID, @NAME, @GLOBAL_RANK, @COUNTRY_RANK, @IMAGE_URL, @BG_IMAGE_URL)",
            playerData);
    }
    public void TestConnection()
    {
        cnn = new SqlConnection(_connectionString);
        PlayerData playerData = new PlayerData()
        {
            ID = 3,
            NAME = "Teste3",
            GLOBAL_RANK = 3,
            COUNTRY_RANK = 3,
        };
        try
        {
            if (!PlayerRegisterExists(playerData.ID))
                cnn.Execute(@"INSERT INTO PLAYER_DATA 
            (
            [ID]
           ,[NAME]
           ,[GLOBAL_RANK]
           ,[COUNTRY_RANK]
           ,[IMAGE_URL]
           ,[BG_IMAGE_URL]
            ) 
            VALUES( @ID, @NAME, @GLOBAL_RANK, @COUNTRY_RANK, @IMAGE_URL, @BG_IMAGE_URL)", playerData);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private bool PlayerRegisterExists(int id)
    {
        PlayerData pData = new PlayerData
        {
            ID = id
        };
        var result = cnn.Query<PlayerData>(@"SELECT ID FROM PLAYER_DATA 
            WHERE
            ID = @ID",
            pData);

        if (result.ToList().Count > 0)
            return false;

        return true;
    }
}

