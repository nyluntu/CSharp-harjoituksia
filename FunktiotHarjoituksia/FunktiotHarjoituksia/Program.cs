using System;

namespace FunktiotHarjoituksia
{
    // Program on C# -luokka. Luokkia ja olioita ei
    // ole vielä käsitelty mutta ymmärrät asian
    // myöhemmin, ettei kyse ole mistään muusta.
    class Program
    {

        // Main -metodi (funktio, aliohjelma), jota kutsutaan ohjelman
        // käynnistyessä. Saa parametrina merkkijono-taulukon
        // ja ei palauta mitään, koska on void -tyyppinen metodi.
        static void Main(string[] args)
        {
            string tyontekija = "Pekka Porkkana";
            int varattujaPoytia = 0;
            int vieraidenMaara = 0;

            // Kutsutaan TulostaOhjelmanNimi-metodia. Katso metodin
            // kuvauksesta mitä tekee. Esimerkki yksinkertaisesta metodista,
            // joka ei palauta mitään tai ota parametreja.
            TulostaOhjelmanNimi();
            Console.WriteLine("------------------------------------");

            // Kutsutaan HaePaikkojenKokonaismaara-metodia. Katso
            // metodin kuvauksesta mitä tekee. Esimerkki arvon palauttavasta
            // metodista mutta ei ota parametreja.
            int poytiaYhteensa = HaePoytienKokonaismaara();
            Console.WriteLine("Paikkoja yhteensa: " + poytiaYhteensa + " kpl");

            // Vaihtoehtoinen tapa edelliselle tulostukselle, jossa käytetään
            // metodia, joka palauttaa eri tyyppisen paluuarvon. 
            string poytienMaara = PalautaPoytienMaara();
            Console.WriteLine(poytienMaara);

            // Kutsutaan TulostaUudelleRiville-metodia. Katso metodin 
            // kuvauksesta mitä tekee. Esimerkki parametria käyttävästä 
            // metodista, jolle annetaan tietoa mutta ei palauta mitään.
            //
            // Parametrillinen metodi voi myös palauttaa arvon yllä
            // esitettyjen esimerkkien mukaisesti.
            TulostaUudelleRiville("------------------------------------");
            TulostaUudelleRiville("Työntekija: " + tyontekija);
            TulostaUudelleRiville("Kello: " + DateTime.Now.ToShortTimeString());
            TulostaUudelleRiville("------------------------------------");

            // Kutsutaan KasvataVarattujaPoytia-metodia. Katso metodin
            // kuvauksesta mitä tekee. Esimerkki metodista, jolle annetaan
            // parametri, suorittaa tehtävän ja palauttaa arvon.
            // 
            // Metodin kuvauksessa on kuitenkin kerrottu huomioita, mitä 
            // asioita tässä halutaan korostaan. Metodia kutsutaan mallin
            // vuoksi useampia kertoja.
            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);
            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);
            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            varattujaPoytia = KasvataVarattujaPoytia(varattujaPoytia);
            TulostaUudelleRiville("Varattuja pöytiä: " + varattujaPoytia);
            TulostaUudelleRiville("------------------------------------");

            // Kutsutaan KasvataVieraidenMaaraa()-metodia. Katso metodin
            // kuvauksesta mitä tekee. Esimerkki metodeissa käytettävistä
            // muuttujista. Edellisessä esimerkissä käytiin jo läpi, mutta
            // tämä on hieman erilainen.
            TulostaUudelleRiville("Vieraiden maara: " + vieraidenMaara);
            KasvataVieraidenMaaraa(vieraidenMaara);
            TulostaUudelleRiville("Vieraiden maara: " + vieraidenMaara);
            KasvataVieraidenMaaraa(vieraidenMaara);
            TulostaUudelleRiville("------------------------------------");
        }

        /// <summary>
        /// void TulostaOhjelmanNimi()
        /// 
        /// Huomaa avainsana "void". Void tarkoittaa, että metodi
        /// ei palauta mitään arvoa. Metodi siis vain suorittaa sille
        /// määritetyt tehtävät. Esimerkin tapauksessa tulostaa
        /// komentokehotteeseen ohjelman otsikon.
        /// </summary>
        static void TulostaOhjelmanNimi()
        {
            Console.WriteLine("RUOKASALIN PAIKKALASKURI, versio 1.0");
        }

        /// <summary>
        /// int HaePoytienKokonaismaara()
        /// 
        /// Huomaa avainsana "int". Int on yksi ohjelmointikielen
        /// perustyypeistä, joita muuttujat voivat olla. Metodi voi siis
        /// palauttaa minkä tahansa muuttujan tyypin, kun int-avainsana
        /// korvataan jollain muulla tyypillä, esimerkiksi string.
        /// 
        /// Metodi voi palauttaa myös monimutkaisempia arvoja kuten olioita.
        /// Olioita käsitellään myöhemmin opintojakson luennoilla.
        /// </summary>
        /// <returns></returns>
        static int HaePoytienKokonaismaara()
        {
            int poytienMaara = 12;
            return poytienMaara;
        }

        /// <summary>
        /// string PalautaPoytienMaara()
        /// 
        /// Esimerkki metodista, jossa aikaisemmin esitetyn esimerkin
        /// sijaan palautetaan string-tietoptyyppi.
        /// </summary>
        /// <returns></returns>
        static string PalautaPoytienMaara()
        {
            int poytienMaara = 12;
            return "Paikkoja yhteensa: " + poytienMaara + " kpl (vaihtoehtoinen)";
        }

        /// <summary>
        /// void TulostaUudelleRiville(string tulostettavaMerkkijono)
        /// 
        /// Huomaa metodin nimen perässä, sulkujen sisällä oleva
        /// "string" -perustyyppi ja "tulostettavaMerkkijono"-muuttuja.
        /// 
        /// Metodiin voidaan antaa yksi tai useampi määrä parametreja,
        /// jotka voivat olla ohjelmointikielen perustyyppejä tai monimutkaisempia
        /// tietotyyppejä. Esimerkissä annetaan vain yksi parametri mutta
        /// useamman parametrin tilanteessa jokainen erotetaan pilkulla.
        /// 
        /// Huomaa parametrin merkintätapa:
        /// 
        /// tietotyyppi muuttujanNimi
        /// string      tulostettavaMerkkijono
        /// </summary>
        /// <param name="tulostettavaMerkkijono"></param>
        static void TulostaUudelleRiville(string tulostettavaMerkkijono)
        {
            Console.WriteLine(tulostettavaMerkkijono);
        }

        /// <summary>
        /// int KasvataVarattujaPoytia(int varattujaPoytia)
        /// 
        /// Huomaa, että parametrin nimi on sama kuin muuttujan, joka
        /// on esitelty pääohjelmassa. Tämän esimerkin tavoitteena on
        /// havainnollistaa, että muuttuja ei ole sama kuin metodissa
        /// käytettävä parametri.
        /// 
        /// Metodissa parametrina annettu arvo kopioituu metodin käyttöön
        /// omaksi muutujakseen. Joten pääohjelmassa esitetty "varattujaPoytia"
        /// -muuttuja ja parametrina esitelty "varattujaPoytia"-parametri,
        /// ovat kaksi eri asiaa. Metodissa parametrista tulee sen muuttuja.
        /// 
        /// Tämän avulla metodissa voidaan käyttää samannimisä muuttujia kuin
        /// pääohjelmassa eivätkä ne sekoita toisiaan.
        /// 
        /// Esimerkissä parametrina annettua arvoa kasvatetaan ja palautetaan
        /// uusi arvo sinne, missä metodia on kutsuttu.
        /// </summary>
        /// <param name="varattujaPoytia"></param>
        /// <returns></returns>
        static int KasvataVarattujaPoytia(int varattujaPoytia)
        {
            return varattujaPoytia + 1;
        }

        /// <summary>
        /// void KasvataVieraidenMaaraa(int vieraidenMaara)
        /// 
        /// Huomaa metodissa, että parametrina annetun arvon nimi
        /// on sama kuin pääohjelman muuttuja. 
        /// 
        /// Esimerkissä yritetään kasvattaa vieraiden lukumäärää.
        /// Vaikka lukua kasvatetaan niin sen muutokset eivät heijastu
        /// pääohjelmaan. Tällöin huomataan, että metodissa muuttujat
        /// ovat omia ja voivat olla saman nimisiä kuin pääohjelmassa.
        /// 
        /// Kun metodiin lähetetään parametrina arvo, sen arvo kopioituu
        /// alkuperäisestä muuttujasta. On myös tapoja vaikuttaa tähän
        /// käytökseen mutta niitä ei tässä harjoituksessa käydä läpi.
        /// </summary>
        /// <param name="vieraidenMaara"></param>
        static void KasvataVieraidenMaaraa(int vieraidenMaara)
        {
            vieraidenMaara = vieraidenMaara + 1;
            Console.WriteLine("(Tämä tulostuu metodista) Vieraiden lukumäärä: " + vieraidenMaara);
        }
    }
}
