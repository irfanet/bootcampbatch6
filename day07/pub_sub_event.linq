<Query Kind="Program" />

//Pub-Sub with Event
//Youtube
public delegate void MyDelegate(string uploader);
class Program
{
	static void Main()
	{
		Youtuber yt = new("Yanto");
		Subscriber sub1 = new Subscriber();
		Subscriber2 sub2 = new Subscriber2();

		yt.subscriber += sub1.Notification;
		yt.subscriber += sub2.Notification;
		yt.UploadVideo();
		yt.EventClear();
	}
}
class Youtuber
{
	public event MyDelegate subscriber;
	
	private string _name;
	public Youtuber(string name)
	{
		_name = name;
	}
	public void UploadVideo()
	{
		"Uploading video...".Dump();
		if (subscriber != null)
		{
			subscriber.Invoke(_name);
		}
	}
	public void EventClear() {
		subscriber = null;
	}
}
class Subscriber
{
	public void Notification(string x)
	{
		$"Get notif from Youtuber {x}".Dump();
	}
}
class Subscriber2
{
	public void Notification(string x)
	{
		$"Get notif from Youtuber {x}".Dump();
	}
}