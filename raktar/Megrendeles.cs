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

		private string targyak;

		public string Targyak
		{
			get { return targyak; }
			set { targyak = value; }
		}

		public Megrendeles(string datum, string rendelesszam, string email)
		{
			this.datum = datum;
			this.rendelesszam = rendelesszam;
			this.email = email;
		}
	}
}
