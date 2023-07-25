using Microsoft.AspNetCore.Mvc;
using WebApi.Dto;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimuladorController : ControllerBase
    {

        private readonly IServiceCdb _serviceCDB;

        public SimuladorController(IServiceCdb serviceCDB)
        {
            _serviceCDB = serviceCDB;
        }

        [HttpPost]
        public SimuladorResponseDto Simulador(SimuladorRequestDto request)
        {
            return _serviceCDB.SimularCdb(request);
        }
    }
}
