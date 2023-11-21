using day30;

class Program
{
	static async Task Main()
	{
		using (Northwind db = new Northwind())
		{
			Guid catguid = db.Categories
							.FirstOrDefault(c => c.CategoryName == "Kendaraan")
							.CategoryId;
			Product newProduct = new Product()
			{
				ProductId = Guid.NewGuid(),
				ProductName = "Kijang",
				Description = "Ini Kijang",
				CategoryId = catguid
			};
			await db.Products.AddAsync(newProduct);
			await db.SaveChangesAsync();
		}
	}
}