using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9_Interfaces.Carbon_Footprint
{
    public class Fabriek : ICarbonFootPrint
    {
        public string FabriekNaam { get; set; }
        public int AantalWerknemers { get; set; }
        public int BerekenFootprint()
        {
            return AantalWerknemers*100;
        }

        public void BevragenVanFootprint()
        {
            Console.WriteLine($"Fabriek {FabriekNaam} uw Footprint is: {BerekenFootprint()} cubische meters");
        }

       //verlaagFootprint laat ik effe leeg:
        public void VerlaagFootprint()
        {
            throw new NotImplementedException();
        }
    }
}
