<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Reference
void Main()
{
	string x = "3";
	Car car1 = new Car(3);
	Car car2 = car1;
	car2.value = 5;
	Car car3 = new Car(5);
	car3 = car1;
	
	car1.value.Dump();
	car2.value.Dump();
}

class Car {
	public int value;
	public Car(int x) {
		value = x;
	}
}
