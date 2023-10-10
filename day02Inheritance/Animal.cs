namespace LivingBeing;

public class Animal
{
	public string name;
	public int age;
	public bool isHalal;
	public Animal(string name, int age, bool isHalal) 
	{
		Console.WriteLine($"Animal {name} instance created");
		this.name = name;
		this.age = age;
		this.isHalal = isHalal;
	}

	public void Eat() 
	{
		Console.WriteLine("Eat");
	}
	
	public void PrintAnimal()
	{
		Console.WriteLine($"Name {this.name}");	
		Console.WriteLine($"Age {this.age}");	
		Console.WriteLine($"Is it Halal {this.isHalal}");	
	}
}
