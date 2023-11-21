using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day30;

public class Product
{
	public Guid ProductId { get; set; }
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public Category Category { get; set; } = null!;
	public Guid CategoryId{ get; set; }
}
