class Program
{
	static void Main()
	{
		Checkout bayar = new();
		Console.WriteLine(bayar.Login(true));
		bayar.ProductName();
		bayar.Payment();

	}


}

interface IBayar
{
	bool Login(bool status);
	void Payment();
}

interface IChart
{
	void ProductName();
}

class Checkout : IChart, IBayar
{
	public bool Login(bool status)
	{
		if (status == false)
		{
			return false;
		}
		return true;
	}

	public void Payment()
	{
		Console.WriteLine("Bayar berhasil");
	}

	public void ProductName()
	{
		Console.WriteLine("Busi motor");
	}
}