using System;

namespace H9_Interfaces.Carbon_Footprint
{
    public class Huis : ICarbonFootPrint
    {
        //dit doe ik voor duidelijke controle bij Program.cs
        public int KubiekMeters { get; set; }
        public string Naam { get; set; }


        public int BerekenFootprint()
        {
            //De carbon footprint van een huis is gebaseerd op het volume van het huis in kubieke meter maal 10.
            if (KubiekMeters > 0)   //dit doe ik zelf om zelf te oefenen om better te coderen en fouten te voorkomen
            {
                return KubiekMeters * 10;
            }
            else
            {
                return int.MinValue; //het kleinste mogelijke cijfer dat bestaat 
            }
        }

        public void BevragenVanFootprint()
        {
            Console.WriteLine($"{Naam} uw Footprint is: {BerekenFootprint()} cubische meters");

        }

        public void VerlaagFootprint()
        {
            Console.WriteLine("Je FootPrint is verlaagd naar volgende Formule: (oude) KubiekMeters * 10 => (nieuwe) KubiekMeters * 5");
            Console.WriteLine($"Je FootPrint is nu: {KubiekMeters * 5}, (oude): {BerekenFootprint()}"); //ik doe het oude zo om te oefenen;
        }
    }
}

