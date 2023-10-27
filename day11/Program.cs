class Program
{
	static void Main()
	{
		
		"stack".Dump();
		Stack<int> myStack = new();
		myStack.Push(3);
		myStack.Push(7);
		myStack.Push(9);
		myStack.Push(10);
		myStack.Push(7);
		myStack.Push(4);
		
		myStack.Peek().Dump();
		myStack.Pop().Dump();
		myStack.Pop().Dump();
		
		foreach(var e in myStack)
		{
			e.Dump();
		}
		
		"Queue".Dump();
		Queue<int> myQ = new();
		myQ.Enqueue(1);
		myQ.Enqueue(2);
		myQ.Enqueue(3);
		myQ.Enqueue(8);
		
		myQ.Peek();
		
		myQ.Dequeue();
		foreach(var e in myQ)
		{
			e.Dump();
		}
	}
}

static class MyExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}
}