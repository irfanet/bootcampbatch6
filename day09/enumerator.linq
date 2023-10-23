<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Enumerator

void Main() {
	
	
}

class MyCollection : IEnumerator
{
	public int currentIndex = -1;
	public int[] myInt = new int[5];
	
	public object Current => myInt[currentIndex];

	public bool MoveNext()
	{
		if(currentIndex+1 < myInt.Length) {
			currentIndex++;
			return true;
			}
		else {
			Reset();
			return false;
		}
	}

	public void Reset()
    {
        currentIndex = -1;
    }
}
