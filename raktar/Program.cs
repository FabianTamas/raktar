using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktar
{
    class Program
    {
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
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            BeolvasRaktar();

            Console.ReadKey();
        }
    }
}
