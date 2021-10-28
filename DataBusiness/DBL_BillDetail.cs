using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
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

        public bool add_billdetail(string idBill, List<CartItem> cartitems, ref string error)
        {
            List<List<SqlParameter>> paramList = new List<List<SqlParameter>>();

            foreach (var i in cartitems)
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@idBill", idBill));
                sqlParameters.Add(new SqlParameter("@idProduct", i.ProductId));
                sqlParameters.Add(new SqlParameter("@quantity", i.Quantity));
                paramList.Add(sqlParameters);
            }

            return dataProvider.ExecuteNonQuery(
                "sp_insBillDetail",
                CommandType.StoredProcedure,
                ref error,
                paramList
                );
        }
    }
}
