public class Car
{
    //public int age; 
    //variable
    public int Age { get; private set; } //property
    private int _balance;
    public int Balance
    {
        get
        {
            return _balance * 1000;
        }
        set
        {
            if (value > 0)
            {
                _balance = value;
            }
        }
    }

    private string _name;
    public Car(int age)
    {
        Age = age;
    }
}
