using Microsoft.EntityFrameworkCore;

namespace day29;


public class Northwind : DbContext
{
	public DbSet<Category> Categories {get; set;}
	public DbSet<Product> Products {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Filename=./Northwind.db");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(e => e.CategoryId);
			category.Property(e => e.CategoryName).IsRequired().HasMaxLength(40);
			category.Property(e => e.CategoryName).HasColumnType("NTEXT");
			category.HasMany(category => category.Products).WithOne(e => e.Category);
		});
		
		modelBuilder.Entity<Product>(product => 
		{
			product.HasKey(e => e.ProductId);
			product.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
			product.Property(p => p.Cost).HasColumnType("money").HasColumnName("UnitPrice");
		});
		
		modelBuilder.Entity<OrderDetail>(order =>
		{
			order.HasKey(o => new { o.OrderId, o.ProductId });
		});
	}


}
