class MyClass {
  byte[] data = new byte[10000000]; // allocate 10 MB of memory
}

class Program {
  static void Main() {
    List<MyClass> myObjects = new List<MyClass>();

    // create and add 100,000 objects to the list
    for (int i = 0; i < 100000; i++) {
      myObjects.Add(new MyClass());
    }

    // let the garbage collector clean up
    GC.Collect();

    // wait for the garbage collector to finish
    while (GC.WaitForFullGCComplete() == GCNotificationStatus.Succeeded) {
      // do nothing
    }

    Console.WriteLine("Objects have been cleaned up!");
    Console.ReadLine();
  }
}
 