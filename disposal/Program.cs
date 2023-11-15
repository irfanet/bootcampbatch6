class Program
{
	static void Main()
	{
		string path = @"./myFile.txt";
		using(FileStream file = new FileStream(path ,FileMode.Create)) 
		{
			using(StreamWriter sw = new(file))
			{
				sw.WriteLine("Hello Gaes mau coba dispose c# using using");
			}
		}
		
		Car car = new Car();
		car.Type = "toyota";
		car.Type.Dump();
				

	}
}

class Car
{
	public string? Type {get; set;}
}

static class myExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}
}