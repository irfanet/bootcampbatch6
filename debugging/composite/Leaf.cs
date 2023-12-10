using System.ComponentModel;

public class Leaf : IComponent
{
	private int _price;
	
	private string _name;
	
	public Leaf(string name, int price)
	{
		_price = price;
		_name = name;
	}
	public void Add(IComponent component)
	{
		throw new NotImplementedException();
	}
	
	public string GetName()
	{
		return _name;
	}

	public int GetPrice()
	{
		return _price;
	}

	public bool ISComposite()
	{
		return false;
	}

	public void Remove(IComponent component)
	{
		throw new NotImplementedException();
	}

}
