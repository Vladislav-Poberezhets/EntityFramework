using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class ApplicationsContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; } = null!;

        public DbSet<Customers> Customers { get; set; } = null!;
        public DbSet<Products> Products { get; set; } = null!;

        public DbSet<Orders> Orders { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Shop;Trusted_Connection=True;");
        }
    }
}
