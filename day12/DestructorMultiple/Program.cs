class MyOtherClass
{
    ~MyOtherClass()
    {
        Console.WriteLine("MyOtherClass destructor called.");
    }
}

class MyClass
{
    MyOtherClass otherObj = new MyOtherClass();

    ~MyClass()
    {
        Console.WriteLine("MyClass destructor called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObj = new MyClass();
    }
}
 