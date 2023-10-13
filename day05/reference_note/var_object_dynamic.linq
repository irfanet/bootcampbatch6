<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//var, object, dynamic
void Main() 
{
	//var = compiler help decide variable type
	var myInt = 3;	
	myInt = int.Parse("1");
	myInt.Dump();
	
	//object
	int myInt2 = 2;
	object x = myInt2;
	x.Dump();
	
	int myInt3 = 3;
	object obj = myInt3; //Boxing
	float result = (int)obj; //Unboxing
	
	Printer(3);
	Printer("a");
	Printer(true);
	Printer(3.0f);
	Printer(3.0M);
	
	Add(3,3);
	Add(new Car(), new Car());
	
	//dynamic (dont use it)
	dynamic myDynamic = 3;
	myDynamic = "3";
	myDynamic = true;
	myDynamic = new Car();
	myDynamic.CallIstriGuwe();
	myDynamic.Mboh();
	myDynamic.EngineRunButBurnKetoke();
}

void Printer(object x) {
	x.Dump();
}
void Add(object x, object y)
{
	if(x is int && y is int) {
		int a = (int)x;
		int b = (int)y;
		(a+b).Dump();
	}
	if(x is Car) {
		"Tidak masuk akal".Dump();
	}
}
class Car{}
