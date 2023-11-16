namespace MarvelSnap.player;

public class Player : IPlayer
{
	private int _id;
	private string _name;
	public Player(int id, string name){
		_id = id;
		_name = name;
	}
	public int GetId()
	{
		return _id;
	}

	public string GetName()
	{
		return _name;
	}

}
