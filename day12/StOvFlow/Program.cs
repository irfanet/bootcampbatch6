struct MyStruct {
  int value;
}

class Program {
  static void Main() {
    MyMethod(new MyStruct());
  }

  static void MyMethod(MyStruct myStruct) {
    MyMethod(myStruct);
  }
}
