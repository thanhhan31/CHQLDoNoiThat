using DataAccessLayer;
using System.Data;

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
    }
}
