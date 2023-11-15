using System;
// using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		// Task<int> task = new Task<int>(() => CobaTask("hahaha","hihihi","huhuhu",2));
		// Task<int> task = Task.Run(() => CobaTask("hahaha","hihihi","huhuhu",2));
		// TaskStatus x = task.Status;
		// task.Start(); 
		// task.Wait(); 
		// task.Result.Dump();	
		try
		{		

			// Task t1 = Task.Run(() => CobaExeption1());
			// Task t2 = Task.Run(() => CobaExeption2());
			// Task t3 = Task.Run(() => CobaExeption3());
			// t1.Wait();
			// t2.Wait();
			// t3.Wait();
			
			Task<List<int>> t1 = Task.Run(() => CobaList());
			t1.Wait();
			foreach(int e in t1.Result)
			{
				Console.WriteLine(e);
			}

		
		}catch(AggregateException e)
		{
			e.Dump();
		}
	}
	
	static void CobaExeption1()
	{
		bool isTrue = true;
		if(isTrue)
		{
			if(isTrue)
			{
				throw new ArgumentException("error 3");
			}
			throw new ArgumentException("error 2");	
		}
		throw new ArgumentException("error 1");
	}
	static void CobaExeption2()
	{
		throw new ArgumentException("error 2");
	}
	static void CobaExeption3()
	{
		throw new ArgumentException("error 3");
	}
	
	static int CobaTask(string message, string m2, string m3, int n)
	{
		Console.WriteLine(message);
		Console.WriteLine(m2);
		Console.WriteLine(m3);
		Console.WriteLine(n);
		return n*n;
		
	}
	
	static List<int> CobaList()
	{
		List<int> n = new();
		n.Add(1);
		n.Add(2);
		n.Add(3);
		return n;
	}
}
static class MyExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}
}
