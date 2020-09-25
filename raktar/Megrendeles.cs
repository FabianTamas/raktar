using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
    class Megrendeles
    {
        private string datum;

		public string Datum
		{
			get { return datum; }
			set { datum = value; }
		}

		private string rendelesszam;

		public string Rendelesszam
		{
			get { return rendelesszam; }
			set { rendelesszam = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private List<Tetel> tetelek;

		private int osszeg;

		public int Osszeg
		{
			get { return osszeg; }
			set { osszeg = value; }
		}


		public void TetelHozzaad(string kod, int db)
		{
			tetelek.Add(new Tetel(kod, db));
		}

		private int Ara(string kod, List<Termek> termekek)
		{
			int i = 0;
			while (termekek[i].Kod != kod)
			{
				i++;
			}
			return termekek[i].Ar;
		}

		public void Szamolas(List<Termek> termekek)
		{
			// kód alapján megkeresni a terméket -> ár			
			// szum += ár * darab (ahány termék van)

			int szum = 0;

			for (int i = 0; i < tetelek.Count; i++)
			{
				int ar = Ara(tetelek[i].Kod, termekek);
				szum += ar * tetelek[i].Db;
			}

			this.Osszeg = szum;
		}

		public Megrendeles(string datum, string rendelesszam, string email)
		{
			this.datum = datum;
			this.rendelesszam = rendelesszam;
			this.email = email;
			tetelek = new List<Tetel>();
		}
	}
}
