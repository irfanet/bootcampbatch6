namespace LivingBeing;

public class Dog : Animal
{
	public Dog(string name, int age, bool isHalal) : base(name, age, isHalal)
	{
		Console.WriteLine("Dog instance created");
	}
	public void Run() 
	{
		Console.WriteLine("Run");
	}
	public void Bark() 
	{
		Console.WriteLine("Bark");
	}
}
