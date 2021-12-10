using client_form.Database;
using client_form.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace client_form.Service
{
    public class ClientService
    {
        public IEnumerable<Client> GetClients()
        {
            IEnumerable<Client> clients;
            string Query = $"SELECT Id, Nombre, DPI, Fecha FROM Cliente";

            using (var con = new SqlConnection(Connection.Instance.ConnectionString))
            {
                clients = con.Query<Client>(Query);
            }

            return clients;
        }

        public void deleteClient(int id)
        {
            string Query = $"DELETE from cliente WHERE Id = @id";

            using (var con = new SqlConnection(Connection.Instance.ConnectionString))
            {
                con.Execute(Query, new {  id } );
            }
        }
    }
}