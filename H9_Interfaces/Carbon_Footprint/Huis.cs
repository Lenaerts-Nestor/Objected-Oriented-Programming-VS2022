using System;

namespace H9_Interfaces.Carbon_Footprint
{
    public class Huis : ICarbonFootPrint
    {
        public string Eigenaar { get; set; } = "Nestor";
        public int Volume { get;  set; }
        public int Factor { get; set; } = 10;
        public int BerekenFootPrint()
        {
            return Volume * Factor;
        }

        public void FootprintVragen()
        {
            Console.WriteLine($"Het Huis van {Eigenaar} heeft een Footprint van {BerekenFootPrint()}");

        }

        public void VerlaagFootprint()
        {
            --Factor;
        }
    }
}

