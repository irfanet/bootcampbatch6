<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//null
void Main()
{
	Car car = new Car();
	car.x.Dump();
	//car.engine.Test();
	car.y.Length.Dump();
}

class Car {
	public Engine engine;
	public string? y;
	public int x;
}
class Engine
{
	public void Test() {
		"test".Dump();
	}
}
// You can define other methods, fields, classes and namespaces here