using System;
using H7_Compositie_en_aggregatie.Politiek;
using H7_Compositie_en_aggregatie.UML_naar_Code_classe;
using System.Collections.Generic;
namespace H7_Compositie_en_aggregatie
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Land Belgie = new Land();
            President Pedro = new President();
            President Sanchez = new President();
            List<Minister> MinisterList = new List<Minister>();
            MinisterList.Add(new Minister() { Naam = "Bruno" });
            MinisterList.Add(new Minister() { Naam = "Freya" });
            MinisterList.Add(new Minister() { Naam = "Peter" });
            MinisterList.Add(new Minister() { Naam = "Ann" });


            Belgie.MaakRegering(Pedro, MinisterList);

            Belgie.MaakRegering(Sanchez, MinisterList);


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Weer een jaar verder");
                Belgie.Jaarverder();
            }



        }
    }
}
