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
	private Dictionary<Player, List<Card>> _cardsOnLocation = new();
	private Dictionary<Player, int> _scores = new();
	
	public Location(int id, string name, string effect, int turn)
	{
		_id = id;
		_name = name;
		_effect = effect;
		_turn = turn;
	}

	public void AddCardsToLocation(Player player, Card card){
		Console.WriteLine($"location: {_name} - {player.GetName()} {card.GetName()}");
		if(_cardsOnLocation.ContainsKey(player)){
			_cardsOnLocation[player].Add(card);
			_scores[player] += card.GetPower();
		}
		else{
			_cardsOnLocation.Add(player, new List<Card> {card});
			_scores.Add(player, card.GetPower());
		}
	}

	public Dictionary<Player, List<Card>> GetCardsOnLocation(){
		return _cardsOnLocation;
	}

	public int CalculateScore(Player player)
	{
		if(!_cardsOnLocation.ContainsKey(player))
		{
			return 0;
		}

		return _scores[player];
		//
		// int totalScore = 0;
		//
		// foreach (var x in _cardsOnLocation.Values)
		// {
		// 	foreach (var temp in x)
		// 	{
		// 		Console.WriteLine(temp.GetName());
		// 		Console.WriteLine(temp.GetPower());
		// 		totalScore += temp.GetPower();
		// 	}
		// }
		//
		// return totalScore;
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
