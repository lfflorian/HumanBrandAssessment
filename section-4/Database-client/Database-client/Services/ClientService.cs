using Database_client.Database;
using Database_client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Services
{
    public class ClientService : IClientService
    {
        public ClientDbContext DbContext { get; set; }

        public ClientService(ClientDbContext context)
        {
            this.DbContext = context;
        }

        public async Task Add(Client client)
        {
            await DbContext.AddAsync<Client>(client).ConfigureAwait(false);
            await DbContext.SaveChangesAsync();
        }
    }
}
