using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IServiceCdb
    {
        public SimuladorResponseDto SimularCdb(SimuladorRequestDto request);
    }
}
