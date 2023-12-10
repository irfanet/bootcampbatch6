using System;
namespace DestructorExample
{
	public class First
	{
		~First()
		{
			Console.WriteLine("Destructor of First Called");
		}
	}

	public class Second : First
	{
		~Second()
		{
			Console.WriteLine("Destructor of Second Called");
		}
	}

	public class Third : Second
	{
		~Third()
		{
			Console.WriteLine("Destructor of Third Called");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Third obj = new Third();
			obj = null;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}