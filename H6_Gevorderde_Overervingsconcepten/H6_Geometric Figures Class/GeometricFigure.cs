namespace H6_Gevorderde_Overervingsconcepten.H6_Geometric_Figures_Class
{
    public abstract class GeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte { get { return BerekenOppervlakte(); } }
        public abstract int BerekenOppervlakte();



    }
    public class Rechthoek : GeometricFigure
    {

        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte;
        }

    }
    public class Vierkant : Rechthoek
    {

        public Vierkant(int HIGH, int THICK)
        {
            if (HIGH != THICK)
            {
                THICK = HIGH;
                Breedte = THICK;
                Hoogte = THICK;
            }
            else
            {
                Breedte = THICK;
                Hoogte = HIGH;
            }

        }
        public Vierkant(int lengte)
        {
            Breedte = lengte;
            Hoogte = lengte;
        }
    }

    public class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte / 2;
        }
    }

}
