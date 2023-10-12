<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Interface
void Main() {
	Human human = new Human();
	human.Kerja();
	human.Kuliah();
	human.Nikah();
	human.SudahNikah(1).Dump();
	human.MainGame();
	
	IPermintaanOrtu permintaan = human;
	permintaan.Kerja();
	permintaan.Kuliah();
	permintaan.Nikah();
	permintaan.SudahNikah(1).Dump();
	//permintaan.MainGame(); Error
}

public interface IPermintaanOrtu{
	void Kuliah();
	void Kerja();
	void Nikah();
	bool SudahNikah(int istri);
}
class Human : IPermintaanOrtu
{
	public void Kerja()
	{
		"Kerja di Formulatrix".Dump();
	}

	public void Kuliah()
	{
		"Kuliah BSI aja".Dump();
	}

	public void Nikah()
	{
		"Nikah ok".Dump();
	}

	public bool SudahNikah(int istri)
	{
		if (istri > 0)
		{
			return true;
		}
		return false;
	}
	public void MainGame() {
		"Game".Dump();
	}
}