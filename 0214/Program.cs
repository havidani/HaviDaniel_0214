namespace _0214
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Karakter> karakterek = [];
			Beolvasas("karakterek.txt", karakterek);
			foreach (var item in karakterek)
			{
				Console.WriteLine(item);
			}
		}

		static void Beolvasas(string filenev, List<Karakter> karakterek)
		{
			StreamReader sr = new (filenev);

			string[] sorok = File.ReadAllLines(filenev);

			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] szavak = sor.Split(';');

				Karakter karakter = new (szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
				karakterek.Add(karakter);
			}
		}
		static void Legnagyobbeletero(List<Karakter> karakterek)
		{
			int nagyeletero = 0;
			foreach (var item in karakterek)
			{
				if (item.Eletero > nagyeletero)
				{
					nagyeletero = item.Eletero;
				}
			}
			Console.WriteLine($"Név: {nev}, Szint: {szint}, Erő: {ero}");
		}
	}
}
