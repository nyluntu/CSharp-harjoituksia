using System;
using System.Collections.Generic;

namespace ListaRefaktorointi
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Tilaus> tilaukset = new List<Tilaus>();

            var listankoko = tilaukset.Count;


            Tilaus tilaus1 = new Tilaus(6543, "Pöytä 1");
            Tilausrivi tilausrivi1 = new Tilausrivi("Lehtipihvi", 12.5, 1);
            Tilausrivi tilausrivi2 = new Tilausrivi("Nakit ja muussi", 9.5, 1);
            tilaus1.LisaaTilausrivi(tilausrivi1);
            tilaus1.LisaaTilausrivi(tilausrivi2);

            Console.WriteLine(tilaus1.PalautaLoppusumma());


            tilaukset.Add(tilaus1);

            //List<Tilaus> tilaukset = new List<Tilaus>();

            //tilaus.UusiTilaus(tilaukset, "Pöytä 1", 39.90);
            //Console.WriteLine(tilaukset.Count);

            //tilaus.UusiTilaus(tilaukset, "Pöytä 2", 12.50);
            //Console.WriteLine(tilaukset.Count);

            //tilaus.UusiTilaus(tilaukset, "Pöytä 1", 104.30);
            //Console.WriteLine(tilaukset.Count);

            //for (int i = 0; i < tilaukset.Count; i++)
            //{
            //    Console.WriteLine(tilaukset[i].tilausnro);
            //    Console.WriteLine(tilaukset[i].poyta);
            //    Console.WriteLine(tilaukset[i].loppusumma);
            //}

            Console.ReadKey();
        }
    }
}
