<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//HashTable (dictionary, but not type safety)
void Main()
{
	Hashtable hashtable = new();
	hashtable.Add(3, 3.3f);
	hashtable.Add("5", "foo");
	hashtable.Add(true, false);
}

