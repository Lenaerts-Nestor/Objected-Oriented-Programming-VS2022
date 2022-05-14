using H9_Interfaces.Carbon_Footprint;     //Voeg dit toe als je een folder gebruikt
using System;
using System.Collections.Generic;

namespace H9_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ik gebruik geen as want allemaal zijn relationeerd met IcarbonFootprint interface


            //Manier 1:
            List<ICarbonFootPrint> listvanstuff = new List<ICarbonFootPrint>()
            {
                new Huis(){Eigenaar = "Nestor", Volume = 45},
                new Huis(){Eigenaar = "Nestor", Volume = 90},

                new Fabriek(){FabriekNaam = "appel", Werknemers = 132},
                new Fabriek(){FabriekNaam = "China", Werknemers = 700}
            };

            for (int i = 0; i < listvanstuff.Count; i++)
            {
                if (listvanstuff[i] is Fabriek)
                {
                    listvanstuff[i].FootprintVragen();
                }
                else
                {
                    Console.WriteLine("dit is geen fabriek");
                }
            }


            //Manier 2: 
            var lijstmetobjjecten = new List<ICarbonFootPrint>()
            {
               
                new Huis(){ Volume =45, Eigenaar = "pedro" },
                new Huis(){ Volume = 90, Eigenaar = "Jonatan" },
                 
                new Fabriek(){Werknemers = 132, FabriekNaam = "Bol.com"},
                new Fabriek(){Werknemers =700, FabriekNaam = "AppelFabriek"}
            };


            Console.WriteLine("\n\n");

            for (int i = 0; i < lijstmetobjjecten.Count; i++)
            {
                if (lijstmetobjjecten[i] is Huis)
                {
                    lijstmetobjjecten[i].FootprintVragen();
                }
                else
                {
                    Console.WriteLine("dit is geen huis");
                }

            }

        }
    }
}
