using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask1.Models;
namespace EFTask1.Context
{
    internal class ProductDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=my_db;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Product>Products { get; set; }
    }
}
