class MyClass {
    public int MyProperty { get; set; }
    public string MyString { get; set; }
}

class Program {
    static void Main() {
        
        MyClass myObject = new MyClass();
        myObject.MyProperty = 42;
        myObject.MyString = "Hello world!";
        
        long sizeBefore = GC.GetTotalMemory(true);
        Console.WriteLine($"Before: GC.GetTotalMemory = {sizeBefore} bytes");
        
        long sizeAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"After: GC.GetTotalMemory = {sizeAfter} bytes");
        
        long size = sizeAfter - sizeBefore;
        
        Console.WriteLine($"Size of MyClass object: {size} bytes");
    }
}
