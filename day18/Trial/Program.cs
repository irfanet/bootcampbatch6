//Thread
class Program 
{
	static void Main()
	{
		Console.WriteLine("Kantor buka");
		
		Thread threadOne = new Thread(LongTask);
		threadOne.IsBackground = true;
		Thread threadTwo = new Thread(ShortTask);
		threadTwo.IsBackground = true;
		
		threadOne.Start();
		threadTwo.Start();
		
		Console.WriteLine("Kantor bangkrut");
	}
	static void LongTask()
	{
		Thread.Sleep(10); //Calculation Time
		Console.WriteLine("Karyawan 1 : Ok pak, saya kerja");
		Thread.Sleep(3000); //Calculation Time
		Console.WriteLine("Karyawan 1 : Sudah selesai");
	}
	static void ShortTask()
	{
		Thread.Sleep(10);
		Console.WriteLine("Karyawan 2 : Ok pak, saya kerja ");
		Console.WriteLine("Karyawan 2 : Sudah selesai");
	}
}