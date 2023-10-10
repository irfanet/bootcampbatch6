using System.Runtime.Intrinsics.Arm;
using CarComponent;
using Transportation;

class Program 
{
	static void Main() 
	{
		Engine diesel = new Engine("diesel","rollsroyce");
		Tire hancock = new Tire();
		Lamp osram = new Lamp();
		
		Car car = new Car(diesel, hancock, osram);
	}
}