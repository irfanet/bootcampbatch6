<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//EventHandler<string>
void Main() {
	Publisher pub = new Publisher("Jokoyanto");
	Subscriber sub = new Subscriber();
	pub.eventHandler += sub.Notification;
	pub.SendNotification();
}
class Publisher
{
	private string _name;
	public EventHandler<string> eventHandler;
	public Publisher(string name) { _name = name; }
	public void SendNotification()
	{
		eventHandler?.Invoke(this, "Jokoyanto");
	}
	public override string ToString()
	{
		return _name;
	}
}
class Subscriber
{
	public void Notification(object sender, string e)
	{
		$"Called by {e}".Dump();
	}
}