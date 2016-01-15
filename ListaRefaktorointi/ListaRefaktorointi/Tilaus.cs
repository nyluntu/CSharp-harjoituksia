using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaRefaktorointi
{
    /*
    Tärkeä muistisääntö on, että luokan pitäisi käsitellä vain yhtä
    asiaa eli sillä on yksi syy muuttua. Kun luokan vastuulla on useampi
    kuin yksi tehtävä, syntyy usein monimutkaisia rakenteita, jotka myöhemmin
    johtavat ongelmiin.
    */
    public class Tilaus // Luokan nimi viittaa tilaukseen, joten keskitytään siihen
    {
        public int tilausnro; // hyvä luokan attribuutti
        public string poyta; // samoin tämä
        public List<Tilausrivi> tilausrivit; // hyvä attribuutti

        public Tilaus(int tilausnumero, string poyta)
        {
            this.tilausnro = tilausnumero;
            this.poyta = poyta;
            tilausrivit = new List<Tilausrivi>();
        }

        public void LisaaTilausrivi(Tilausrivi rivi)
        {
            tilausrivit.Add(rivi);
        }

        public double PalautaLoppusumma()
        {
            double loppusumma = 0;
            foreach (Tilausrivi rivi in tilausrivit)
            {
                loppusumma += rivi.ahinta;
            }
            return loppusumma;
        }

        /*
        Tärkeä samankaltainen muistisääntö metodeille on, että ne tekevät yhden asian.
        Sama ohjeistus kuin luokkien kanssa. Metodin nimen pitää olla kuvaava sen tekemälle
        asialle.

        UusiTilaus siis luo uuden Tilaus-olion, täyttää parametreina annetut tiedot, hakee
        uuden tilausnumeron ja tallentaa sen listaan.

        Voidaan miettiä uudestaan näin päin:
        - UusiTilaus??? Kun luot tämän tilaus luokan niin eikös rakentaja tee juuri saman asian?
        - Metodissa luodaan sama luokka kuin missä metodi on. Rakenne aiheuttaa helposti ongelmia.
        - Metodissa lisätään tilaus listaan, joka sisältää tilauksia eli ns. tietokanta. Tässä
          tärkeä kysymys on: Miksi Tilaus-luokka tietää miten ja minne tallennetaa? Nämä kannattaa erottaa.
        */
        //public void UusiTilaus(List<Tilaus> ptilaukset, string ppoyta, double ploppusumma)
        //{
        //    int uusitilausnro = VapaaTilausnumero(ptilaukset);

        //    Tilaus uusitilaus = new Tilaus();

        //    uusitilaus.tilausnro = uusitilausnro;
        //    uusitilaus.poyta = ppoyta;
        //    uusitilaus.loppusumma = ploppusumma;

        //    ptilaukset.Add(uusitilaus);
        //}

        //private int VapaaTilausnumero(List<Tilaus> ptilaukset)
        //{
        //    int suurintilausnro = 0;
        //    for (int i = 0; i < ptilaukset.Count; i++)
        //    {
        //        if (ptilaukset[i].tilausnro > suurintilausnro)
        //        {
        //            suurintilausnro = ptilaukset[i].tilausnro;
        //        }
        //    }
        //    return suurintilausnro + 1;
        //}
    }
}
