using System;

namespace AbstraktiLuokkaHarjoitus
{
    public class Nelio : Kuvio
    {
        double sivunLeveys;

        public Nelio(double sivunLeveys)
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
