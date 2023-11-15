#define DEBUG
class Program
{
	static void Main(){
		
		#if DEBUG
		Console.WriteLine("mode debugging");
		Console.WriteLine("inputkan nama anda: ");
		// SetName(Console.ReadLine());
		string name = Console.ReadLine();
		// Console.WriteLine
		// Console.WriteLine(name);
		#elif PRODUCTION
		Console.WriteLIne("mode production");
		#else
		Console.WriteLine("mode suka suka");
		#endif
		
		
		
	}
	
	static void SetName(string name)
	{
		Console.WriteLine("inputkan nama anda: ");
	
	}
}