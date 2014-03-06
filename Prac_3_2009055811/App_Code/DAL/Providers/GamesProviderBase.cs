using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

/// <summary>
/// Summary description for GamesProviderBase
/// </summary>
public abstract class CGamesProviderBase
{
    static private CGamesProviderBase gpbInstance = null;
    static public CGamesProviderBase Instance
    {
        get 
        {
            if (gpbInstance == null)
            {
                gpbInstance = new CGamesDBSQLProvider();
                //gpbInstance = new CGamesDBAccessProvider();
            }
            return gpbInstance;
        }
    }
    // --- ABSTRACT METHODS
    public abstract List<CGamesDetails> GetGamesInRange(decimal Min, decimal Max, int CategoryID);
    public abstract CGamesDetails GetGame(int GameID);
    public abstract int InsertGame(string GameTitle, string GamePictureURL, decimal GamePrice,int CategoryID, DateTime GameReleaseDate);
    public abstract int UpdateGame(int GameID,string GameTitle, string GamePictureURL, decimal GamePrice, DateTime GameReleaseDate);
    public abstract int DeleteGame(int GameID);
    // --- CONVERSION METHODS
    protected CGamesDetails GetGameDetailsFromReader(IDataReader reader)
    {
        return new CGamesDetails((int)reader["GameID"],
                                 (string)reader["GameTitle"],
                                 (string)reader["GamePictureURL"],
                                 (decimal)reader["GamePrice"],
                                 (int)reader["CategoryID"],
                                 (DateTime)reader["GameReleaseDate"]);
    }
    
    protected List<CGamesDetails> GetGameDetailsCollectionFromReader(IDataReader reader)
    {
        List<CGamesDetails> Games = new List<CGamesDetails>();
        while (reader.Read())
            Games.Add(GetGameDetailsFromReader(reader));
        return Games;
    }
}
public abstract class CCategoriesProviderBase
{
    static private CCategoriesProviderBase cpbInstance = null;
    static public CCategoriesProviderBase Instance
    {
        get
        {
            if (cpbInstance == null)
            {
                cpbInstance = new CCategoriesDBSQLProvider();
                //cpbInstance = new CCategoriesDBAccessProvider();
            }
            return cpbInstance;
        }
    }
    // --- ABSTRACT METHODS
    public abstract List<CCategoriesDetails> GetCategories();

    // --- CONVERSION METHODS
    protected CCategoriesDetails GetCategoryDetailsFromReader(IDataReader reader)
    {
        return new CCategoriesDetails((int)reader["CategoryID"], (string)reader["CategoryName"]);
    }
    protected List<CCategoriesDetails> GetCategoryDetailsCollectionFromReader(IDataReader reader)
    {
        List<CCategoriesDetails> Categories = new List<CCategoriesDetails>();
        while (reader.Read())
            Categories.Add(GetCategoryDetailsFromReader(reader));
        return Categories;
    }
}