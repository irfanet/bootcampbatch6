<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Inheritance Fail
void Main() {
	DieselEngine diesel = new();
	ElectricEngine electric = new();
	
	Car car = new Car(diesel);
	//Car car = new Car(engine); -> Beda bahan
	car.EngineStart();
}
class Car {
	private DieselEngine _engine;
	public Car(DieselEngine e) {
		_engine = e;
	}
	public void EngineStart() {
		_engine.Run();
	}
}
class DieselEngine {
	public void Run() {
		"Diesel Engine Run".Dump();
	}
}
class ElectricEngine
{
	public void Run()
	{
		"Electric Engine Run".Dump();
	}
}