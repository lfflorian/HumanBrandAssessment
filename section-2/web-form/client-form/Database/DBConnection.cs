using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace client_form.Database
{
    public class DBConnection
    {
        private DBConnection() { }

        /// <summary>
        ///  Get connection from the name of the connection string
        /// </summary>
        /// <param name="KeyConnection">Name of the key from the connection string</param>
        /// <returns>Sql connection</returns>
        public static SqlConnection ObtenerConexion(string KeyConnection)
        {
            return InternaHolder.GetInstance(KeyConnection);
        }

        private static class InternaHolder
        {
            private static List<Connection> Connections = new List<Connection>();

            public static SqlConnection GetInstance(string KeyConnection)
            {
                if (Connections.Count <= 0)
                {
                    return CreateConnection(KeyConnection);
                }
                else
                {
                    if (Connections.Exists(x => x.ConfigurationStringName == KeyConnection))
                    {
                        var connection = Connections.Find(x => x.ConfigurationStringName == KeyConnection).SQLConnection;
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        return connection;
                    }
                    else
                    {
                        return CreateConnection(KeyConnection);
                    }
                }
            }

            public static SqlConnection CreateConnection(string KeyConnection)
            {
                var newConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                newConnection.Open();
                Connections.Add(new Connection(KeyConnection, newConnection));
                return newConnection;
            }

            public static void Cerrar()
            {
                Connections.ForEach(c => {
                    if (!(c.SQLConnection == null))
                    {
                        c.SQLConnection.Close();
                    }
                });
            }
        }
    }
}