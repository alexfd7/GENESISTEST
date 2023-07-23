namespace WebApi.Models
{
    public class Imposto
    {
        public string Nome { get; set; }

        private const decimal ALIQUOTA_PADRAO = 0.1M;

        public Imposto(string nome)
        {
            this.Nome = nome;
        }

        public virtual decimal CalcularImposto(decimal valor, int prazo)
        {
            return valor * ALIQUOTA_PADRAO;
        }
    }
}
