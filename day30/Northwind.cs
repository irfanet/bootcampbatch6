using Microsoft.EntityFrameworkCore;

namespace day30;


public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("FileName = ./MyDatabase.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(cat =>
            {
                cat.Property(c => c.CategoryName).HasMaxLength(50).IsRequired();
                cat.HasKey(c => c.CategoryId);
                cat.Property(c => c.Description).HasMaxLength(100);
                cat.HasMany(c => c.Products).WithOne(p => p.Category);
            });
        modelBuilder.Entity<Product>(pro =>
            {
                pro.HasKey(p => p.ProductId);
                pro.Property(p => p.ProductName).IsRequired().HasMaxLength(50);
                pro.Property(p => p.Description).HasMaxLength(100);
                pro.HasOne(p => p.Category).WithMany(c => c.Products);

            });


        Product[] seedProducts = {
            new Product() {
                ProductId = Guid.Parse("ed473b45-1055-4513-8b1b-c50a697ed387"),
                ProductName = "Xiaomi",
                Description = "Ini xiaomi",
                CategoryId = Guid.Parse("d4181d3c-1e2f-4ed9-8f16-1bade0cc3c8e")
                },
            new Product() {
                ProductId = Guid.Parse("7f0809f6-c836-40fd-bf40-2f43c6a48d36"),
                ProductName = "Pisang",
                Description = "Ini Pisang",
                CategoryId = Guid.Parse("2fc94449-99cb-481e-826f-633af1e38981")
                }
        };
        Category[] seedCategory = {
            new Category() {
                CategoryId = Guid.Parse("d4181d3c-1e2f-4ed9-8f16-1bade0cc3c8e"),
                CategoryName = "Handphone",
                Description = "Ini category Handphone",
                },
            new Category() {
                CategoryId = Guid.Parse("2fc94449-99cb-481e-826f-633af1e38981"),
                CategoryName = "Buah",
                Description = "Ini category Buah",
                }
        };
        //Data Seeding
        modelBuilder.Entity<Product>(pro =>
        {
            pro.HasData(seedProducts);
        });
        modelBuilder.Entity<Category>(cat =>
        {
            cat.HasData(seedCategory);
        });
    }
}
