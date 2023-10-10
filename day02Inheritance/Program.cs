using LivingBeing;

class Program 
{
	static void Main() 
	{
		Cat cat = new Cat("oyen",12,false);
		cat.PrintAnimal();
		
		Whale whale = new Whale("orca",13,true);
		whale.PrintAnimal();
	}
}