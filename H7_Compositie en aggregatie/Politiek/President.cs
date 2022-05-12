using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_Compositie_en_aggregatie.Politiek
{
    class President
    {
        public int Teller { get; private set; } = 4; //die start op 4

        public void JaarVerder()
        {
            Teller--; //dit is zoals teller - 1;
        }
    }
}
