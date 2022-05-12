using System;
using System.Collections.Generic;
using H8_Polymorfisme.Een_eigen_huis;
using H8_Polymorfisme.Ganzenbord_single_player_edition;
namespace H8_Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {

            //EIGEN HUIS:
            /*
            Huis Deurne = new Huis();
            Deurne.KamersList.Add(new Salon() { SchouwAanwezig = true });
            Deurne.KamersList.Add(new Gang() { Oppervlakte = 1 });
            Deurne.KamersList.Add(new BadKamer());
            Console.WriteLine(Deurne.BerekenPrijs());
            */
            //GANZENBORD:

            
           HondPieza Lumi = new HondPieza();
            Lumi.XS = 2;
            Lumi.YS = 5;
            

            for (int i = 0; i < 20 ; i++)
            {
                if (i > 10)
                {
                    Lumi.Update();
                }
                
            }

            








        }
    }
}
