using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Extensions
{
    public static class CdbExtension
    {
        public static Cdb DtoToModel(this SimulacaoRequestDto request)
        {
            return new Cdb(request.ValorInicial, request.Prazo);
        }

        public static SimulacaoResponseDto ModelToDto(this Cdb response)
        {
            return new SimulacaoResponseDto()
            {
                ValorInicial = response.ValorInicial,
                Prazo = response.Prazo,
                RendimentoBruto = response.RendimentoBruto,
                RendimentoLiquido = response.RendimentoLiquido
            };
        }
    }
}
