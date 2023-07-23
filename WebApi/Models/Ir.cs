namespace WebApi.Models
{
    public class Ir : Imposto
    {
        public Ir() : base("IR")
        {
        }

        public override decimal CalcularImposto(decimal valor, int prazo)
        {
            decimal percentual = 0.0M;
            if (prazo <= 6)
            {
                percentual = 0.225M;
            }
            else if (prazo > 6 && prazo <= 12)
            {
                percentual = 0.20M;
            }
            else if (prazo > 12 && prazo <= 24)
            {
                percentual = 0.175M;
            }
            else if (prazo > 24)
            {
                percentual = 0.15M;
            }

            return percentual * valor;
        }
    }


}
