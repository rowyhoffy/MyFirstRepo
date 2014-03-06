using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GamesDetails
/// </summary>
public class CGamesDetails
{
    private int iGameID;
    private string sGameTitle;
    private string sGamePictureURL;
    private decimal dGamePrice;
    private int iCategoryID;
    private DateTime dtGameReleaseDate;

    public CGamesDetails()
    {
 
    }
	public CGamesDetails(int _iGameID,string _sGameTitle,string _sGamePictureURL,decimal _dGamePrice,int _iCategoryID,DateTime _dtGameReleaseDate)
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
}