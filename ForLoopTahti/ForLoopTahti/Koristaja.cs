using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTahti
{
    public class Koristaja
    {
        public string tulostettavaMerkkijono;
        public string tulostettavaMerkki;
        public int rivienMaara;
        public int sarakkeidenMaara;

        // NELJÄS OSA
        // Ei ole siistitty
        public void TulostaRivi(string nimi, int sarakkeidenMaara, string tulostettavaMerkki)
        {
            int nimenPituus = nimi.Length;
            int tulostettavienMerkkienMaara = sarakkeidenMaara - nimenPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            for (int i = 0; i < sarakkeidenMaara; i++)
                Console.Write(tulostettavaMerkki);

            Console.Write(nimi);

            for (int i = 0; i < sarakkeidenMaara; i++)
                Console.Write(tulostettavaMerkki);

            Console.WriteLine();
        }

        // VIIDES OSA
        // Ei ole siistitty
        public void TulostaRivi()
        {
            int merkkijononPituus = this.tulostettavaMerkkijono.Length;
            int tulostettavienMerkkienMaara = this.sarakkeidenMaara - merkkijononPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            for (int i = 0; i < this.sarakkeidenMaara; i++)
                Console.Write(this.tulostettavaMerkki);

            Console.Write(this.tulostettavaMerkkijono);

            for (int i = 0; i < this.sarakkeidenMaara; i++)
                Console.Write(this.tulostettavaMerkki);

            Console.WriteLine();
        }

        // NELJÄS OSA
        // Ei ole siistitty
        public void TulostaNelio(string nimi, int rivienMaara, int sarakkeidenMaara, string tulostettavaMerkki)
        {
            for (int i = 0; i < rivienMaara; i++)
            {
                for (int j = 0; j < sarakkeidenMaara; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            int nimenPituus = nimi.Length;
            int tulostettavienMerkkienMaara = sarakkeidenMaara - nimenPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            for (int i = 0; i < tulostettavienMerkkienMaaraPerPuoli; i++)
                Console.Write("*");
            Console.Write(nimi);

            for (int i = 0; i < tulostettavienMerkkienMaaraPerPuoli; i++)
                Console.Write("*");
            Console.WriteLine();

            for (int i = 0; i < rivienMaara; i++)
            {
                for (int j = 0; j < sarakkeidenMaara; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        // VIIDES OSA
        // Ei ole siistitty
        public void TulostaNelio()
        {
            for (int i = 0; i < this.rivienMaara; i++)
            {
                for (int j = 0; j < this.sarakkeidenMaara; j++)
                    Console.Write(this.tulostettavaMerkki);
                Console.WriteLine();
            }

            int merkkijononPituus = this.tulostettavaMerkkijono.Length;
            int tulostettavienMerkkienMaara = this.sarakkeidenMaara - merkkijononPituus;
            int tulostettavienMerkkienMaaraPerPuoli = tulostettavienMerkkienMaara / 2;

            for (int i = 0; i < tulostettavienMerkkienMaaraPerPuoli; i++)
                Console.Write(this.tulostettavaMerkki);
            Console.Write(this.tulostettavaMerkkijono);

            for (int i = 0; i < tulostettavienMerkkienMaaraPerPuoli; i++)
                Console.Write(this.tulostettavaMerkki);
            Console.WriteLine();

            for (int i = 0; i < this.rivienMaara; i++)
            {
                for (int j = 0; j < this.sarakkeidenMaara; j++)
                    Console.Write(this.tulostettavaMerkki);

                Console.WriteLine();
            }
        }
    }
}
