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
                Termek t = new Termek();
                t.Kod = sor[0];
                t.Nev = sor[1];
                t.Ar = int.Parse(sor[2]);
                t.Db = int.Parse(sor[3]);
                termekek.Add(t);
            }
            raktar.Close();

            for (int i = 0; i < termekek.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", termekek[i].Kod, termekek[i].Nev, termekek[i].Ar, termekek[i].Db);
            }
        }
        static void Main(string[] args)
        {
            BeolvasRaktar();

            Console.ReadKey();
        }
    }
}
