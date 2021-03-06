﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Parameter
    {
        private string _connString = "";

        public Parameter()
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @".\sqlexpress",
                InitialCatalog = @"DB_Sample1",
                IntegratedSecurity = true
            };
            _connString = connStringBuilder.ToString();
        }

        public SqlConnection CreateAndOpenConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(_connString);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }
    }
}
