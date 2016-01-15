using System.Collections.Generic;

namespace ListaRefaktorointi
{
    public class Tilaus
    {
        public int tilausnro;
        public string poyta;
        public double loppusumma;
        public List<Tilausrivi> tilausrivit;

        public Tilaus()
        {
            tilausrivit = new List<Tilausrivi>();
        }

        public void UusiTilaus(List<Tilaus> ptilaukset, string ppoyta, double ploppusumma)
        {
            int uusitilausnro = VapaaTilausnumero(ptilaukset);

            Tilaus uusitilaus = new Tilaus();

            uusitilaus.tilausnro = uusitilausnro;
            uusitilaus.poyta = ppoyta;
            uusitilaus.loppusumma = ploppusumma;

            ptilaukset.Add(uusitilaus);
        }

        private int VapaaTilausnumero(List<Tilaus> ptilaukset)
        {
            int suurintilausnro = 0;
            for (int i = 0; i < ptilaukset.Count; i++)
            {
                if (ptilaukset[i].tilausnro > suurintilausnro)
                {
                    suurintilausnro = ptilaukset[i].tilausnro;
                }
            }
            return suurintilausnro + 1;
        }
    }
}
