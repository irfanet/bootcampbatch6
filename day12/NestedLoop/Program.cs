class Program {
  static void Main() {
    int[] array1 = new int[10000];
    int[] array2 = new int[100000];

    // option 1: nested loops (creates more garbage, more collections)
    for (int i = 0; i < array1.Length; i++) {
      for (int j = 0; j < 10; j++) {
        array1[i] += j;
      }
    }
    for (int i = 0; i < array2.Length; i++) {
      for (int j = 0; j < 10; j++) {
        array2[i] += j;
      }
    }

    Console.ReadLine();
  }
}
