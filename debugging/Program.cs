using NLog;

class Program
{
    public static void Main()
    {
        Leaf xiaomi = new("siomay", 100);
        Leaf samsung = new("a52s", 200);
        Composite jne = new("JNE", 10);
        Composite jnt = new("JNT", 20);
        
        jne.Add(xiaomi);
        jne.Add(samsung);
        jnt.Add(xiaomi);
        jnt.Add(samsung);
        samsung.GetPrice().Dump();
        jne.GetPrice().Dump();
        jne.DisplayTree();
    }
}


static class MyExtension
{
    public static void Dump(this object obj)
    {
        Console.WriteLine(obj);
    }
}