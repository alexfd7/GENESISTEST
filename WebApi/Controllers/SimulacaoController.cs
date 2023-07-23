using Microsoft.AspNetCore.Mvc;
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
        public Cdb Simulacao(decimal valorInicial, int prazo)
        {
            return _serviceCDB.SimularCdb(valorInicial, prazo);
        }
    }
}
