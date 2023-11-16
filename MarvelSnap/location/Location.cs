using MarvelSnap.card;
using MarvelSnap.player;

namespace MarvelSnap.location;

public class Location
{
	private int _id;
	private string _name;
	private LocationType _type;
	private string _effect;
	private int _turn;
	private List<Card> _listCards = new();
	private Dictionary<Player, List<Card>> _listCardsOnLocation = new();
	
	public Location(int id, string name, string effect, int turn)
	{
		_id = id;
		_name = name;
		_effect = effect;
		_turn = turn;
	}

	public void AddCardsToLocation(Player players, Card cards){
		if(_listCardsOnLocation==null)
		{
			// _listCardsOnLocation.Add(players)			
		}
		_listCardsOnLocation[players].Add(cards);
	}

	public Dictionary<Player, List<Card>> GetCardsOnLocation(){
		return _listCardsOnLocation;
	}

	public string GetName(){
		return _name;
	}

	public string GetEffect(){
		return _effect;
	}

	public int GetId(){
		return _id;
	}
	
}
