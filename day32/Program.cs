using day32.composite;

class Program
{
	static void Main(){
		Leaf hp = new("siaomi",3);
		Leaf charger = new("45W",3);
		Leaf hedset = new("air",2);
		Leaf palu = new("palu thor",10);
		Leaf misiProduk = new("lipstik",10);
		
		Leaf kartuSpiderman = new("spiderman", 6);
		Composite location1 = new("loc 1");
		Composite location2 = new("loc 2");
		Composite location3 = new("loc 3");
		

		
		Composite kardus1 = new("JNE");
		Composite kardus2 = new("JNT");
		kardus2.Add(hedset);
		kardus2.Add(palu);
		Composite kardusBesar = new("FEDEX");
				kardusBesar.Add(kardus1);
		kardusBesar.Remove(kardus1);
		kardusBesar.Add(kardus2);
		kardusBesar.Add(misiProduk);
		kardus1.Add(hp);
		kardus1.Add(charger);
		hp.GetPrice().Dump();
		charger.GetPrice().Dump();
		kardusBesar.GetPrice().Dump();
		kardusBesar.DisplayTree();

	}
		
}

static class MyExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}
}