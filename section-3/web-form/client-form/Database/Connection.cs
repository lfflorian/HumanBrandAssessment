using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace client_form.Database
{
    public class Connection
    {
        private static Connection instance = null;
        private static readonly object padlock = new object();
        public string ConnectionString;

        Connection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }

        public static Connection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Connection();
                    }
                    return instance;
                }
            }
        }
    }
}