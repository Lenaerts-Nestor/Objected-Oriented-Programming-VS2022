namespace H6_Gevorderde_Overervingsconcepten.H6_Money_Money
{


    public abstract class Rekening
    {

        private double saldo = 0;       //Het saldo van de rekening wordt in een private variabele bijgehouden
        public double Saldo
        {
            get { return saldo = 0; }   //enkel via een read-only property kan uitgelezen worden

        }
        public void VoegGeldToe(double Bedrag)
        {
            saldo += Bedrag;            //het moet van het saldo ToegevoegdWorden *HET PRIVATE PROP*
        }
        public void HaalGeldAf(double Bedrag)
        {
            saldo -= Bedrag;
        }

        public abstract double BerekenRente();


    }
    public class BankRekening : Rekening
    {
        private double RentePercentage = 0.05; //5%

        public override double BerekenRente()
        {
            if (Saldo > 100)
            {
                return Saldo + (Saldo * RentePercentage);
            }
            else
            {
                return Saldo;
            }
        }
    }
    public class SpaarRekening : Rekening
    {
        private double RentePercentage = 0.02; //2%
        public override double BerekenRente()
        {

            return Saldo + (Saldo * RentePercentage);
        }
    }
    public class ProRekening : SpaarRekening
    {

        public override double BerekenRente()
        {

            int aantal1000 = (int)Saldo / 1000; //deze heb ik van Meneer
            return base.BerekenRente() + aantal1000 * 10;

        }
    }


}
