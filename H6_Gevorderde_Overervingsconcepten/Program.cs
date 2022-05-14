using H6_Gevorderde_Overervingsconcepten.H6_Boek;
using H6_Gevorderde_Overervingsconcepten.H6_Money_Money;
using System;
using H6_Gevorderde_Overervingsconcepten.DierenTuin;
using System.Collections.Generic;

namespace H6_Gevorderde_Overervingsconcepten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            SpaarRekening pedro = new SpaarRekening();
            Boek boek1 = new Boek();
            */
            

            Dier Lumi = new Hond() { Gewicht = 6};
            Dier Juan = new Paard() { Gewicht = 170};
            Dier lola = new Koe() { Gewicht = 300};


            List<Dier> dieren = new List<Dier>();

            dieren.Add(lola);
            dieren.Add(Juan);
            dieren.Add(Lumi);


            foreach (var animal in dieren)
            {
                animal.Zegt();
            }
            

            //gekozen dier laten praten

            Console.WriteLine("welke dier wil je laten praten: [1]Hond, [2]Paard, [3]");
            
        }
    }
}
