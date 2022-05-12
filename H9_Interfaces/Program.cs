using H9_Interfaces.Carbon_Footprint;     //Voeg dit toe als je een folder gebruikt
using System;
using System.Collections.Generic;

namespace H9_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //Oefening Tonen:
            //creer een lijst met de objecten en Toon ze:

            ///Kleine Uitleg: ik gebruik ICarbonFootPrint want ik wil de methodes dervan gebruiken.
            ///Je hebt verschillende klasses met verschillende properties en zelf mischien methodes daarin. Het zal veel errors/bugs geven als je een klasse kiest die niet Hoofdparent of Interface is. (Polymorfisme!!)
            List<ICarbonFootPrint> footprints = new List<ICarbonFootPrint>()
            {
                //twee huizen: 
                new Huis(){ KubiekMeters =45, Naam = "pedro" },
                new Huis(){ KubiekMeters = 90, Naam = "Jonatan" },
                 //twee Fabrieken:
                new Fabriek(){AantalWerknemers = 132, FabriekNaam = "Bol.com"},
                new Fabriek(){AantalWerknemers =700, FabriekNaam = "AppelFabriek"}
            };

            
           

            //Deze manier werk ook
                    /*
             
                      var lijstmetobjjecten = new List<ICarbonFootPrint>()
                    {
                
                        //twee huizen: 
                        new Huis(){ KubiekMeters =45, Naam = "pedro" },
                        new Huis(){ KubiekMeters = 90, Naam = "Jonatan" },
                         //twee Fabrieken:
                        new Fabriek(){AantalWerknemers = 132, FabriekNaam = "Bol.com"},
                        new Fabriek(){AantalWerknemers =700, FabriekNaam = "AppelFabriek"}

                    };
             
             
             
                     */

            foreach (var item in footprints)
            {
                item.BevragenVanFootprint();
                

            }


        }
    }
}
