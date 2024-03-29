﻿using System.Data;
using System.Data.SqlClient;
using System;
using DataAccessLayer;


namespace DataBusiness
{
    public class DBL_TypeAccount
    {
        DataProvider dataProvider;
        public DBL_TypeAccount()
        {
            dataProvider = new DataProvider();
        }

        public DataSet get_typeaccounts(ref string error)
        {
            return dataProvider.ExecuteQueryDataSet(
                "sp_DS_TYPEACCS",
                CommandType.StoredProcedure,
                ref error
                );
        }
    }
}
