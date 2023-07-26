using WebApi.Dto;
using WebApi.Extensions;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ServiceCdb : IServiceCdb
    {
        public ServiceCdb() { }

        public SimuladorResponseDto SimularCdb(SimuladorRequestDto request)
        {

            if (request.Prazo < 1)
            {
                return new SimuladorResponseDto { mensagem = "Atenção! O Prazo inserido deve ser maior ou igual a 1 " };
            }

            if (request.ValorInicial <= 0)
            {
                return new SimuladorResponseDto { mensagem = "Atneção! O Valor Inicial deve ser maior que 0" };
            }

            Cdb novaAplicacao = request.DtoToModel();

            novaAplicacao.CalcularRendimento();
            novaAplicacao.Arrendondar();

            return novaAplicacao.ModelToDto();
        }

    }
}
