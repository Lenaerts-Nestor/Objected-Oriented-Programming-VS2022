using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H8_Polymorfisme.Een_eigen_huis
{
    public class Huis
    {
        Kamer[] MultipleKamers = new Kamer[3]; //3 kamers in totaal
        public void BerekenPrijs()
        {
            int Totaal = 0;

            for (int i = 0; i < MultipleKamers.Length; i++)
            {
                Totaal += MultipleKamers[i].Prijs;
            }
        }

    }
    public class Kamer
    {
        public virtual int Oppervlakte { get; set; } //vierkante meter
        public virtual int Prijs { get { return 400; } }//400 euro's
        public bool schouw { get; set; }

    }
    public class BadKamer : Kamer
    {
        public override int Prijs { get { return 500; } }   
    }
    public class Gang: Kamer
    {
        public override int Prijs { get { return Oppervlakte * 10; } }
    }
    public class Salon : Kamer
    {
        public override int Prijs
        {
            get
            {
                if (!schouw)
                {
                    return 500;
                }
                else
                {
                    return 300;
                }

            }
        }
    }
}
