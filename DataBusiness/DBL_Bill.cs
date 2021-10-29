using System.Data;
using System.Data.SqlClient;
using System;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_Bill
    {
        DataProvider dataProvider;

        public DBL_Bill()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_bills(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_Bill",
                CommandType.StoredProcedure,
                ref error);
        }

        public DataSet get_view_bills(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_BILLS",
                CommandType.Text,
                ref error);
        }

        public DataSet get_view_billhistory(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_QL_BILLHISTORY",
                CommandType.Text,
                ref error);
        }

        public DataSet get_ql_billHistory_createDate(DateTime createDate, ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM dbo.fn_ql_get_billHistory_by_createDate(@createTime)",
                CommandType.Text,
                ref error,
                new SqlParameter("@createTime", createDate));
        }

        public DataSet get_nv_billHistory_createDate(DateTime createDate, ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM dbo.fn_nv_get_billHistory_by_createDate(@createTime)",
                CommandType.Text,
                ref error,
                new SqlParameter("@createTime", createDate));
        }

        public DataSet get_nv_billHistory(String id, ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM dbo.fn_nv_get_billHistory(@id)",
                CommandType.Text,
                ref error,
                new SqlParameter("@id", id)
                );
        }

        public DataSet get_billDetails_by_idBill(String id, ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM dbo.fn_get_billDetails(@id)",
                CommandType.Text,
                ref error,
                new SqlParameter("@id", id)
                );
        }

        public bool add_bill(string id, string idEmployee, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_insBill",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@idEmployee", idEmployee)
                );
        }

        public bool update_bill(string id, string idEmployee, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_updBill",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@idEmployee", idEmployee)
                );
        }

        public bool delete_bill(string id, ref string error)
        {
            bool candelete = false;
            if (dataProvider.ExecuteScalar("SELECT dbo.fn_can_modify_bill(@id)",
                    CommandType.Text,
                    ref candelete,
                    ref error,
                    new SqlParameter("@id", id)
                ))
            {
                if (candelete)
                {
                    bool success = dataProvider.ExecuteNonQuery(
                        "sp_delBill",
                        CommandType.StoredProcedure,
                        ref error,
                        new SqlParameter("@id", id));
                    if (!success)
                        error = "Database error, can't delete bill: " + error;
                    return success;
                }
                else
                {
                    error = "This bill contains bill details";
                    return false;
                }
            }
            else
            {
                error = "Call fn_can_modify_bill failed: " + error;
                return false;
            }
        }
    }
}
