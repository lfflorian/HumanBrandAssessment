using Database_client.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Database
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        { }

        public virtual DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsUnicode(false);
                entity.Property(e => e.LastName).IsUnicode(false);
                entity.Property(e => e.DPI).IsUnicode(false);
                entity.Property(e => e.CreateDate).IsUnicode(false);
            });
        }
    }
}
