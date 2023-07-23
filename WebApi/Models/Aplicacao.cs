namespace WebApi.Models
{
    public class Aplicacao
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
        public decimal RendimentoLiquido { get; set; }
        public decimal RendimentoBruto { get; set; }

        private const decimal RENDIMENTO_PADRAO = 0.1M;

        public Aplicacao(decimal valorInicial, int prazo)
        {
            this.ValorInicial = valorInicial;
            this.Prazo = prazo;

        }

        public virtual void CalcularRendimento()
        {
            this.RendimentoBruto = this.ValorInicial * RENDIMENTO_PADRAO;
        }

        public virtual void Arrendondar()
        {
            this.RendimentoLiquido = Math.Round(this.RendimentoLiquido, 2);
            this.RendimentoBruto = Math.Round(this.RendimentoBruto, 2);
            this.ValorInicial = Math.Round(this.ValorInicial, 2);
        }


    }

}
