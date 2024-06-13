using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using System.Diagnostics;

namespace Solid.Data
{
    public class DataContaxt : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Turn> Turns { get; set; }
        public DbSet<ServiceProviders> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Miryam_db");

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
    }
}
