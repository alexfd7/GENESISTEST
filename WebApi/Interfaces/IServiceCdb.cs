using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IServiceCdb
    {
        public SimulacaoResponseDto SimularCdb(SimulacaoRequestDto request);
    }
}
