namespace LivingBeing;

public class Cat : Animal
{
	public Cat(string name, int age, bool isHalal) : base(name,age,isHalal)
	{
		Console.WriteLine("Cat instance created");
	}
	public void Jump() 
	{
		Console.WriteLine("Jump");
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
}
