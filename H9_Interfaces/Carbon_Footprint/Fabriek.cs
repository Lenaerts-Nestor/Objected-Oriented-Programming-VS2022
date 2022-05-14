using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9_Interfaces.Carbon_Footprint
{
    public class Fabriek : ICarbonFootPrint
    {
        public string FabriekNaam { get; set; } = "Geen Naam";
        public int Werknemers { get; set; }
        public int Factor { get; set; } = 100;
        public int BerekenFootPrint()
        {
            return Werknemers * Factor;
        }
        public void FootprintVragen()
        {
            Console.WriteLine($"Het Huis van {FabriekNaam} heeft een Footprint van {BerekenFootPrint()}");

        }

        public void VerlaagFootprint()
        {
            Factor -= 10;
        }
    }
}

