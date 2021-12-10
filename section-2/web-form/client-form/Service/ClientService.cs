using client_form.Database;
using client_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace client_form.Service
{
    public class ClientService
    {
        public void InsertClient(Client client)
        {
            string Query = $"INSERT INTO Cliente (Nombre, DPI, FECHA) VALUES ('{client.Nombre}','{client.DPI}','{client.Fecha}'); SELECT SCOPE_IDENTITY()";
            var id = QueryExecuter.InsertCommand(Query);
            client.Id = id;
        }
    }
}