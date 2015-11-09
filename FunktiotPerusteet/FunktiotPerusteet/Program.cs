using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunktiotPerusteet
{
    class Program
    {

        static void Main(string[] args)
        {

            string tyontekija = "Pekka Porkkana";
            int vieraidenMaara = 0;
            int varattujaPoytia = 0;

            // Funktio joka ei palauta mitään. Tekee vain.
            TulostaOhjelmanNimi();

            // funktio palauttaa int arvon
            int poytiaYhteensa = HaePoytienKokonaismaara();
            Console.WriteLine("Paikkoja yhteensä: " + poytiaYhteensa + " kpl");

            // funktio palauttaa string arvon
            string poytienMaara = PalautaPoytienMaara();
            Console.WriteLine(poytienMaara);

            // funktio jolle annetaan parametri
            TulostaUudelleRiville("----------------------------------");
            TulostaUudelleRiville("Työntekijä: " + tyontekija);
            TulostaUudelleRiville("Kello on: " + DateTime.Now.ToShortTimeString());
            TulostaUudelleRiville("----------------------------------");


            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);

            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);

            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);

            TulostaUudelleRiville("----------------------------------");
            TulostaUudelleRiville("Vieraiden määrä: " + vieraidenMaara);
            KasvataVieraidenMaaraa(vieraidenMaara);
            TulostaUudelleRiville("Vieraiden määrä: " + vieraidenMaara);
            KasvataVieraidenMaaraa(vieraidenMaara);


            TulostaUudelleRiville("Vieraiden määrä: " + vieraidenMaara);
            KasvataVieraidenMaaraa(vieraidenMaara);
        }


        public static void KasvataVieraidenMaaraa(int vieraidenMaara)
        {
            vieraidenMaara = vieraidenMaara + 1;
            Console.WriteLine("(Tämä tulostuu funktiosta) Vieraiden määrä: " + vieraidenMaara);
        }




        public static int KasvataVarattujaPoytia(int varattujaPoytia)
        {
            return varattujaPoytia + 1;
        }

        public static void TulostaUudelleRiville(string tulostettavaMerkkijono)
        {
            Console.WriteLine(tulostettavaMerkkijono);
        }

        public static string PalautaPoytienMaara()
        {
            int poytienMaara = 12;
            return poytienMaara.ToString();


            // return "Paikkoja yhteensä: " + poytienMaara + " kpl (palautteen tietotyyppi string)";
        }

        public static int HaePoytienKokonaismaara()
        {
            int poytienMaara = 12;
            return poytienMaara;
        }

        public static void TulostaOhjelmanNimi()
        {
            Console.WriteLine("RUOKASALIN PAIKKALASKURI, VERSIO 1.0");
            Console.WriteLine("------------------------------------");
        }
    }
}
