using System.ComponentModel;

namespace day32.composite;

public interface IComponent
{
	int GetPrice();
	bool ISComposite();
	// void Add(IComponent component);
	// void Remove(IComponent component);
	string GetName();
}
