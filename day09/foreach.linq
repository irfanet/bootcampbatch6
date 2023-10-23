<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Foreach
void Main()
{
	int[] myArray = {1,2,3,4,5};
	foreach(int i in myArray) {
		i.Dump();
	}
	
	List<string> myList = new List<string>() {"a","b","c"};
	foreach(string str in myList) {
		str.Dump();
	}
	
	List<Car> myCar = new List<Car>() {
		new Car("Hello"),
		new Car("TEST"),
		new Car("toyota")
	};
	foreach(Car car in myCar) {
		car.brand.Dump();
	}
}

class Car { 
	public string brand;
	public Car(string brand) 
	{
		this.brand = brand;
	}
}
