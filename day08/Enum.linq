<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//HTTPRequest enum
public enum HTTPRequest {
	NotFound = 404,
	OK = 200,
	Forbidden = 403
}

void Main()
{
	WebAccess.ContinueAccess(HTTPRequest.Forbidden);
}

class WebAccess {
	public static void ContinueAccess(HTTPRequest status) {
		if (status == HTTPRequest.NotFound) {
			((int)status).Dump();
		}
		else if (status == HTTPRequest.OK) {
			((int)status).Dump();
		}
		else
		{
			((int)status).Dump();
		}
	}
}