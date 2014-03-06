using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for CategoriesDBSQLProvider
/// </summary>
public class CCategoriesDBSQLProvider:CCategoriesProviderBase
{
    public override List<CCategoriesDetails> GetCategories()
    {
        using (SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["gameData_SQLConnection"].ConnectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("categoryGetCategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return GetCategoryDetailsCollectionFromReader(reader);
        }
    }
}