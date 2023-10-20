class Program
{
	static void Main()
	{
		"hello".Dump();
		// Add(4,6,9,e).Dump();
		try
		{
			Add(4,6,9,10).Dump();
		}
		catch(Exception e){
			e.Message.Dump();
		}
		
	}
	static int Add(params int[] n)
	{
		int result = default;
		foreach(int element in n)
		{
			result += element;
		}
		return result;
	}
}
static class MyExtension
{
	public static void Dump(this object x)
	{
		Console.WriteLine(x);
	}
}