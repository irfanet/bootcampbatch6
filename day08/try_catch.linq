<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Exception (try - catch)
void Main()
{
	"Start".Dump();
	int x = 0;
	try {
		Caller(ref x);
	}
	catch(Exception e) {
		throw new EvaluateException();
	}
	finally {
		"release resource".Dump();
	}
	x.Dump();
	"Finish all task".Dump();
}

void Caller(ref int x)
{
	"Caller called".Dump();
	int a = int.Parse(Console.ReadLine());
	int b = int.Parse(Console.ReadLine());
	x = a/b;
	"Caller finish".Dump();
}