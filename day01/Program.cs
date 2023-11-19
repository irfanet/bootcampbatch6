class Program
{
    static void Main()
    {
        Cat oyen = new Cat();
        oyen.colour = "orange";
        oyen.leg = 4;
        oyen.weight = 10;
        oyen.height = 30;
        oyen.isTailLong = true;
        Console.WriteLine($"warna kucing: {oyen.colour}");
        Console.WriteLine($"kaki kucing: {oyen.leg} ");
        Console.WriteLine($"tinggi kucing: {oyen.height} cm");
        Console.WriteLine($"berat kucing: {oyen.weight} kg");
        Console.WriteLine($"ekor panjang: {oyen.isTailLong}");
        oyen.Jump();
        oyen.Run();

    }

}