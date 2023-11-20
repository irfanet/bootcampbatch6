using MarvelSnap.card;

namespace MarvelSnap.player;

public class PlayerData
{
	private List<Card> _cardsOnDeck;
	private List<Card> _cardsOnHand = new();
	private int _score;
	private int _energy;
	private PlayerStatus _status;

	private Random _rng;

	public PlayerData(List<Card> cards, PlayerStatus status)
	{
		_cardsOnDeck = cards;
		_score = 0;
		_energy = 1;
		_status = status;
	}

	public List<Card> GetPlayerCards()
	{
		return _cardsOnDeck;
	}

	public void SetStatus(PlayerStatus status)
	{
		_status = status;
	}

	public PlayerStatus GetStatus()
	{
		return _status;
	}

	public void SetEnergy(int energy)
	{
		_energy = energy;
	}

	public int GetEnergy()
	{
		return _energy;
	}

	public void SetScore(int score)
	{
		_score = score;
	}

	public int GetScore()
	{
		return _score;
	}

	public Card GetCard(int id)
	{
		return _cardsOnDeck.Find(x => x.GetId() == id);
	}


	public IEnumerable<Card> SetCardsOnHand(bool isFirstTurn)
	{
		if (_cardsOnHand.Count() >= 6)
		{
			return _cardsOnHand;
		}
		if (isFirstTurn)
		{
			foreach (var cards in _cardsOnDeck.Take(4))
			{
				cards.MarkOnHand();
				_cardsOnHand.Add(cards);
			}
			return _cardsOnHand;
		}
		foreach (var card in _cardsOnDeck.Where(card => card.IsOnHand() == false && card.IsOnLocation() == false).Take(1))
		{
			card.MarkOnHand();
			_cardsOnHand.Add(card);
		}
		return _cardsOnHand;
	}

}
