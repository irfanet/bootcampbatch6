<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Constant is static global
void Main()
{
	MyMath math = new MyMath();
	//math.phi.Dump(); cant call static variable from instance
	
	MyMath.phi.Dump();
}
class MyMath {
	public const float phi = 3.14f; //Const is static
}