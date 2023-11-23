using System.ComponentModel;

namespace day32.composite;

public class Composite : IComponent
{
	private string _name;
	private List<IComponent> _components = new();
	
	public Composite(string name)
	{
		_name = name;
	}
	public void Add(IComponent component)
	{
		_components.Add(component);
	}
	public int GetPrice()
	{
		int totalPrice = 0;
		foreach(var p in _components)
		{
			totalPrice += p.GetPrice();
		}
		// Console.WriteLine($"total price: {totalPrice}");
		return totalPrice;
	}
	public int GetPriceWithTax(int tax)
	{
		int totalPrice = 0;
		foreach(var p in _components)
		{
			totalPrice = p.GetPrice()+tax;
		}
		// Console.WriteLine($"total price: {totalPrice}");
		return totalPrice;
	}
	public bool ISComposite()
	{
		return true;
	}
	public void Remove(IComponent component)
	{
		_components.Remove(component);
	}
	
	public void DisplayTree()
	{
		foreach(var c in _components)
		{
			Console.WriteLine($"product: {c.GetName()} price: {c.GetPrice()}");
		}
	}
	
	public string GetName()
	{
		return _name;
	}

}
