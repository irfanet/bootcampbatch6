class Program {
  static void Main() {
    int[] array1 = new int[10000];
    int[] array2 = new int[100000];

    // option 2: single loop (creates less garbage, fewer collections)
    for (int i = 0; i < array1.Length; i++) {
      array1[i] = i;
    }
    for (int i = 0; i < array2.Length; i++) {
      array2[i] = i;
    }

    Console.ReadLine();
  }
}
