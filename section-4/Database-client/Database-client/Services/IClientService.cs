using Database_client.Database;
using Database_client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Services
{
    public interface IClientService
    {
        ClientDbContext DbContext { get; set; }
        Task Add(Client client);
    }
}
