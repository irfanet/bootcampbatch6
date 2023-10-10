using LivingBeing;

public class Whale : Animal
{
	public Whale (string name, int age, bool isHalal) : base(name, age, isHalal)
	{
		Console.WriteLine("Whale instance created");
	}
	public void Swim() 
	{
		Console.WriteLine("Swim");
	}
	
}
