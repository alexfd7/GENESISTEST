using Microsoft.AspNetCore.Mvc;
using WebApi.Dto;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimulacaoController : ControllerBase
    {

        private readonly IServiceCdb _serviceCDB;

        public SimulacaoController(IServiceCdb serviceCDB)
        {
            _serviceCDB = serviceCDB;
        }

        [HttpPost]
        public SimulacaoResponseDto Simulacao(SimulacaoRequestDto request)
        {
            return _serviceCDB.SimularCdb(request);
        }
    }
}
