<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//EventHandler
void Main() {
	Youtuber pub = new Youtuber("Jokoyanto");
	Subscriber sub = new Subscriber();
	pub.eventHandler = sub.Notification;
	pub.SendNotification();
}
class Youtuber
{
	private string _name;
	public EventHandler eventHandler;
	public Youtuber(string name) { _name = name; }
	public void SendNotification()
	{
		eventHandler?.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return _name;
	}
}
class Publisher {
	private string _name;
	public EventHandler eventHandler;
	public Publisher(string name) {_name = name;}
	public void SendNotification() 
	{
		eventHandler?.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return _name;
	}
}
class Subscriber {
	public void Notification(object sender, EventArgs e) {
		$"Called by {sender}".Dump();
	}
}