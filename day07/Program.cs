public delegate void Subscriber(string youtuber);
class Program
{
	static void Main()
	{	
		Youtuber yt = new("BangJeff");
		Pengikut1 sub1 = new();
		Pengikut2 sub2 = new();
		yt.subscriber += sub1.GetNotification;
		yt.subscriber += sub2.GetNotification;
		yt.UploadVideo();
	}
		
}

class Youtuber
{
	public event Subscriber? subscriber;
	private string _name;
	
	public Youtuber(string name)
	{
		_name = name;
	}
	
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video....");
		Console.WriteLine("Finished");;
		subscriber?.Invoke(_name);
	}
	
	public void EventClear()
	{
		subscriber = null;
	}
}

class Pengikut1
{
	public void GetNotification(string x){
		Console.WriteLine($"Pengikut1: Video baru dari {x}");
	}
}

class Pengikut2
{
	public void GetNotification(string x){
		Console.WriteLine($"Pengikut2: Video baru dari {x}");
	}
}



