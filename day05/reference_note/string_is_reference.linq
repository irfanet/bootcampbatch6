<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//String is Reference, but?
void Main()
{
	string a = "3";
	string b = a;
	b = "5";
	
	a.Dump();
	b.Dump();
	
	string myString = "hello";
	myString = "World";
	myString += "!";
	//myString = myString + "!";
	
}

