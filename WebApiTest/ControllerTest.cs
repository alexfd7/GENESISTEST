using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Dto;
using WebApi.Interfaces;

namespace WebApiTest
{
    public class ControllerTest
    {

        private Mock<IServiceCdb> _serviceCDB;

        [SetUp]
        public void SetUp()
        {
            _serviceCDB = new Mock<IServiceCdb>();
        }

        [Test]
        public void SimuladorController()
        {
                        
            var controller = new SimuladorController(_serviceCDB.Object);
            var result = controller.Simulador(new SimuladorRequestDto { ValorInicial = 1000, Prazo = 10 }) as SimuladorResponseDto;

        }

    }
}
