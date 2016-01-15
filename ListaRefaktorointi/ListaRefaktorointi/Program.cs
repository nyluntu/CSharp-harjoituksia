using System;
using System.Collections.Generic;

namespace ListaRefaktorointi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tilaus tilaus = new Tilaus();

            List<Tilaus> tilaukset = new List<Tilaus>();

            tilaus.UusiTilaus(tilaukset, "Pöytä 1", 39.90);
            Console.WriteLine(tilaukset.Count);

            tilaus.UusiTilaus(tilaukset, "Pöytä 2", 12.50);
            Console.WriteLine(tilaukset.Count);

            tilaus.UusiTilaus(tilaukset, "Pöytä 1", 104.30);
            Console.WriteLine(tilaukset.Count);

            for (int i = 0; i < tilaukset.Count; i++)
            {
                Console.WriteLine(tilaukset[i].tilausnro);
                Console.WriteLine(tilaukset[i].poyta);
                Console.WriteLine(tilaukset[i].loppusumma);
            }

            Console.ReadKey();
        }
    }
}
