namespace H6_Gevorderde_Overervingsconcepten.H6_Boek
{
    public class Boek
    {
        public long ISBN { get; set; }
        public string Title { get; set; }

        public string Auteur { get; set; }

        private double prijs;

        public virtual double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        public override string ToString()
        {
            return $"{Title}{Auteur}({ISBN}) {Prijs}";
        }
        public static Boek TelOp(Boek obj1, Boek obj2)
        {
            Boek newboek = new Boek();
            newboek.Auteur = obj1.Auteur + "," + obj2.Auteur;
            newboek.prijs = (obj1.prijs + obj2.prijs) / 2;
            newboek.Title = $"Omnibus van {newboek.Auteur}. prijs: {newboek.prijs}. \n";



            return newboek;
        }


    }
    public class TextBoek : Boek
    {
        public int GradeLevel { get; set; }
        public override double Prijs
        {
            get { return base.Prijs; }
            set
            {
                if (value > 19 && value <= 80) //hier moet het value >= 20 maar ik krijg een error dus ik doe gewoon > 19 dus het begin pas vanaf 20    
                {
                    base.Prijs = value;
                }
            }
        }
    }
    public class KoffietafelBoek : Boek
    {

        public override double Prijs
        {
            get { return base.Prijs; }
            set
            {
                if (value > 34 && value <= 100) // zelfde situatie hier
                {
                    base.Prijs = value;
                }
            }
        }
    }
}
