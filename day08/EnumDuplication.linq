<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	//Enum -> int
	int numberOfDay = (int)Days.Saturday;
	numberOfDay.Dump();
	
	//int -> enum (undertemine)
	Days day = (Days)15;
	day.Dump();
}

public enum Days
{
	Monday = 1,
	Tuesday = 7,
	Wednesday,
	Thursday,
	Friday = 11,
	Saturday =12,
	Sunday = 13
}