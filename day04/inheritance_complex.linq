<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Inheritance OK and Overriding and Method Hiding
void Main() {
	Engine general = new DieselEngine();
	//Engine e = new Engine();
	//DieselEngine diesel = new DieselEngine();
	//e = diesel;

	DieselEngine diesel = new();
	ElectricEngine electric = new();
	
	Car car = new Car(diesel);
	car.EngineStart();
}
class Car
{
	private Engine _engine;
	public Car(Engine e)
	{
		_engine = e;
	}
	public void EngineStart()
	{
		_engine.Run();
		_engine.WarmUp();
	}
}
class Engine {
	public virtual void Run() {
		"Engine Run".Dump();
	}
	public void WarmUp() {
	}
}
class DieselEngine : Engine
{
	public override void Run()
	{
		"Diesel Engine Run".Dump();
	}
	public void WarmUp() {
		"Diesel Engine Warm Up".Dump();
	}
}
class ElectricEngine : Engine
{
	public void Run()
	{
		"Electric Engine Run".Dump();
	}
}