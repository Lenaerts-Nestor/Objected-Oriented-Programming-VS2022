using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H8_Polymorfisme.Een_eigen_huis
{
    public class Huis
    {
        public List<Kamer> KamersList { get; set; } = new List<Kamer>();
        public int BerekenPrijs()
        {
            int Totaal = 0;

            foreach (var item in KamersList)
            {
                Totaal += item.Prijs;
            }

            return Totaal;
        }

    }
    public class Kamer
    {
        public virtual int Oppervlakte { get; set; } //vierkante meter
        public virtual int Prijs { get { return 400; } }//400 euro's
        

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
        public bool SchouwAanwezig { get; set; }
        public override int Prijs
        {
            get
            {
                if (!SchouwAanwezig)
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
