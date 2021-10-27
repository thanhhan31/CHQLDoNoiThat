 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private static string serverName = @"DESKTOP-39OLM42\SQLEXPRESS";
        private static string dbName = @"DBMS_NoiThat";
        private static string connectionString = @"Server=" + serverName + ";Initial Catalog=" + dbName + ";Integrated Security=True;";

        SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;

        public DataProvider()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataSet ExecuteQueryDataSet(string command, CommandType ct, ref string error, params SqlParameter[] parameters)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.CommandType = ct;
                foreach (var p in parameters)
                    sqlCommand.Parameters.Add(p);

                dataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool ExecuteNonQuery(string command, CommandType ct, ref string error, params SqlParameter[] parameters)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.CommandType = ct;
                foreach (var p in parameters)
                    sqlCommand.Parameters.Add(p);

                if (sqlCommand.ExecuteNonQuery() == 0)
                {
                    error = "Không có thay đổi nào được lưu xuống cơ sở dữ liệu";
                    result = false;
                }
                else
                    result = true;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }

        public bool ExecuteScalar<T>(string command, CommandType ct, ref T result, ref string error, params SqlParameter[] parameters)
        {
            bool ret = false;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.CommandType = ct;
                foreach (var p in parameters)
                    sqlCommand.Parameters.Add(p);
                
                result = cast<T>(sqlCommand.ExecuteScalar());
                ret = true;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return ret;
        }

        private static T cast<T>(object obj)
        {
            if (obj is T)
            {
                return (T)obj;
            }
            else
            {
                try
                {
                    return (T)Convert.ChangeType(obj, typeof(T));
                }
                catch (InvalidCastException)
                {
                    return default(T);
                }
            }
        }
    }
}
