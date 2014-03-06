using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Games
/// </summary>
public class CGames
{
	private int iGameID;
    private string sGameTitle;
    private string sGamePictureURL;
    private decimal dGamePrice;
    private int iCategoryID;
    private DateTime dtGameReleaseDate;

	public CGames(int _iGameID,string _sGameTitle,string _sGamePictureURL,decimal _dGamePrice,int _iCategoryID,DateTime _dtGameReleaseDate)
	{
        this.iGameID = _iGameID;
        this.sGameTitle = _sGameTitle;
        this.sGamePictureURL = _sGamePictureURL;
        this.dGamePrice = _dGamePrice;
        this.iCategoryID = _iCategoryID;
        this.dtGameReleaseDate = _dtGameReleaseDate;
	}
    public int GameID
    {
        get 
        {
            return iGameID;
        }
        set 
        {
            iGameID = value;
        }
    }
    public string GameTitle
    {
        get 
        {
            return sGameTitle;
        }
        set 
        {
            sGameTitle = value;
        }
    }
    public string GamePictureURL
    {
        get 
        {
            return sGamePictureURL;
        }
        set 
        {
            sGamePictureURL = value;
        }
    }

    public decimal GamePrice
    {
        get 
        {
            return dGamePrice;
        }
        set 
        {
            dGamePrice = value;
        }
    }
    public int CategoryID
    {
        get 
        {
            return iCategoryID;
        }
        set 
        {
            iCategoryID = value;
        }
    }
    public DateTime GameReleaseDate
    {
        get 
        {
            return dtGameReleaseDate;
        }
        set 
        {
            dtGameReleaseDate = value;
        }
    }
    // --- INSTANCE METHODS
    public int Delete()
    {
        int iSuccess = CGames.Delete(this.GameID);
            this.GameID = 0;
        return iSuccess;
    }
    public int Update()
    {
        return CGames.Update(this.GameID,this.GameTitle, this.GamePictureURL, this.GamePrice, this.GameReleaseDate);
    }
    // --- STATIC METHODS
    public static List<CGames> GetGamesInRange(decimal Min, decimal Max, int CategoryID)
    {
        return GetGameListFromGameDetailList(CGamesProviderBase.Instance.GetGamesInRange(Min, Max, CategoryID));
    }
    public static CGames GetGame(int GameID)
    {
        return GetGameFromGameDetail(CGamesProviderBase.Instance.GetGame(GameID));
    }
    public static int Delete(int GameID)
    {
        return CGamesProviderBase.Instance.DeleteGame(GameID);
    }
    public static int Insert(string GameTitle,string GamePictureURL,decimal GamePrice,int CategoryID,DateTime GameReleaseDate)
    {
        return CGamesProviderBase.Instance.InsertGame(GameTitle,GamePictureURL,GamePrice,CategoryID,GameReleaseDate);
    }
    public static int Update(int GameID,string GameTitle, string GamePictureURL, decimal GamePrice, DateTime GameReleaseDate)
    {
        return CGamesProviderBase.Instance.UpdateGame(GameID, GameTitle, GamePictureURL, GamePrice, GameReleaseDate);
    }
    // --- CONVERSION METHODS
    private static List<CGames> GetGameListFromGameDetailList(List<CGamesDetails> _GameDetailObject)
    {
        List<CGames> Games = new List<CGames>();
        if (_GameDetailObject != null)
        {
            foreach (CGamesDetails gameDetailObject in _GameDetailObject)
            {

                Games.Add(GetGameFromGameDetail(gameDetailObject));
            }
        }

        return Games;
    }
    private static CGames GetGameFromGameDetail(CGamesDetails _GameDetailObject)
    {
        if (_GameDetailObject == null)
            return null;
        else 
        {
            return new CGames(_GameDetailObject.GameID, _GameDetailObject.GameTitle, _GameDetailObject.GamePictureURL,
                              _GameDetailObject.GamePrice, _GameDetailObject.CategoryID, _GameDetailObject.GameReleaseDate);
        }
    }
}