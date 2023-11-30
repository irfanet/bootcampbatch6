namespace MarvelSnap.card;

public interface ICard
{
	HashSet<int> GetId();
	string GetName();
	CardType GetType();
	int GetPower();
	int GetEnergyCost();
	string GetDescription();
	void Skill();
	
}
