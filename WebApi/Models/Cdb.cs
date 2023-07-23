namespace WebApi.Models
{
    public class Cdb : Aplicacao
    {
        private const decimal CDI = 0.009M;
        private const decimal TB = 1.08M;
        Ir Imposto { get; set; }

        public Cdb(decimal valor, int prazo) : base(valor, prazo)
        {
            Imposto = new Ir();
        }

        public override void CalcularRendimento()
        {
            decimal rendimentoMensal = this.ValorInicial;

            for (var mes = 1; mes <= this.Prazo; mes++)
            {
                rendimentoMensal = Calculo(rendimentoMensal);
            }

            this.RendimentoBruto = rendimentoMensal;
            this.RendimentoLiquido = this.RendimentoBruto - Imposto.CalcularImposto(this.RendimentoBruto, this.Prazo);

        }

        private static decimal Calculo(decimal vi)
        {

            return vi * (1.0M + (CDI * TB));
        }

    }

}
