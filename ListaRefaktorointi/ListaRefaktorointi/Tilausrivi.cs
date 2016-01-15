namespace ListaRefaktorointi
{
    public class Tilausrivi
    {
        public string tuote;
        public double ahinta;
        public int maara;

        public Tilausrivi(string ptuote, double pahinta, int pmaara)
        {
            tuote = ptuote;
            ahinta = pahinta;
            maara = pmaara;
        }
    }

}
