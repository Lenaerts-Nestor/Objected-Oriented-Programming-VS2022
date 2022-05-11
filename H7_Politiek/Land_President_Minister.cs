using System;
using System.Collections.Generic;

namespace H7_Politiek
{
    public class Land
    {

        //compositieobjecten zijn private
        private Minister EersteMinister;
        private President President;
        private List<Minister> MinisitersLijst = new List<Minister>(4);      //de lengte is 4

        //Methodes: 
        public void MaakRegering(President ElPresidente, List<Minister> ListMinisters)
        {
            ///Deze methode zal enkel iets doen indien er geen president in het land is (null). 
            ///Indien er reeds een regering is dan zal er een foutboodschap verschijnen.


            //eerst gaan we controleren als er al een president is in het Land;
            if (ElPresidente == null)
            {
                //als er geen president bestaat in het land ==>

                President = ElPresidente;
                //hier boven zie je dat het refereert naar de propetie President, Visual studio begrijpt dat je bedoelt die propertie aangezien de situatie.
                //je kan ook this.President doen en het geeft zelfde resultaat.
                EersteMinister = ListMinisters[0]; //we doen dit omdat we pakken de eerste Minister die in listMinister staat en plaatste we in het private variabele EersteMinister


                ///De overige ministers in de lijst worden aan de private lijst van ministers toegewezen.
                ///We gebruiken een loop om het automatische te voegen tot het lijst voll is.
                for (int i = 0; i < ListMinisters.Count; i++) //we gebruiken count. niet Length
                {
                    //we voegen het toe aan het private list van daarnet
                    MinisitersLijst.Add(ListMinisters[i]);  //we voegen de ministers in ListMinisters (die we hadden gegeven in program.cs) en voegen we toe aan de private MinisterLijst toe.
                }

            }
            else
            {
                //als er well een president bestaat in het land ==>
                Console.WriteLine("er bestaad al een president.");
            }

        }

        public void JaarVerder()
        {
            if (President != null)
            {
                ///Hierboven zie je dat het President Wit verschijn het systeem weet dat we refereeren naar een object, je kan this.President gebruiken voor zelf duidelijkhijd.


                if (President.Teller <= 0) //dus als teller op 0 staat of kleiner [je kan ook gewoon < 1 ] doen om gewoon te zeggen als het null is of deronder.
                {
                    ///UITLEG: hierboven bij IF zie je dat we refereeren naar de President classe
                    ///want het object staat in private dus we kijken gewoon direct naar de classe Teller inzicht.

                    President = null; //refereert naar het private property
                    EersteMinister = null; //zelfde
                    MinisitersLijst.Clear(); //dit is om alles binnen het lijst te verwijderen.



                }

                ///Deze methode controleert ook of de Teller van de president na deze aanroep op 0 staat. 
                ///Als dat het geval is dan worden alle ministers en president in het land op null gezet.


            }

        }

    }
    public class Minister
    {
        public string Naam { get; set; }
    }
    public class President : Minister
    {
        public int Teller { get; private set; } = 4; //die start op 4

        public void JaarVerder()
        {
            Teller--; //dit is zoals teller - 1;
        }

    }
}
