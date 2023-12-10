using System.IO;

class Program {
	static void Main() {
		string path = @"C:\Users\Kinara\Documents\Bootcamp\";

		Directory.CreateDirectory(path);

		if (Directory.Exists(path)) {
			Console.WriteLine("Directory exists.");
		}

		// Create a file in the directory
		string filePath = Path.Combine(path, "bootcamp.txt");
		File.WriteAllText(filePath, "Hello, world!");

		string[] files = Directory.GetFiles(path);
		foreach (string file in files) {
			Console.WriteLine(file);
		}

		Directory.Delete(path, true);
	}
}
