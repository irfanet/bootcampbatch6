<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//IEnumerable GetEnumerator
void Main()
{
	List<int> myInt = new List<int> {1,2,3};
	var enumerable = myInt.GetEnumerator();
	
	enumerable.MoveNext();
	enumerable.MoveNext();
	enumerable.MoveNext();
	int result = enumerable.Current;
	result.Dump();
	
	foreach(var x in myInt) {
		x.Dump();
	}
}

