using System.Data;
using System.Data.SqlClient;
using System;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_BillDetail
    {
        DataProvider dataProvider;

        public DBL_BillDetail()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_billdetails(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_BillDetail",
                CommandType.StoredProcedure,
                ref error);
        }

        public DataSet get_view_billdetails(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_BILLDETAILS",
                CommandType.Text,
                ref error);
        }

        public bool add_billdetail(string idBill, string idProduct, int quantity, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_insBillDetail",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@idBill", idBill),
                new SqlParameter("@idProduct", idProduct),
                new SqlParameter("@quantity", quantity)
                );
        }
    }
}
