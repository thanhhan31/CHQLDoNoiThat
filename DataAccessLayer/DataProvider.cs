using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private static string serverName = @"DESKTOP-RLFQC12\SQLEXPRESS01";
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
            bool result = true;
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
            }
            catch (Exception e)
            {
                result = false;
                error = e.Message + "(" + e.Source + ")";
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }

        public bool ExecuteNonQuery(string command, CommandType ct, ref string error, List<List<SqlParameter>> paramList)
        {
            bool result = true;
            try
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();

                foreach (var i in paramList)
                {
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection, transaction);
                    sqlCommand.CommandType = ct;
                    foreach (var p in i)
                        sqlCommand.Parameters.Add(p);
                    if (sqlCommand.ExecuteNonQuery() == 0)
                    {
                        error = "Không có thay đổi nào được lưu xuống cơ sở dữ liệu";
                        result = false;
                        break;
                    }
                }
                if (result)
                    transaction.Commit();
                else
                    transaction.Rollback();
            }
            catch (Exception e)
            {
                result = false;
                error = e.Message + "(" + e.Source + ")";
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
