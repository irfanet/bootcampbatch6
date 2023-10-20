<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Anonymous Delegate (Lambda Expression)
void Main()
{
	// (parameter) => (return);
	var method = (int x, int y) =>
	{
		return x + y;
	};
	
	var printer = (object x) => x.Dump();
	var nggangapa2in = () => "diam".Dump();
	
	printer(30);
	int result = method(3,4);
	result.Dump();
}

int Add(int x, int y) {
	return x + y;
}

int Add2 (int x, int y) => x+y;