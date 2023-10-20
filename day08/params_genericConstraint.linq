<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Params + Generic Constraint
using System.Numerics;
void Main() {
	int result = Add(3,4);
	int result2 = Add(3,4,5,7,8,8,9,9,9,9,9,9,1);
	result.Dump();
	result2.Dump();
	StringCombiner("hello","world").Dump();
}

T Add<T>(params T[] x) where T : INumber<T> 
{
	T result = default;
	for(int i = 0; i < x.Length; i++) {
		result += x[i];
	}
	return result;
}
string StringCombiner(params string[] strings) {
	string result = default;
	
	foreach(string s in strings) {
		result += " " + s;
	}
	return result;
}