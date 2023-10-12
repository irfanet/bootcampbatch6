<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Interface = Interface + Interface
void Main()
{
	HumanSudahMenikah2 human = new();
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
public interface ISudahMenikah : IPermintaanOrtu, IPermintaanAnak, IPermintaanIstri, IPermintaanRT {
	
}
class Bapak { }
class HumanSudahMenikah : Bapak,ISudahMenikah
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
class HumanSudahMenikah2 : ISudahMenikah
{
	public void Kerja()
	{
		"Kerja di DragonShip".Dump();
	}

	public void Kuliah()
	{
		"Kuliah UGM aja".Dump();
	}

	public void Nikah()
	{
		"Nikah belum".Dump();
	}

	public bool SudahNikah(int istri)
	{
		if (istri > 1)
		{
			return true;
		}
		return false;
	}
	public void MainGame()
	{
		"Tidak".Dump();
	}

	public void Jajan()
	{
		"Pecel".Dump();
	}

	public void IPhone()
	{
		"IPhone ok bapak beliin".Dump();
	}

	public void PulangCepat()
	{
		"PulangCepat tidak perlu".Dump();
	}

	public void BayarIuran()
	{
		"Bayar secukupnya".Dump();
	}
}