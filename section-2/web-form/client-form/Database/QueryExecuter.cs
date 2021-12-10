using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace client_form.Database
{
    public class QueryExecuter
    {
        public static int InsertCommand(string Query)
        {
            int id;
            using (SqlCommand command = new SqlCommand(Query, DBConnection.ObtenerConexion("connection")))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    id = Convert.ToInt32(reader[0]);
                }
            }
            return id;
        }
    }
}