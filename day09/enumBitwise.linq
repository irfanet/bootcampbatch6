<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Enum (Bitwise Operator)
void Main() {
	Status result = Status.NotFound & Status.OK;
	result.Dump();
}

public enum Status{
	NotFound = 5,
	OK = 3,
	Forbidden = 2
}