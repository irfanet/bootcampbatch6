using MarvelSnap.card;

namespace MarvelSnap.player;

public class PlayerData
{
    private List<Card> _cardsOnDeck;
    private List<Card> _cardsOnHand = new();
    private int _score;
    private int _energy;
    private PlayerStatus _status;

    private Random _rng = new();

    public PlayerData(List<Card> cards, PlayerStatus status)
    {
        _cardsOnDeck = ShuffleCards(cards);
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
        return _cardsOnHand[id];
    }


    public IEnumerable<Card> SetCardsOnHand(bool isFirstTurn)
    {
        if (_cardsOnHand.Count() >= 6)
        {
            return _cardsOnHand;
        }

        if (isFirstTurn)
        {
            foreach (var card in _cardsOnDeck.Take(4))
            {
                _cardsOnDeck.Remove(card);
                _cardsOnHand.Add(card);
            }

            return _cardsOnHand;
        }

        Card oneCard = _cardsOnDeck.FirstOrDefault();
        _cardsOnDeck.Remove(oneCard);
        _cardsOnHand.Add(oneCard);

        return _cardsOnHand;
    }

    private List<Card> ShuffleCards(List<Card> cards)
    {
        Random random = new Random();
        int n = cards.Count;

        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (cards[i], cards[j]) = (cards[j], cards[i]);
        }

        return cards;
    }

    public IEnumerable<Card> GetCardsOnHand()
    {
        return _cardsOnHand;
    }

    public void RemoveCardFromHand(int index)
    {
        _cardsOnHand.RemoveAt(index);
    }

    public void RemoveCardFromDeck(Card card)
    {
        _cardsOnDeck.Remove(card);
    }

    public void PrintCards()
    {
        foreach (var p in _cardsOnHand)
        {
            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPower());
        }
    }
}