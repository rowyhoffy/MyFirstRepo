using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoriesDetails
/// </summary>
public class CCategoriesDetails
{
    private int iCategoryID;
    private string sCategoryName;

	public CCategoriesDetails(int _iCategoryID,string _sCategoryName)
	{
        this.CategoryID = _iCategoryID;
        this.CategoryName = _sCategoryName;
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
    public string CategoryName
    {
        get 
        {
            return sCategoryName;
        }
        set 
        {
            sCategoryName = value;
        }
    }
}