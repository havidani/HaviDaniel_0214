using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0214
{
	internal class Karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public Karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public void Legnagyobbeletero(List<Karakter> karakterek)
		{
			int nagyeletero = eletero;
			foreach (var item in karakterek)
			{
				
				if (eletero > nagyeletero)
				{
					nagyeletero = eletero;

				}
			}
		}

		public override string? ToString()
		{
			return $"{nev} - {szint} / {eletero} / {ero} /";
		}
	}
}
