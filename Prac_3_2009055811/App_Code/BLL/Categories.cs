using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Categories
/// </summary>
public class CCategories
{
	private int iCategoryID;
    private string sCategoryName;

	public CCategories(int _iCategoryID,string _sCategoryName)
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
    // --- STATIC METHOD
    public static List<CCategories> GetCategories()
    {
        return GetCategoryListFromCategoryDetailList(CCategoriesProviderBase.Instance.GetCategories());
    }
    // --- CONVERSION METHODS
    private static List<CCategories> GetCategoryListFromCategoryDetailList(List<CCategoriesDetails> _CategoryDetailObject)
    {
        List<CCategories> Categories = new List<CCategories>();
        if (_CategoryDetailObject != null)
        {
            foreach (CCategoriesDetails categoryDetailObject in _CategoryDetailObject)
            {
                Categories.Add(GetCategoryFromCategoryDetail(categoryDetailObject));
            }
        }
        return Categories;
    }
    private static CCategories GetCategoryFromCategoryDetail(CCategoriesDetails _categoryDetailObject)
    {
        if (_categoryDetailObject == null)
            return null;
        else
        {
            return new CCategories(_categoryDetailObject.CategoryID, _categoryDetailObject.CategoryName);
        }
    }
}