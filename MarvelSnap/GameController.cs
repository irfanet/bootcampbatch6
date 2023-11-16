namespace MarvelSnap;

using System.ComponentModel;
using MarvelSnap.card;
using MarvelSnap.location;
using MarvelSnap.player;

public delegate void TurnNotification();
public delegate void ScoreNotification();
public class GameController
{
	private Dictionary<Player, PlayerData> _playersData = new();

	private Dictionary<Player, Card> _listCardsOnLocation = new();
	private Dictionary<Player, List<Card>> _listCardsOnDeck = new();
	
	private List<Location> _locations = new();





	public void AddPlayer(Player players){

	}

	
	public void AddCardsToDeck(Player players, PlayerData playerData){
		_playersData.Add(players, playerData);
	}

	public Dictionary<Player, PlayerData> GetPlayerData(){
		return _playersData;
	}

	// public void AddCardsToLocation(Players players, PlayerData playerData, Location location){
	// 	location.GetId
	// }

	public void AddCardToDeck(Player players, int currentTurn){

		List<Card> listCard = new();
		if(currentTurn != 1){	
			_listCardsOnDeck[players].Add(DrawCards(players,currentTurn));
		}
		// _listCardsOnDeck.Add(players, listCard.Add(DrawCards(players,currentTurn)));

	}

	public Dictionary<Player, List<Card>> GetCardsFromDeck(){
		return _listCardsOnDeck;
	}

	public Card DrawCards(Player players, int currentTurn){
		Random random = new Random();
		PlayerData? result;
		_playersData.TryGetValue(players, out result);

		// foreach(var element in result.GetPlayerCards()){
			int randomIndex = random.Next(result.GetPlayerCards().Count);
			return result.GetPlayerCards()[randomIndex];

		// }
	}

	public void CardsOnDeck(Dictionary<Player, PlayerData> playerData, Card cards){
		// if(playerData.Contains(cards)){
			
		// }
	}

	public void CalculatePower(Location location){
		// Location

	}

	public void TurnManager(Player players){
		// _playersData[players] = 
	}

	public Dictionary<Player, PlayerData> GetPlayersData(){
		return _playersData;
	}
	
	public void Surrender(Player players)
	{
		_playersData[players].SetStatus(PlayerStatus.Lose);
		string result = _playersData[players].GetStatus().ToString();
		Console.WriteLine($"{players.GetName()} {result}");
	}



	
		
}
