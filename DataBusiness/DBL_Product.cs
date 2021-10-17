using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_Product
    {
        DataProvider dataProvider;

        public DBL_Product()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_products(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_SP",
                CommandType.StoredProcedure,
                ref error);
        }

        public DataSet employee_get_view_product(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_NV_PRODUCTS",
                CommandType.Text,
                ref error);
        }

        public DataSet admin_get_view_product(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_QL_PRODUCTS",
                CommandType.Text,
                ref error);
        }

        public bool add_product(string id, string idCategory, string name, byte[] image, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_add_product",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@idCategory", idCategory),
                new SqlParameter("@name", name),
                image.Length != 0 ?
                    new SqlParameter("@image", SqlDbType.VarBinary) { Value = image } :
                    new SqlParameter("@image", SqlBinary.Null)
                );
        }

        public bool update_product(string id, string idCategory, string name, byte[] image, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_update_product",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@idCategory", idCategory),
                new SqlParameter("@name", name),
                image.Length != 0 ?
                    new SqlParameter("@image", SqlDbType.VarBinary) { Value = image } :
                    new SqlParameter("@image", SqlBinary.Null)
                );
        }

        public bool delete_product(string id, ref string error)
        {
            bool candelete = false;
            if (dataProvider.ExecuteScalar("SELECT dbo.fn_can_modify_product(@id)",
                    CommandType.Text,
                    ref candelete,
                    ref error,
                    new SqlParameter("@id", id)
                ))
            {
                if (candelete)
                {
                    bool success = dataProvider.ExecuteNonQuery("sp_delete_product",
                    CommandType.StoredProcedure,
                    ref error,
                    new SqlParameter("@id", id));
                    if (!success)
                        error = "Database error, can't delete product: " + error;
                    return success;
                }
                else
                {
                    error = "This product is selling/has been sold";
                    return false;
                }
            }
            else
            {
                error = "Call fn_can_modify_product failed: " + error;
                return false;
            }
        }
    }
}
