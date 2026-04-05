using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DbNewOOPCore;integrated security=True;TrustServerCertificate=True;");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
