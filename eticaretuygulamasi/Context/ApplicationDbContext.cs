using eticaretuygulamasi.Models;
using Microsoft.EntityFrameworkCore;

namespace eticaretuygulamasi.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Procducts { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
