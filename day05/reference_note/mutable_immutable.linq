<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//String(immutable) vs StringBuilder(mutable)
using System.Diagnostics;
void Main()
{
	Stopwatch stopwatch = new Stopwatch();
	//String
	string a = String.Empty;
	stopwatch.Start();
	for (int i = 0; i < 2000; i++)
	{
		a += ("Hello");
		a += ("World");
		a += ("!");
	}
	stopwatch.Stop();
	$"String : {stopwatch.ElapsedMilliseconds} ms".Dump();

	//StringBuilder
	StringBuilder sb = new StringBuilder();
	stopwatch.Restart();
	for(int i = 0; i < 2000; i++) 
	{
		sb.Append("Hello");
		sb.Append("World");
		sb.Append("!");
	}
	stopwatch.Stop();
	$"StringBuilder : {stopwatch.ElapsedMilliseconds} ms".Dump();
}
