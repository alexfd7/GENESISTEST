using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Extensions
{
    public static class CdbExtension
    {
        public static Cdb DtoToModel(this SimuladorRequestDto request)
        {
            return new Cdb(request.ValorInicial, request.Prazo);
        }

        public static SimuladorResponseDto ModelToDto(this Cdb response)
        {
            return new SimuladorResponseDto()
            {
                ValorInicial = response.ValorInicial,
                Prazo = response.Prazo,
                RendimentoBruto = response.RendimentoBruto,
                RendimentoLiquido = response.RendimentoLiquido
            };
        }
    }
}
