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
        public string Eigenaar { get; set; } = "onbekend";
        public Merk MijnMerk { get; set; }
        public int MyProperty { get; set; }
        public int BerekenFootPrint()
        {
            MyProperty = MijnMerk switch
            {
                Merk.Audi => 45,
                Merk.Toyota => 30,
                Merk.Mercedes => 20,
                Merk.Onbekend => 0,
                _ => throw new NotImplementedException()
            };
            return MyProperty;


        }

        public void FootprintVragen()
        {
            Console.WriteLine($"de {MijnMerk} van {Eigenaar} heeft een footprint van {BerekenFootPrint()}");
        }

        public void VerlaagFootprint()
        {

            //alle auto zullen 5 verlagen
            MyProperty -= 5;
        }
    }
}


