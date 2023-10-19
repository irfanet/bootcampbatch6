class Program
{
	static void Main()
	{
		Samsung<int, int> samsung = new(16,8);
		samsung.Spek();
	}
}

public interface IAndroid
{
	void Browisng();
	void Gaming();
};

public class Samsung<T1, T2> : IAndroid
{
	private T1 _ram;
	private T2 _cpu;
	public Samsung(T1 ram, T2 cpu)
	{
		_ram = ram;
		_cpu = cpu;
	}
	public void Browisng()
	{
		Console.WriteLine("Browsing");
	}
	public void Gaming()
	{
		Console.WriteLine("Gaming");
	}
	public void Spek()
	{
		Console.WriteLine($"Ram: {_ram} \nCPU: {_cpu}");
	}
}