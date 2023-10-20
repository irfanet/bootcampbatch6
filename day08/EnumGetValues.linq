<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	//Enum -> int
	int numberOfDay = (int)StatusCode.NotFound;
	numberOfDay.Dump();

	//int -> enum (undertemine)
	StatusCode day = (StatusCode)404;
	day.Dump();
	
	StatusCode[] status = (StatusCode[])Enum.GetValues(typeof(StatusCode));
	var status2 = Enum.GetValues(typeof(StatusCode));
	status.Dump();
	StatusCode[] newstatus = {StatusCode.OK, StatusCode.Forbidden, StatusCode.NotFound};
	int x = status.Length;
}

public enum StatusCode
{
	NotFound = 404,
	Forbidden = 403,
	OK = 200
}