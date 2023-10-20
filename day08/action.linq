<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Action
void Main()
{
	Action<string> act = null;
	act?.Invoke("hello"); //without ? will be exception
	
}

void Printer(string message)
{
	message.Dump();
}
void Update(string update)
{
	update.Dump();
}