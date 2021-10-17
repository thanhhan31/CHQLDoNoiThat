using System.Data;
using System.Data.SqlClient;
using System;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_Inventory
    {
        DataProvider dataProvider;

        public DBL_Inventory()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_inventories(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_Lo",
                CommandType.StoredProcedure,
                ref error);
        }

        public DataSet admin_get_view_inventories(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_QL_INVENTORIES",
                CommandType.Text,
                ref error);
        }

        public DataSet employee_get_view_inventories(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_NV_INVENTORIES",
                CommandType.Text,
                ref error);
        }

        public bool add_inventory(string id, string idProduct, int quantity, 
            decimal originalPrice, decimal profit, decimal vat, DateTime importDate, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_add_inventory",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@idProduct", idProduct),
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@originalPrice", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = originalPrice },
                new SqlParameter("@profit", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = profit },
                new SqlParameter("@vat", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = vat },
                new SqlParameter("@importDate", SqlDbType.Date) { Value = importDate }
                );
        }

        public bool update_inventory(string id, string idProduct, int quantity,
            decimal originalPrice, decimal profit, decimal vat, DateTime importDate, ref string error)
        {
            bool canupdate = false;
            if (dataProvider.ExecuteScalar("SELECT dbo.fn_can_modify_inventory(@id)",
                    CommandType.Text,
                    ref canupdate,
                    ref error,
                    new SqlParameter("@id", id)
                ))
            {
                bool success = dataProvider.ExecuteNonQuery(
                    "sp_update_inventory",
                    CommandType.StoredProcedure,
                    ref error,
                    new SqlParameter("@id", id),
                    new SqlParameter("@idProduct", idProduct),
                    new SqlParameter("@quantity", quantity),
                    new SqlParameter("@originalPrice", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = originalPrice },
                    new SqlParameter("@profit", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = profit },
                    new SqlParameter("@vat", SqlDbType.Decimal) { Precision = 19, Scale = 5, Value = vat },
                    new SqlParameter("@importDate", SqlDbType.Date) { Value = importDate }
                    );
                if (!success)
                    error = "Database error, can't update inventory: " + error;
                return success;
            }
            else
            {
                if (!canupdate)
                    error = "This inventory is selling/sold out";
                else
                    error = "Call fn_can_modify_inventory failed: " + error;
                return canupdate;
            }
        }

        public bool delete_inventory(string id, ref string error)
        {
            bool canupdate = false;
            if (dataProvider.ExecuteScalar("SELECT dbo.fn_can_modify_inventory(@id)",
                    CommandType.Text,
                    ref canupdate,
                    ref error,
                    new SqlParameter("@id", id)
                ))
            {
                if (canupdate)
                {
                    bool success = dataProvider.ExecuteNonQuery(
                    "sp_delete_inventory",
                    CommandType.StoredProcedure,
                    ref error,
                    new SqlParameter("@id", id)
                    );
                    if (!success)
                        error = "Database error, can't delete inventory: " + error;
                    return success;
                }
                else
                {
                    error = "This inventory is selling/sold out";
                    return false;
                }
                
            }
            else
            {
                error = "Call fn_can_modify_inventory failed: " + error;
                return false;
            }
        }
    }
}
