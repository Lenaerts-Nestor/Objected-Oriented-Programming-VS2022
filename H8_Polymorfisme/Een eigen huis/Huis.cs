using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H8_Polymorfisme.Een_eigen_huis
{
    public class Huis
    {
        public List<Kamer> Kamers { get; set; } = new List<Kamer>();
        public int BerekenPrijs()
        {
            int totaal = 0;
            foreach (var item in Kamers)
            {
                totaal += item.Prijs;
            }
            return totaal;
        }
        
    }

    public class Kamer : Huis
    {
        public int Oppervlakte { get; set; }
        public string Naam { get; set; }
        public virtual int Prijs { get { return 400; } } 

    }
    public class BadKamer : Kamer { 
    
        public override int Prijs { get { return 500; } }
    
    
    
    }
    public class Salon : Kamer
    {
        public bool schouw { get; set; }
        public override int Prijs
        {
            get
            {
                if (schouw)
                {
                    return 300;
                }
                else
                {
                    return 500;
                }
            }
        }
    }

}
