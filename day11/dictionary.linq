<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Dictionary
void Main()
{
	Dictionary<int,string> myDict = new();
	myDict.Add(3,"foo");
	myDict.Add(5,"bar");
	//myDict.Add(3,"fizz"); Key must be unique
	myDict.Add(7,"foo"); //Value bebas
	foreach(KeyValuePair<int,string> e in myDict) {
		$"{e.Key} {e.Value}".Dump();
	}
	string myValue = myDict[3];
	myValue.Dump();
	
	string valueForSearch = "foo";
	int keyResult = 0;
	foreach(var e in myDict) {
		if(e.Value == valueForSearch) {
			keyResult = e.Key;
			break;
		}
	}
	keyResult.Dump();
	//Contains -> KeyValuePair
	//ContainsKey() -> value key
	//ContainsValue() -> value of value
	KeyValuePair<int,string> keysvalue = new(3,"foo");
	bool checkKey = myDict.Contains(keysvalue);
	checkKey.Dump();

	myDict[3] = "buzz"; //Change Value
	
	int keyAdd = 3;
	string valueAdd = "yanto";
	myDict.TryAdd(1, "yanto"); //TryAdd 
	foreach (KeyValuePair<int, string> e in myDict)
	{
		$"{e.Key} {e.Value}".Dump();
	}
}