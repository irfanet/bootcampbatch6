public class Cat
{
    public string name; //* //Forbidden 
    private int _catAge; //private variable _ //ownself

    public Cat(string name, int age) //Constructor
    {
        this.name = name;
        _catAge = age;
    }

    public int GetAge(string password)
    {
        if (password == "pass")
        {
            return _catAge;
        }
        else
        {
            return 0;
        }
    }
    public void SetAge(int age)
    {
        if (age > 0)
        {
            _catAge = age;
        }
    }

    public void Jump()
    {
        Console.WriteLine("Jump");
    }
    protected void Eat() //child
    {
        Console.WriteLine("Eat");
    }
}
