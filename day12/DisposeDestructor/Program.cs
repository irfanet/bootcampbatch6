
using System;

class MyClass : IDisposable {
	private bool disposed = false;
	
	// Method untuk membebaskan sumber daya unmanaged
	private void CleanupUnmanagedResources() {
		Console.WriteLine("Cleaning up unmanaged resources...");
	}
	
	// Implementasi metode Dispose
	public void Dispose() {
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	protected virtual void Dispose(bool disposing) {
		if (disposed) {
			return;
		}
		
		if (disposing) {
			Console.WriteLine("Disposing managed resources...");
			// Memanggil metode Dispose bagi objek yang memiliki referensi ke objek saat ini
		}
		
		CleanupUnmanagedResources();
		
		disposed = true;
	}
	
	~MyClass() {
		Console.WriteLine("Finalizing object...");
		Dispose(false);
	}
}

class Program {
	static void Main() {
		// Menggunakan objek dengan using statement
		using (var obj1 = new MyClass()) {
			Console.WriteLine("Using object with 'using' statement...");
		}
		
		// Menggunakan objek tanpa using statement
		var obj2 = new MyClass();
		Console.WriteLine("Using object without 'using' statement...");
		obj2.Dispose();
		
		// Membuat objek dan menghapusnya secara eksplisit
		var obj3 = new MyClass();
		Console.WriteLine("Creating and disposing object explicitly...");
		obj3.Dispose();
		
		// Membuat objek tanpa memanggil dispose atau garbage collection
		var obj4 = new MyClass();
		Console.WriteLine("Creating object without disposing or finalizing it...");
		obj4 = null;

        Console.ReadLine();
    }
}
