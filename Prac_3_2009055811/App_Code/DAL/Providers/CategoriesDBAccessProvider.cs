using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.OleDb;
using System.Configuration;

/// <summary>
/// Summary description for CategoriesDBAccessProvider
/// </summary>
public class CCategoriesDBAccessProvider:CCategoriesProviderBase
{
    public override List<CCategoriesDetails> GetCategories()
    {
        using (OleDbConnection conn = new OleDbConnection(
            ConfigurationManager.ConnectionStrings["gameData_AccessConnection"].ConnectionString))
        {
            conn.Open();
            string cmdText = "SELECT CategoryID, CategoryName FROM tblCategory";
            OleDbCommand cmd = new OleDbCommand(cmdText, conn);

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return GetCategoryDetailsCollectionFromReader(reader);
        }
    }
}