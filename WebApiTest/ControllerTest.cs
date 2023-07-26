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
            var result = controller.Simulador(new SimuladorRequestDto { ValorInicial = 1000, Prazo = 10 });            
            Assert.That(result, Is.EqualTo(null));

        }

        [Test]
        public void SimuladorValorInicialZerado()
        {

            var controller = new SimuladorController(_serviceCDB.Object);
            var result = controller.Simulador(new SimuladorRequestDto { ValorInicial = 0, Prazo = 10 }) as SimuladorResponseDto;
            Assert.That(result.Mensagem, Is.EqualTo("Atenção! O Prazo inserido deve ser maior ou igual a 2"));

        }

        [Test]
        public void SimuladorPrazoZerado()
        {

            var controller = new SimuladorController(_serviceCDB.Object);
            var result = controller.Simulador(new SimuladorRequestDto { ValorInicial = 1000, Prazo = 0 }) as SimuladorResponseDto;
            Assert.That(result.Mensagem, Is.EqualTo("Atneção! O Valor Inicial deve ser maior que 0"));

        }

    }
}
