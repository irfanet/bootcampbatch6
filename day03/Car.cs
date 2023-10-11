namespace Transportation;
public class Car : Vehicle
{
	public Car(string name, string type, int door, int cc) : base(name, type, door, cc)
	{
		Console.WriteLine("Car instance created");
	}

}