using System.ComponentModel;

public class Composite : IComponent
{
	private string _name;
	private int _fee;
	private List<IComponent> _components = new();
	
	public Composite(string name, int fee)
	{
		_name = name;
		_fee = fee;
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
			totalPrice += p.GetPrice() - FeeCalculation(GetPrice());
		}
		// Console.WriteLine($"total price: {totalPrice}");
		return totalPrice;
	}

	public int FeeCalculation(int beforeFee)
	{
		return beforeFee * _fee / 100;
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
