using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_Gevorderde_Overervingsconcepten.DierenTuin
{
    abstract class Dier
    {
        public int Gewicht { get; set; }
        public abstract void Zegt();

    
    }
    class Paard : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("Behehehe");
        }
       
    }
    class Koe : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("MOEEE");
        }
    }

    class Hond : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("wuf wuf wof");
        }
    }

}
