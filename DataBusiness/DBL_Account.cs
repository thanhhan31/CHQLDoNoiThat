using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System;
using DataAccessLayer;

namespace DataBusiness
{
    public class DBL_Account
    {
        DataProvider dataProvider;
        public DBL_Account()
        {
            dataProvider = new DataProvider();
        }

        public DBL_Account(string username, string hashed_password)
        {
            dataProvider = new DataProvider(username, hashed_password);
        }

        public DataSet get_account_info(string email, string hashed_password, ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM dbo.fn_account_detail(@email, @password)",
                CommandType.Text,
                ref error,
                new SqlParameter("@email", email),
                new SqlParameter("@password", hashed_password)
                );
        }

        public DataSet admin_get_accounts(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_NV",
                CommandType.StoredProcedure,
                ref error
                );
        }

        public DataSet admin_get_view_accounts(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "SELECT * FROM V_QL_ACCOUNTS",
                CommandType.Text,
                ref error
                );
        }

        public bool add_employee(string id, string name, DateTime dob, string gender,
            string phone, string idNo, string address, string email, string password, byte[] avatar, int idType, bool active, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_add_employee",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@dob", SqlDbType.Date) { Value = dob },
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@idNo", idNo),
                new SqlParameter("@address", address),
                new SqlParameter("@email", email),
                new SqlParameter("@password", password),
                avatar.Length != 0 ?
                    new SqlParameter("@avatar", SqlDbType.VarBinary) { Value = avatar } :
                    new SqlParameter("@avatar", SqlBinary.Null),
                new SqlParameter("@idType", idType),
                new SqlParameter("@active", SqlDbType.Bit) { Value = active }
                );
        }

        public bool admin_update_employee(string id, string name, DateTime dob, string gender,
            string phone, string idNo, string address, string email, string password, byte[] avatar, int idType, bool active, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_admin_update_employee",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@dob", SqlDbType.Date) { Value = dob },
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@idNo", idNo),
                new SqlParameter("@address", address),
                new SqlParameter("@email", email),
                new SqlParameter("@password", password),
                avatar.Length != 0 ?
                    new SqlParameter("@avatar", SqlDbType.VarBinary) { Value = avatar } :
                    new SqlParameter("@avatar", SqlBinary.Null),
                new SqlParameter("@idType", idType),
                new SqlParameter("@active", SqlDbType.Bit) { Value = active }
                );
        }

        public bool user_update_info(string id, string name, DateTime dob, string gender,
            string phone, string idNo, string address, byte[] avatar, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_user_update_info",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@dob", SqlDbType.Date) { Value = dob },
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@idNo", idNo),
                new SqlParameter("@address", address),
                avatar.Length != 0 ? new SqlParameter("@avatar", SqlDbType.VarBinary) { Value = avatar } : new SqlParameter("@avatar", SqlDbType.VarBinary) { Value = DBNull.Value }
                );
        }

        public bool deactive_employee(string email, ref string error)
        {
            return dataProvider.ExecuteNonQuery(
                "sp_hide_employee",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@email", email)
                );
        }

        public bool user_update_password(string id, string email, string old_password, string new_password, ref string error)
        {
            var returnParam = new SqlParameter("@ReturnVal", SqlDbType.Bit) { Direction = ParameterDirection.ReturnValue };
            
            if (!dataProvider.ExecuteNonQuery(
                "sp_user_update_password",
                CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@id", id),
                new SqlParameter("@email", email),
                new SqlParameter("@old_password", old_password),
                new SqlParameter("@new_password", new_password),
                returnParam
                ))
                return false;
            return (int)returnParam.Value == 1 ? true : false;
        }
    }
}
