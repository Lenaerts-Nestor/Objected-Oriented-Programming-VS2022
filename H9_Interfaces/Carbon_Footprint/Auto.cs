using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H9_Interfaces.Carbon_Footprint
{
    public enum Merk { Audi, Toyota, Mercedes, Onbekend } //zet het public
    public class Auto : ICarbonFootPrint
    {
        //hier zal ik een Enum gebruiken: zelf gekozen om mijn skils te oefenen:
        //en het is ook logische denk ik:
        public Merk MerkVanAuto { get; set; }
        public int BerekenFootprint()
        {
            //ik heb het volgende gedaan. ik zet in verbruik van auto als ze audi hebben als merk dat het waarde 45 zal zijn.
            //nu VerbruikVanAuto heeft het waarde 45 en deze waarde kan ik returneren.
            int VerbruikVanAuto = MerkVanAuto switch
            {
                Merk.Audi => 45,
                Merk.Toyota => 37,
                Merk.Mercedes => 25,
                Merk.Onbekend => int.MinValue,
                _ => throw new NotImplementedException()

            };

            return VerbruikVanAuto;         //return het waarde in getalen;
        }

        public void BevragenVanFootprint()
        {
            Console.WriteLine($" Uw auto {MerkVanAuto} heeft een FootPrint van : {BerekenFootprint()} cubische meters");
        }

        public void VerlaagFootprint()
        {
            throw new NotImplementedException();
        }
    }
}


