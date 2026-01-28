using Microsoft.EntityFrameworkCore;
using SecureProductCreationModuleUsingASPDotNetCoreMVC.Domain.Entities;

namespace SecureProductCreationModuleUsingASPDotNetCoreMVC.Data
{
    public class SequreProductDbContext:DbContext
    {
        public SequreProductDbContext(DbContextOptions<SequreProductDbContext> options) :base(options){ }
        public DbSet<Product> Products{get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>().HasData(
                new Product { ID=1, Name="Smart Watch", Description="Good and stylish", Price= 10000, CreatedDate=new DateTime(2026,01,01)},
                new Product { ID=2, Name="Smart TV", Description="Good and HD", Price= 18000, CreatedDate=new DateTime(2026,01,01)},
                new Product { ID=3, Name="Smart Board", Description="PC and Mobile Support", Price= 18000, CreatedDate=new DateTime(2026,01,01)}
            );
        }
    }
}
