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
        return _cardsOnDeck[id];
    }


    public IEnumerable<Card> SetCardsOnHand(bool isFirstTurn)
    {
        if (_cardsOnHand.Count() >= 6)
        {
            return _cardsOnHand.Where(card => card.IsOnLocation() == false);
        }

        if (isFirstTurn)
        {
            var shuffle = ShuffleCards(_cardsOnDeck);
            foreach (var cards in shuffle.Take(4))
            {
                cards.MarkOnHand();
                _cardsOnHand.Add(cards);
            }

            return _cardsOnHand;
        }

        Card card = _cardsOnDeck.First(card => card.IsOnHand() == false);

        card.MarkOnHand();
        _cardsOnHand.Add(card);

        return _cardsOnHand;
    }

    private IEnumerable<Card> ShuffleCards(List<Card> cards)
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
        return _cardsOnHand.Where(card => card.IsOnHand() == false && card.IsOnLocation() == false);
    }

    public void RemoveCard(int index)
    {
        Console.WriteLine($"hapus {_cardsOnHand[index]}");
        _cardsOnHand.RemoveAt(index);
    }
}