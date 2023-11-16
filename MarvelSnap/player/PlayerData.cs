using MarvelSnap.card;

namespace MarvelSnap.player;

public class PlayerData
{
	private List<Card> _listCard;
	private int _score;
	private int _energy;
	private PlayerStatus _status;

	public PlayerData(List<Card> cards, PlayerStatus status)
	{
		_listCard = cards;
		_score = 0;
		_energy = 1;
		_status = status;
	}

	public List<Card> GetPlayerCards(){
		return _listCard;
	}

	public void SetStatus(PlayerStatus status){
		_status = status;
	}

	public PlayerStatus GetStatus(){
		return _status;
	}
	
	public void SetEnergy(int energy){
		_energy = energy;
	}

	public int GetEnergy(){
		return _energy;
	}

	public void SetScore(int score){
		_score = score;
	}

	public int GetScore(){
		return _score;
	}

	public Card GetCard(int id){
		return _listCard.Find(x => x.GetId() == id);
	}
}
