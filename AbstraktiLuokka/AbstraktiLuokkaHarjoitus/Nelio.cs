using System;

namespace AbstraktiLuokkaHarjoitus
{
    public class Nelio : Kuvio
    {
        int sivunLeveys;

        public Nelio(int sivunLeveys)
        {
            this.sivunLeveys = sivunLeveys;
        }

        public override double LaskeAla()
        {
            return sivunLeveys * sivunLeveys;
        }

        public void PiirraNelio()
        {
            Console.WriteLine(" [ ] ");
        }

    }
}
