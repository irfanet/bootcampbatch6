<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Collection implementation
void Main()
{
	Dictionary<Player, Data> dictPlayers = new();
	Player player1 = new Player();
	dictPlayers.Add(player1, new Data(Colour.Black,0,100));
	
	Data result = dictPlayers[player1]; //Return Data dari DictPlayers
	foreach(Card c in result.GetCards()) {
		//...
	}
	Colour colourPlayer = result.GetColour();
	colourPlayer.Dump();
}
class Data
{
	private List<Card> _playerCards;
	private Colour _playerColour;
	private int _playerScore;
	private int _playerBet;
	
	public Data(Colour colour, int initialScore, int bet) {
		_playerCards = new();
		_playerColour = colour;
		_playerScore = initialScore;
		_playerBet = bet;
	}
	public bool AddCards(Card card){
		_playerCards.Add(card);
		return true;
	}
	public List<Card> GetCards()
	{
		return _playerCards;
	}
	public Colour GetColour() {
		return _playerColour;
	}
}
public enum Colour
{
	White,
	Black
}
class Player { 
	
}
class Card { 
	
}