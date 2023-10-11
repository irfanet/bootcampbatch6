using Transportation;
class Program
{
	static void Main()
	{
		// Car corola = new Car("corolla","daily",4,150);
		Vehicle mustang = new Vehicle("mustang","sport",4,1000);
		Console.WriteLine(mustang.getName());
		Console.WriteLine(mustang.getType());
		Console.WriteLine(mustang.getDoor());
		Console.WriteLine(mustang.getCc());
		Console.WriteLine(mustang.getBrand());
		// Vehicle alphard = new Vehicle();
		// alphard.setName("alphard");
		// alphard.setType("business");
		// alphard.setDoor(4);
		// alphard.setCc(1200);
		
	} 
}