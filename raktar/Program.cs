using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();
        static List<Megrendeles> megrendelesek = new List<Megrendeles>();

        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                /*
                 * sor[0] -> Kód
                 * sor[1] -> Név
                 * sor[2] -> Ár
                 * sor[3] -> Darabszám
                 */
                string[] sor = raktar.ReadLine().Split(';');

                //Termek t = new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3]));
                //termekek.Add(t);

                termekek.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }
            raktar.Close();
        }

        static void BeolvasRendeles()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");
            while (!rendeles.EndOfStream)
            {
                string sor = rendeles.ReadLine();
                string[] adat = sor.Split(';');

                if (adat[0]=="M")
                {
                    megrendelesek.Add(new Megrendeles(adat[1], adat[2], adat[3]));
                }
                else
                {
                    //megrendelesek[megrendelesek.Count - 1].termekek.Add(sor);
                    megrendelesek[megrendelesek.Count - 1].TetelHozzaad(adat[2], int.Parse(adat[3]));
                }
            }
            rendeles.Close();
        }

        static void Main(string[] args)
        {
            BeolvasRaktar();
            BeolvasRendeles();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            foreach (var t in megrendelesek)
            {
                Console.WriteLine(t.Email);
            }

            Console.ReadKey();
        }
    }
}
