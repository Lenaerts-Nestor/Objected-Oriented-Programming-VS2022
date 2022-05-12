using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H8_Polymorfisme.Ganzenbord_single_player_edition
{
    class speelvakje
    {
        public int BeweegVakjes { get; private set; }
        public speelvakje()
        {
            Random RNG = new Random();

            //kleine methode om te kijken welke kans hij heeft en welke nummer hij krijgt
            int waarde()
            {
                //dit is te weten of hij 30% of 20% of 50% kans heeft
                int kans = RNG.Next(1, 11); //random van 1 tot 10;

                //dit is om te weten of we een +1 of +2 moeten doen
                int KansPositief = RNG.NextDouble() switch //random van 0/1
                {
                    0 => +1,
                    1 => +2,
                    _ => throw new NotImplementedException()
                };
                int kansNegatief = RNG.NextDouble() switch  //random van 0/1
                {
                    0 => -1,
                    1 => -2,
                    _ => throw new NotImplementedException()
                };

                int waarde = 0; //deze returneren:
                switch (kans)
                {
                    //30% kans op +1 of +2... [van 1 tot 3 is 30%]
                    case 1:
                    case 2:
                    case 3:
                        waarde = KansPositief;
                        break;
                    //20% kans op -1 of -2
                    case 4:
                    case 5:
                        waarde = kansNegatief;
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        waarde = 0;
                        break;
                    default:
                        break;
                }
                return waarde;

            }

            BeweegVakjes = waarde();

        }

       public virtual void ToonVakje()
        {

        }

    }
}
