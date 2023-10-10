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
		// Console.WriteLine(engine);
	}
	public void TireCheck() 
	{
		// Console.WriteLine(tire);
	}
}
