using System;
using System.Collections.Generic;
using H8_Polymorfisme.Een_eigen_huis;
using H8_Polymorfisme.DierenTuinadvance;
namespace H8_Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {

            Huis myHuis = new Huis();
            myHuis.Kamers.Add(new Salon() {schouw = true });
           
            myHuis.Kamers.Add(new BadKamer()) ;
            myHuis.Kamers.Add(new Kamer());

            Console.WriteLine(myHuis.BerekenPrijs());


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

            Console.WriteLine("welke dier wil je laten praten: [Hond], [Paard], [Koe]");
            string GekozenDierId = Console.ReadLine();

            switch (GekozenDierId)
            {
                case "Koe":
                    foreach (var item in dieren)
                    {
                        if (item is Koe)
                        {
                            (item as Koe).Zegt();
                        }
                    }
                    break;
                //etc
                default:
                    break;
            }











        }
    }
}
