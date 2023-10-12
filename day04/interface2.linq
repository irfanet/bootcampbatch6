<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Interface
void Main()
{
	HumanSudahMenikah human = new HumanSudahMenikah();
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
	
	IPermintaanAnak permintaanAnak = human;
	permintaanAnak.Jajan();
	
}

public interface IPermintaanOrtu
{
	void Kuliah();
	void Kerja();
	void Nikah();
	bool SudahNikah(int istri);
}
public interface IPermintaanRT
{
	void BayarIuran();
}
public interface IPermintaanIstri 
{
	void IPhone();
	void PulangCepat();
}
public interface IPermintaanAnak 
{
	void Jajan();	
}
class HumanSudahMenikah : IPermintaanOrtu, IPermintaanAnak, IPermintaanIstri, IPermintaanRT
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
	public void MainGame()
	{
		"Game".Dump();
	}

	public void Jajan()
	{
		"mcd".Dump();
	}

	public void IPhone()
	{
		"IPhone nanti dulu".Dump();
	}

	public void PulangCepat()
	{
		"PulangCepat ok".Dump();
	}

	public void BayarIuran()
	{
		"Bayar 100 Ribu".Dump();
	}
}