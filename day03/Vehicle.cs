namespace Transportation;
public class Vehicle
{
	private string _name;
	private string _type;
	private int _door;
	private int _cc;
	private const string _BRAND = "TOYOTA";

	public Vehicle(string name, string type, int door, int cc){
		_name = name;
		_type = type;
		_door = door;
		_cc = cc;
	}

	public string getName()
	{
		return _name;
	}
	public string getType()
	{
		return _type;
	}
	public int getDoor()
	{
		return _door;
	}
	public int getCc()
	{
		return _cc;
	}
	public string getBrand()
	{
		return _BRAND;
	}
	public void setName(string name)
	{
		_name = name;
	}
	public void setType(string type)
	{
		_type = type;
	}
	public void setDoor(int door)
	{
		_door = door;
	}
	public void setCc(int cc)
	{
		_cc = cc;
	}
}