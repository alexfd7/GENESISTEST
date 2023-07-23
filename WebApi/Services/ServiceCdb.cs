using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ServiceCdb : IServiceCdb
    {
        public ServiceCdb() { }

        public Cdb SimularCdb(decimal valorInicial, int prazo)
        {
            Cdb novaAplicacao = new(valorInicial, prazo);

            novaAplicacao.CalcularRendimento();
            novaAplicacao.Arrendondar();

            return novaAplicacao;
        }

    }
}
