using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBusiness
{
    public class DBL_Statistic
    {
        DataProvider dataProvider;
        public DBL_Statistic()
        {
            dataProvider = new DataProvider();
        }
        public DataSet statistic_allyear(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_revenue_allyear",
                CommandType.StoredProcedure,
                ref error);
        }
        public DataSet statistic_allmonth(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_revenue_allmonth",
                CommandType.StoredProcedure,
                ref error);
        }
        public DataSet statistic_allquarter(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_revenue_allquarter",
                CommandType.StoredProcedure,
                ref error);
        }
        public DataSet statistic_custom(DateTime startDate, DateTime endDate,  ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "select * from dbo.fn_revenue_report(@startDate, @endDate)",
                CommandType.Text,
                ref error,
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate));
        }
    }
}
