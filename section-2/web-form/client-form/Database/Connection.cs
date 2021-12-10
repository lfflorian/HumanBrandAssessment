using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace client_form.Database
{
    public class Connection
    {
        public string ConfigurationStringName { get; set; }
        public SqlConnection SQLConnection { get; set; }
        public Connection(string configurationStringName, SqlConnection sqlconnection)
        {
            ConfigurationStringName = configurationStringName;
            SQLConnection = sqlconnection;
        }
    }
}