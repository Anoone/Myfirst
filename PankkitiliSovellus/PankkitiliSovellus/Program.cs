using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pankkitilisovellus_v1");

            Console.WriteLine("Anna alkusaldon määrä");

            string alkusaldo = Console.ReadLine();

            Pankkitili pankkitili1 = new Pankkitili(int.Parse(alkusaldo));

            Console.WriteLine("Tilin 01 alkusaldo on : " + pankkitili1.Saldo);

            Console.WriteLine("Anna nostettava rahamäärä");

            string rahamaara = Console.ReadLine();

            try
            {
                pankkitili1.Nosta(int.Parse(rahamaara));
                Console.WriteLine("Tilin 01 saldo on : " + pankkitili1.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Tilillä ei ole nostovaraa");
            }
        }
    }
}
