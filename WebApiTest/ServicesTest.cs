using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Dto;
using WebApi.Interfaces;
using WebApi.Services;

namespace WebApiTest
{
    public class ServicesTest
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
            var service = new ServiceCdb();
            var result = _serviceCDB.Object.SimularCdb(new SimuladorRequestDto { ValorInicial = 1000, Prazo = 10 });
            

        }
    }
}
