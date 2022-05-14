using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_Compositie_en_aggregatie.Politiek
{
    class Land
    {
        private President ElPresidente { get; set; }
        private List<Minister> MinisterList = new List<Minister>(4); //max 4 Ministers
        private Minister EersteMinister { get; set; }


        public void MaakRegering(President president, List<Minister> listministers)
        {

            if (ElPresidente == null)
            {
                ElPresidente = president;
                //iets
                EersteMinister = listministers[0];
                for (int i = 1; i < listministers.Count-1; i++)
                {
                    MinisterList.Add(listministers[i]);
                }

            }
            else
            {
                //foutboodschap
                Console.WriteLine($"foutbootschap");
            }
        }
        public void Jaarverder()
        {
            if (ElPresidente != null && ElPresidente.Teller > 0)
            {
                ElPresidente.JaarVerder();
            }
            else
            {
                ElPresidente=null;
                MinisterList.Clear();
                EersteMinister=null;


                Console.WriteLine("Regering Over");

            }
        }



    }
}
