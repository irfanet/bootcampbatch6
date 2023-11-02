using System.Text;

class Program
{
	static void Main()
	{
		string test = string.Empty;
		for(int i = 0; i <= 100000; i++)
		{
			test += "a";
			test += "b";
		}
		Console.WriteLine(test);
		GC.Collect();
		
		// StringBuilder sb = new();
		// for(int i = 0; i <= 100000; i++)
		// {
		// 	sb.Append("s");
		// 	sb.Append("b");
		// }
		// Console.WriteLine(sb);
		// GC.Collect();
		
		// int xy = 0;
		// for(int i = 0; i <= 100000; i++)
		// {
		// 	xy+=1;
		// 	xy+=5;
		// }
		// Console.WriteLine(xy);
		// GC.Collect();
	}
}