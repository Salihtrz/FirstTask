using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
