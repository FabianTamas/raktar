using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
	class Termek
	{
		private string kod;

		public string Kod
		{
			get { return kod; }
			set { kod = value; }
		}

		private string nev;

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		private int ar;

		public int Ar
		{
			get { return ar; }
			set { ar = value; }
		}

		private int db;

		public int Db
		{
			get { return db; }
			set { db = value; }
		}

		public string Alakit(string szoveg)
		{
			string tmp = "";
			string ekezetes = "áéíúüűóöő";
			string mire = "aeiuuuooo";

			for (int i = 0; i < szoveg.Length; i++)
			{
				int hol = ekezetes.IndexOf(szoveg[i]);
				if (hol > -1)
				{
					tmp += mire[hol];
				}
				else
				{
					tmp += szoveg[i];
				}
			}
			return tmp;
		}

		public Termek(string kod, string nev, int ar, int db)
		{
			this.kod = kod;
			this.nev = Alakit(nev);
			this.ar = ar;
			this.db = db;
		}
	}
}
