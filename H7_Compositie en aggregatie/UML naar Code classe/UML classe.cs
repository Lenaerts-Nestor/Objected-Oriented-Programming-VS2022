using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H7_Compositie_en_aggregatie.UML_naar_Code_classe
{
    //Compositsie:
    class Persoon
    {
        private Hand Hand = new Hand();
        private Head Head = new Head();
        private Leg Leg = new Leg();
    }
    class Head{ }
    class Hand{ }
    class Leg { }

    
    //Agregatie:

    public class Car
    {
        private List<Wheel> Wheels = new List<Wheel>(4);
        private Engine Engine1 { get; set; }
        
        public Car()
        {
            for (int i = 0; i < Wheels.Count; i++)
            {
                Wheels.Add(new Wheel());
            }
        }
    
    
    }
    public class Wheel{}
    public class Engine
    {
        private Crankshaft eenCrankShaft { get; set; }
        private List<Piston> pistonList { get; set; } = new List<Piston>(4); //we zullen 4 zeggen
    
    }

    public class Crankshaft { }
    public class Piston { }




}
