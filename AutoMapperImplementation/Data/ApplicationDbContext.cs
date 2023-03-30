using AutoMapperImplementation.Entities;
using AutoMapperImplementation.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperImplementation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
        public DbSet<Product> Product { get; set; }
    }
}
