<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Value
void Main()
{
	int a = 3;
	int b = a;
	b = 5;
	
	a.Dump(); // 3
	b.Dump(); // 5
}

// You can define other methods, fields, classes and namespaces here