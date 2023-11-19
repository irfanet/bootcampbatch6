class Program
{
    static void Main()
    {
        Cat cat = new Cat("oyen", 4);
        Console.WriteLine(cat.name);
        Console.WriteLine(cat.GetAge("pass"));
        cat.SetAge(5);

        Console.WriteLine(cat.GetAge("pass"));

        Car car = new Car(9);
		Console.WriteLine(car.Age);
		//car.Age = 8 //Set Accessor is Private
		
		car.Balance = 10;
		int x = car.Balance;
		Console.WriteLine(x);
    }
}