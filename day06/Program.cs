class Program
{
	static void Main()
	{
		int myRef = 3;
		PowerRef(ref myRef);
		Console.WriteLine(myRef);
		
		int myOut;
		PowerOut(out myOut);
		Console.WriteLine(myOut);
		
		int myIn = 7;
		int InResult = 0;
		PowerIn(in myIn, ref InResult);
		Console.WriteLine(myIn);
		Console.WriteLine(InResult);
			
	}
		
	static void PowerRef(ref int myRef)
	{
		myRef = myRef*myRef;
	}
	
	static void PowerOut(out int myOut){
		myOut = 10;
		myOut = myOut*myOut;
	}
	
	static void PowerIn(in int myIn, ref int result)
	{
		// Readonly
		// myIn = myIn*myIn;
		result = myIn*myIn;
	}
}

