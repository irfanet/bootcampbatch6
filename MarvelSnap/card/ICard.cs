namespace MarvelSnap.card;

public interface ICard
{
	int GetId();
	string GetImage();
	string GetName();
	CardType GetType();
	int GetPower();
	int GetEnergyCost();
	string GetDescription();
	void Skill();
	
	bool IsOnLocation();
}
