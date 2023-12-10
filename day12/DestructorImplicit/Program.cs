using System;
namespace DestructorExample
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("DestructorDemo Object Created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("DestructorDemo Object Destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            DestructorDemo obj1 = new DestructorDemo();
            
            //Making obj1 ready for Garbage Collection
            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some Statement Executed Inside Main Method");

            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some More Statement Executed Inside Main Method");

            GC.Collect();
            Console.WriteLine("Main Method Execution End");
            Console.ReadKey();
        }
    }
}