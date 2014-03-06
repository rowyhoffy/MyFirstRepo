using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for GamesDBSQLProvider
/// </summary>
public class CGamesDBSQLProvider:CGamesProviderBase
{
    public override List<CGamesDetails> GetGamesInRange(decimal Min, decimal Max, int CategoryID)
    {
        using (SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("gameGetGamesInRange", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] SqlParams = new SqlParameter[]
            {
                new SqlParameter("min", SqlDbType.Decimal),
                new SqlParameter("max", SqlDbType.Decimal),
                new SqlParameter("category", SqlDbType.Int)
            };

            SqlParams[0].Value = Min;
            SqlParams[1].Value = Max;
            SqlParams[2].Value = CategoryID;

            cmd.Parameters.AddRange(SqlParams);

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read())
                return GetGameDetailsCollectionFromReader(reader);
            else
                return null;
        }
    }
    public override CGamesDetails GetGame(int GameID)
    {
        using (SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();


            SqlCommand cmd = new SqlCommand("gameGetGameByGameID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("GameID", SqlDbType.Int).Value = GameID;

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (reader.Read())
                return GetGameDetailsFromReader(reader);
            else
                return null;
        }
    }
    public override int InsertGame(string GameTitle, string GamePictureURL, decimal GamePrice,int CategoryID, DateTime GameReleaseDate)
    {
        using (SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();


            SqlCommand cmd = new SqlCommand("gameInsertGame", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] SqlParams = new SqlParameter[]
            {
                new SqlParameter("@GameTitle",SqlDbType.VarChar,50),
                new SqlParameter("@GamePictureURL",SqlDbType.VarChar,200),
                new SqlParameter("@GamePrice",SqlDbType.Money),
                new SqlParameter("@CategoryID",SqlDbType.Int),
                new SqlParameter("@GameReleaseDate",SqlDbType.Date)
            };

            SqlParams[0].Value = GameTitle;
            SqlParams[1].Value = GamePictureURL;
            SqlParams[2].Value = GamePrice;
            SqlParams[3].Value = CategoryID;
            SqlParams[4].Value = GameReleaseDate;

            cmd.Parameters.AddRange(SqlParams);

            return cmd.ExecuteNonQuery();
        }
    }
    public override int UpdateGame(int GameID,string GameTitle, string GamePictureURL, decimal GamePrice, DateTime GameReleaseDate)
    {
        using (SqlConnection conn = new SqlConnection(
       ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("gameUpdateGame", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] SqlParams = new SqlParameter[]
            {
                new SqlParameter("@GameID",SqlDbType.Int),
                new SqlParameter("@GameTitle",SqlDbType.NVarChar,50),
                new SqlParameter("@GamePictureURL",SqlDbType.NVarChar,200),
                new SqlParameter("@GamePrice",SqlDbType.Money),
                new SqlParameter("@GameReleaseDate",SqlDbType.Date) 
            };
            SqlParams[0].Value = GameID;
            SqlParams[1].Value = GameTitle;
            SqlParams[2].Value = GamePictureURL;
            SqlParams[3].Value = GamePrice;
            SqlParams[4].Value = GameReleaseDate;


            cmd.Parameters.AddRange(SqlParams);

            return cmd.ExecuteNonQuery();
        }
    }
    public override int DeleteGame(int GameID)
    {
        using (SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();


            SqlCommand cmd = new SqlCommand("gameDeleteGame", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@GameID", SqlDbType.Int);
     
            param.Value = GameID;
            cmd.Parameters.Add(param);

            return cmd.ExecuteNonQuery();
        }
    }
}