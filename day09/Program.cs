partial class Program
{
	static void Main()
	{
		Car carA = new(3);
		Car carB = new Car(6);
		bool result = carA.Equals(carB);
		result.Dump();
		
	}
}

class Car
{
	public int CarId {get; private set;}
	public Car(int CarId)
	{
		this.CarId = CarId;
	}
	public override bool Equals(object? obj)
	{
		// if(this.ToString() == obj.ToString())
		// {
		// 	return this.CarId == ((Car)obj).CarId;
		// }
		// return false;
		if(obj is Car y) // patern matching 
		{
			var car = obj as Car; // patern matching
			return this.CarId == y.CarId;
		}
		return false;
	}
}

static class MyExtension
{
	public static void Dump(this object e)
	{
		Console.WriteLine(e);
	}
}