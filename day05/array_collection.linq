<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Array with Abstraction
void Main()
{
	ITransport[] transportation = new ITransport[5];
	transportation[0] = new Truck();
	transportation[1] = new Plane();
	transportation[2] = new Car();
	//transportation[3] = new Sayur();
}
public interface ITransport { }
class Car : ITransport { }
class Truck : ITransport { }
class Plane : ITransport { }
class Sayur { }