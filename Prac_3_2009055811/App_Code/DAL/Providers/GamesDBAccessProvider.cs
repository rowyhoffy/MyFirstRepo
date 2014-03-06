using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.OleDb;
using System.Configuration;

/// <summary>
/// Summary description for GamesDBAccessProvider
/// </summary>
public class CGamesDBAccessProvider:CGamesProviderBase
{
    public override List<CGamesDetails> GetGamesInRange(decimal Min, decimal Max, int CategoryID)
    {
        using (OleDbConnection conn = new OleDbConnection(
            ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();
            string cmdText = "SELECT GameID,GameTitle,GamePictureURL,GamePrice,CategoryID,GameReleaseDate FROM	tblGame WHERE	(GamePrice >= @min) AND (GamePrice <= @max) AND (CategoryID=@category)";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            OleDbParameter[] OleParam = new OleDbParameter[]
            {
                new OleDbParameter("min",OleDbType.Decimal),
                new OleDbParameter("max", OleDbType.Decimal),
                new OleDbParameter("category", OleDbType.Integer)
            };

            OleParam[0].Value = Min;
            OleParam[1].Value = Max;
            OleParam[2].Value = CategoryID;

            cmd.Parameters.AddRange(OleParam);

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read())
                return GetGameDetailsCollectionFromReader(reader);
            else
                return null;
        }
    }
    public override CGamesDetails GetGame(int GameID)
    {
        using (OleDbConnection conn = new OleDbConnection(
            ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();

            string cmdText = "SELECT * FROM tblGame WHERE GameID=@GameID";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            cmd.Parameters.Add("GameID", OleDbType.Integer).Value = GameID;

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (reader.Read())
                return GetGameDetailsFromReader(reader);
            else
                return null;
        }
    }
    public override int InsertGame(string GameTitle, string GamePictureURL, decimal GamePrice,int CategoryID, DateTime GameReleaseDate)
    {
        using (OleDbConnection conn = new OleDbConnection(
            ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();

            string cmdText = "INSERT INTO tblGame(GameTitle,GamePictureURL,GamePrice,CategoryID,GameReleaseDate) VALUES (@GameTitle,@GamePictureURL,@GamePrice,@CategoryID,@GameReleaseDate)";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            OleDbParameter[] OleParam = new OleDbParameter[]
            {
                new OleDbParameter("@GameTitle",OleDbType.VarChar,50),
                new OleDbParameter("@GamePictureURL",OleDbType.VarChar,200),
                new OleDbParameter("@GamePrice",OleDbType.Currency),
                new OleDbParameter("@CategoryID",OleDbType.Integer),
                new OleDbParameter("@GameReleaseDate",OleDbType.Date)
            };

            OleParam[0].Value = GameTitle;
            OleParam[1].Value = GamePictureURL;
            OleParam[2].Value = GamePrice;
            OleParam[3].Value = CategoryID;
            OleParam[4].Value = GameReleaseDate;

            cmd.Parameters.AddRange(OleParam);

            return cmd.ExecuteNonQuery();
        }
    }
    public override int UpdateGame(int GameID, string GameTitle, string GamePictureURL, decimal GamePrice, DateTime GameReleaseDate)
    {
        using (OleDbConnection conn = new OleDbConnection(
       ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();
            string cmdText = "UPDATE tblGame SET GameTitle = @GameTitle, GamePictureURL = @GamePictureURL, GamePrice = @GamePrice, GameReleaseDate = @GameReleaseDate WHERE	(GameID = @GameID)";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            OleDbParameter[] OleParam = new OleDbParameter[]
            {
                new OleDbParameter("@GameTitle",OleDbType.VarChar,50),
                new OleDbParameter("@GamePictureURL",OleDbType.VarChar,200),
                new OleDbParameter("@GamePrice",OleDbType.Currency),
                new OleDbParameter("@GameReleaseDate",OleDbType.Date),
                new OleDbParameter("@GameID",OleDbType.Integer),
            };
            
            OleParam[0].Value = GameTitle;
            OleParam[1].Value = GamePictureURL;
            OleParam[2].Value = GamePrice;
            OleParam[3].Value = GameReleaseDate;
            OleParam[4].Value = GameID;


            cmd.Parameters.AddRange(OleParam);

            return cmd.ExecuteNonQuery();
        }
    }
    public override int DeleteGame(int GameID)
    {
        using (OleDbConnection conn = new OleDbConnection(
        ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();

            string cmdText = "DELETE FROM tblGame WHERE (GameID = @GameID)";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            OleDbParameter param = new OleDbParameter("@GameID", OleDbType.Integer);

            param.Value = GameID;
            cmd.Parameters.Add(param);

            return cmd.ExecuteNonQuery();
        }
    }
}