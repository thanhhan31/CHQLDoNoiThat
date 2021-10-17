using System.Data;
using System.Data.SqlClient;
using System;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_Category
    {
        DataProvider dataProvider;

        public DBL_Category()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_categories(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_LSP",
                CommandType.StoredProcedure,
                ref error);
        }

        public bool add_category(string id, string name, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_add_category",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@name", name)
                );
        }

        public bool update_category(string id, string name, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_update_category",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@name", name)
                );
        }

        public bool delete_category(string id, ref string error)
        {
            bool candelete = false;
            if (dataProvider.ExecuteScalar("SELECT dbo.fn_can_modify_category(@id)",
                    CommandType.Text,
                    ref candelete,
                    ref error,
                    new SqlParameter("@id", id)
                ))
            {
                if (candelete)
                {
                    bool success = dataProvider.ExecuteNonQuery(
                    "sp_delete_category",
                    CommandType.StoredProcedure,
                    ref error,
                    new SqlParameter("@id", id)
                    );
                    if (!success)
                        error = "Database error, can't delete category: " + error;
                    return success;
                }
                else
                {
                    error = "This category has selling/sold product";
                    return false;
                }
                
            }
            else
            {
                error = "Call fn_can_modify_category failed: " + error;
                return false;
            }
        }
    }
}
