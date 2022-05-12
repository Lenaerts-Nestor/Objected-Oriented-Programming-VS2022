using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H8_Polymorfisme.Ganzenbord_single_player_edition
{
    class Dobbelsteen
    {
        public static int Roll()
        {
            Random RNG = new Random();
            return RNG.Next(1,4);  //random nummer tussen 1 tot 3;
        }
    }
}
