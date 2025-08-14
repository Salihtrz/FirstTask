using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALIH\\SQLEXPRESS;initial Catalog=FirstTask;integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
