using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTahti
{
    class Program
    {
        static void Main(string[] args)
        {
            // ====================================== 
            // ENSIMMAINEN OSA ====================== 
            // ====================================== 

            //Luo funktio, joka koristelee sille parametrina annetun
            // merkkijonon.Koristerivi - funktio koristelee merkkijonon
            // lisäämällä sen alkuun ja loppuun tähtiä 8 kappaletta.
            // Koristerivi("TURO");

            //Parantele Koristerivi-funktiota siten, että se huomioi nimen
            // pituuden.Voidaan olettaa, että merkkijonon kokonaispituus
            // kun mukaan luetaan tähdet ja nimi, on enintään 30 merkkiä.

            // Tehtävässä ei tarvitse huomioida parittomia lukuja, joten
            // jos nimessä on pariton määrä kirjaimia, voi tuloste olla 29
            // tai 31 merkkiä.
            // Koristerivi("TURO");
            //Koristerivi("SALMINEN");
            //Koristerivi("AB");

            //Parantele Koristerivi -funktiota siten, että voit määrittää
            //nimen lisäksi rivin pituuden.
            //Koristerivi("TURO", 30);

            //Parantele Koristerivi-funktiota siten, että voit määrittää
            //edellisten parametrien lisäksi tulostettavan merkin.
            // Koristerivi("TURO", 30, "=");

            // ====================================== 
            // TOINEN OSA =========================== 
            // ====================================== 

            // Luo funktio, joka tulostaa nimen päälle ja alle 3 riviä
            //  tähtiä.Voit hyödyntää edellisessä tehtävässä syntynyttä
            // funktiota kun tulostat nimeä.Huomaa, että tähtien määrä
            //riveillä pitää olla sama kuin edellisessä tehtävässä eli
            //  30 merkkiä.

            //  Tehtävässä ei tarvitse huomioida tilannetta, jossa nimessä
            //  on pariton määrä merkkejä. Voidaan olettaa, että tulostetuissa
            //  riveissä on aina 30 merkkiä nimen tulosteesta huolimatta.
            //  KoristeNelio("TURO");

            // Paranna edellistä funktiota siten, että voit nimen lisäksi
            // määrittää tulostettavien rivien ja rivin pituuden määrän.
            //  KoristeNelio("TURO", 3, 20);

            // Paranna edellistä funktiota siten, että voit antaa parametrina
            // tulostettavan merkin.Tarvittaessa voit hyödyntää harjoituksessa
            //  luotuja funktioita. Muuta tällöin funktioiden toteutuksia sellaiseksi,
            //  että ne vastaavat uutta toimeksiantoa.
            //  KoristeNelio("TÄHTI NELIÖ", 4, 40, "=");

            // ====================================== 
            // KOLMAS OSA =========================== 
            // ====================================== 

            //Olet tähän mennessä tehnyt funktion tulostamaan Koristerivin ja
            // koriste neliön. Nyt sovella osaamistasti ja toteuta samalla tapaa
            // KoristeKolmio.Funktio tulostaa kyljellään olevan kolmion.Voidaan
            //olettaa, että kolmion kärjen pituus on 10 merkkiä sen pohjasta.

            //Harjoituksessa riittää, että tulostat vain kolmion.Käyttäjän pitää
            // pystyä määrittämään tulostettava merkki funktioon annettavana
            // parametrinä.Nimeä ei tässä harjoituksessa ole pakko tulostaa.

            //Esimerkkituloste(kolmion kärki - tekstiä ei tarvitse tulostaa,
            //se on vain huomio):

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********(Kolmion kärki)
            // *******
            // ******
            // *****
            // ****
            // ***
            // **
            // *
            //KoristeKolmio("=");

            //Parantele KoristeKolmio-funktiota siten, että voit antaa tulostettavien
            // merkkien lisäksi pituuden kolmion kärkeä varten. Kolmion kärjellä tässä
            // tarkoitetaan kolmion riviä, jossa on kokonaisuudessaan annettu määrä
            // merkkejä.
            //KoristeKolmio("=", 20);

            // =================================
            // NELJÄS OSA ======================
            // =================================

            // Paranna aikaisemmin toteuttamaasi KoristeRivi-funktiota siten,
            // että toteutat sen olio-ohjelmoinnin tapaan. Tämä tarkoittaa sitä,
            // että luot luokan nimeltä Koristaja, jolla on TulostaRivi-metodi.
            //
            // Olion luominen ja metodin kutsuminen tapahtuu seuraavalla tavalla:
            //
            //Koristaja koristaja = new Koristaja();
            //koristaja.TulostaRivi("TURO", 30, "=");

            // Paranna Korista-luokkaa siten, että siirrät myös KoristeNelio-funktion
            // toiminnallisuuden luokan metodiksi. Metodin nimi Koristaja-luokassa 
            // on TulostaNelio.
            //
            // Olion luominen ja metodin kutsuminen tapahtuu seuraavalla tavalla:
            //
            //Koristaja koristaja = new Koristaja();
            //koristaja.TulostaNelio("SALMINEN", 2, 25, "=");

            // =================================
            // VIIDES OSA ======================
            // =================================

            // Tähän mennessä alkuperäiset funktiot on siirretty Koristaja-luokan
            // metodeiksi. Varsinaisesti tässä ei vielä luokan ominaisuuksia hyödynnetä.
            // Seuraavaksi tehtävänä on huomioida samankaltaiset piirteet luokan
            // metodeista ja siirtää ne luokan ominaisuuksiksi.
            //
            // Luodaan seuraavaksi luokalle ominaisuudet: tulostettavaMerkkijono,
            // rivienMaara, sarakkeidenMaara ja tulostettavaMerkki.
            //
            // Luokan ominaisuudet voivat olla julkisia (public) tässä harjoituksessa,
            // jotta voit käsitellä tietoja. Lopputuloksena oliota käsitellään seuraavalla
            // tavalla.
            //
            // (HUOM: jos et sijoita ominaisuuksiin arvoja, ohjelma saattaa tässä vaiheessa
            // vielä aiheuttaa virheen.)
            //Koristaja koristaja = new Koristaja();
            //koristaja.tulostettavaMerkkijono = "TURO";
            //koristaja.tulostettavaMerkki = "#";
            //koristaja.rivienMaara = 3;
            //koristaja.sarakkeidenMaara = 25;

            // Nyt luokalla on ominaisuuksia mutta ne eivät vielä vaikuta ohjelmaan.
            // Seuraavaksi parannetaan TulostaRivi-metodia siten, että voit määrittää
            // sen käyttämät parametrit luokan ominaisuuksia käyttäen. Tämä vaatii
            // muutoksia TulostaRivi-metodin kutsumiseen. 
            //
            // Olion luominen ja metodin kutsuminen tapahtuu seuraavalla tavalla:
            //Koristaja koristaja = new Koristaja();
            //koristaja.tulostettavaMerkkijono = "TURO";
            //koristaja.tulostettavaMerkki = "#";
            //koristaja.rivienMaara = 3;
            //koristaja.sarakkeidenMaara = 25;

            //koristaja.TulostaRivi();

            // =================================
            // KUUDES OSA ======================
            // =================================
            //
            // Edellisessä harjoituksessa loit luokalle ominaisuudet ja parantelit
            // olemassaolevaa metodia. Nyt tee samoin mutta luokan toiselle metodille,
            // eli TulostaNelio-metodille.
            //
            // Olion luominen ja metodin kutsuminen tapahtuu seuraavalla tavalla:
            //
            // (HUOM. kun olet toteuttanut tämän osan, sinulla on kaksi metodia luokassa.
            // On hyvien tapojen mukaista katsoa mitä samaa metodit tekevät ja mikäli
            // et ole siistinyt ohjelmakoodia, tässä on hyvä paikka. Siistimisellä
            // tässä tarkoitetaan, että voit luoda luokkaan yksityisiä (private) metodeja
            // joita käytetään vain luokan sisällä. Eli metodeja ei voi kutsua kuten
            // TulostaRivi() ja TulostaNelio() -metodeja.)
            Koristaja koristaja = new Koristaja();
            koristaja.tulostettavaMerkkijono = "TURO";
            koristaja.tulostettavaMerkki = "#";
            koristaja.rivienMaara = 2;
            koristaja.sarakkeidenMaara = 15;

            koristaja.TulostaNelio();
        }



        // ====================================== 
        // ENSIMMAINEN OSA ====================== 
        // ====================================== 
        static void Koristerivi(string nimi)
        {
            int nimenPituus = nimi.Length;
            int tulostettavienMerkkienMaara = 30 - nimenPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli);
            Console.Write(nimi);
            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli);
            Console.WriteLine();
        }

        static void Koristerivi(string nimi, int sarakkeidenMaara)
        {
            int nimenPituus = nimi.Length;
            int tulostettavienMerkkienMaara = sarakkeidenMaara - nimenPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli);
            Console.Write(nimi);
            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli);
            Console.WriteLine();
        }

        static void TulostaKoristeMerkit(int maara)
        {
            for (int i = 0; i < maara; i++)
                Console.Write("*");
        }

        // ====================================== 
        static void Koristerivi(string nimi, int sarakkeidenMaara, string tulostettavaMerkki)
        {
            int nimenPituus = nimi.Length;
            int tulostettavienMerkkienMaara = sarakkeidenMaara - nimenPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli, tulostettavaMerkki);
            Console.Write(nimi);
            TulostaKoristeMerkit(tulostettavienMerkkienMaaraPerPuoli, tulostettavaMerkki);
            Console.WriteLine();
        }

        static void TulostaKoristeMerkit(int maara, string tulostettavaMerkki)
        {
            for (int i = 0; i < maara; i++)
                Console.Write(tulostettavaMerkki);
        }


        // ====================================== 
        // TOINEN OSA =========================== 
        // ====================================== 
        static void KoristeNelio(string nimi)
        {
            TulostaKoristerivi(3, 30);
            Koristerivi(nimi);
            TulostaKoristerivi(3, 30);
        }

        static void TulostaKoristerivi(int rivienMaara, int sarakkeidenMaara)
        {
            for (int i = 0; i < rivienMaara; i++)
            {
                TulostaKoristeMerkit(sarakkeidenMaara);
                Console.WriteLine();
            }
        }

        // ====================================== 
        static void KoristeNelio(string nimi, int rivienMaara, int sarakkeidenMaara)
        {
            TulostaKoristerivi(rivienMaara, sarakkeidenMaara);
            Koristerivi(nimi, sarakkeidenMaara);
            TulostaKoristerivi(rivienMaara, sarakkeidenMaara);
        }

        static void KoristeNelio(string nimi, int rivienMaara, int sarakkeidenMaara, string tulostettavaMerkki)
        {
            TulostaKoristerivi(rivienMaara, sarakkeidenMaara, tulostettavaMerkki);
            Koristerivi(nimi, sarakkeidenMaara, tulostettavaMerkki);
            TulostaKoristerivi(rivienMaara, sarakkeidenMaara, tulostettavaMerkki);
        }

        static void TulostaKoristerivi(int rivienMaara, int sarakkeidenMaara, string tulostettavaMerkki)
        {
            for (int i = 0; i < rivienMaara; i++)
            {
                TulostaKoristeMerkit(sarakkeidenMaara, tulostettavaMerkki);
                Console.WriteLine();
            }
        }

        // ====================================== 
        // KOLMAS OSA =========================== 
        // ====================================== 
        static void KoristeKolmio(string tulostettavaMerkki)
        {
            string rivinMerkit = tulostettavaMerkki;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(rivinMerkit);
                rivinMerkit += tulostettavaMerkki;
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(rivinMerkit);
                rivinMerkit = rivinMerkit.Remove(rivinMerkit.Length - 1);
            }
        }

        static void KoristeKolmio(string tulostettavaMerkki, int sarakkeidenMaara)
        {
            string rivinMerkit = tulostettavaMerkki;
            for (int i = 1; i < sarakkeidenMaara; i++)
            {
                Console.WriteLine(rivinMerkit);
                rivinMerkit += tulostettavaMerkki;
            }
            for (int i = sarakkeidenMaara; i > 0; i--)
            {
                Console.WriteLine(rivinMerkit);
                rivinMerkit = rivinMerkit.Remove(rivinMerkit.Length - 1);
            }
        }

    }
}
