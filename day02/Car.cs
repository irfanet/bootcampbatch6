using CarComponent;

namespace Transportation;

public class Car
{
	public Engine mesin;
	public Tire ban;
	public Lamp lamp;
	
	public Car(Engine engine, Tire tire, Lamp lamp) 
	{
		Console.WriteLine("sudah menerima engine, ban, lampu");
		mesin = engine;
		ban = tire;
		this.lamp = lamp;
	}
	public void EngineCheck()
	{
		Console.WriteLine($"jenis mesin: {mesin.engineType}");
	}
	public void TireCheck() 
	{
		Console.WriteLine($"jenis ban: {ban.tireMaterial}");
	}
	public void LampCheck(){
		Console.WriteLine($"jenis lampu: {lamp.lampIngredients}");
	}
}
