using WebApi.Dto;
using WebApi.Extensions;
using WebApi.Models;

namespace WebApiTest
{
    public class Tests
    {

        [Test]
        public void DtoToModelTest()
        {

            SimuladorRequestDto request = new() { ValorInicial = 10000, Prazo = 10 };
            Cdb novaAplicacao = request.DtoToModel();
            Assert.That(novaAplicacao, Is.Not.EqualTo(null));
        }

        [Test]
        public void ModelToDtoTest()
        {
            Cdb cdb = new(10000,10);
            SimuladorResponseDto response = cdb.ModelToDto();
            Assert.That(response, Is.Not.EqualTo(null));
        }

        [Test]
        public void SimuladorRequestDtoTest()
        {
            SimuladorRequestDto simuladorRequestDtoTest = new()
            {
                ValorInicial = 10000,
                Prazo = 10
            };
            Assert.That(simuladorRequestDtoTest, Is.InstanceOf<SimuladorRequestDto>());
        }
        [Test]
        public void SimuladorResponseDtoTest()
        {
            SimuladorResponseDto simuladorResponseDtoTest = new()
            {
                ValorInicial = 10000,
                Prazo = 10,
                RendimentoBruto = 12000,
                RendimentoLiquido = 11500
            };
            Assert.That(simuladorResponseDtoTest, Is.InstanceOf<SimuladorResponseDto>());
        }

        [Test]
        public void AplicacaoTest()
        {
            Aplicacao aplicacao = new(10000,10);
            Assert.That(aplicacao, Is.InstanceOf<Aplicacao>());
        }

        [Test]
        public void AplicacaoCalcularRendimentoTest()
        {
            Aplicacao aplicacao = new(10000, 10);
            aplicacao.CalcularRendimento();
            Assert.That(aplicacao.RendimentoBruto, Is.GreaterThan(0.0));            
        }

        [Test]
        public void AplicacaoArrendondarTest()
        {
            Aplicacao aplicacao = new(10000, 10);
            aplicacao.CalcularRendimento();
            aplicacao.Arrendondar();
            Assert.That(aplicacao.RendimentoLiquido, Is.GreaterThan(0.0));

        }

        [Test]
        public void CdbTest()
        {
            Cdb cdb = new(10000, 10);
            Assert.That(cdb, Is.InstanceOf<Cdb>());
        }


        [Test]
        public void CdbCalcularRendimentoTest()
        {
            Cdb cdb = new(10000, 10);
            cdb.CalcularRendimento();            
            Assert.That(cdb.RendimentoBruto, Is.GreaterThan(0.0));

        }

        [Test]
        public void CdbCalcularArrendondarTest()
        {
            Cdb cdb = new(10000, 10);
            cdb.CalcularRendimento();
            cdb.Arrendondar();
            Assert.That(cdb.RendimentoLiquido, Is.GreaterThan(0.0));

        }

        [Test]
        public void CdbAtributesTest()
        {
            Cdb cdb = new(10000, 10);                        
            Assert.That(cdb.Imposto, Is.Not.EqualTo(null));

        }


        [Test]
        public void ImpostoTest()
        {
            Imposto imposto = new("Imposto Teste");
            Assert.That(imposto, Is.InstanceOf<Imposto>());
        }


        [Test]
        public void IrTest()
        {
            Ir ir = new();
            Assert.That(ir, Is.InstanceOf<Ir>());
        }

        [Test]
        public void ImpostoCalcularImpostoTest()
        {
            Imposto imposto = new("Imposto Teste");
                     
            Assert.That(imposto.CalcularImposto(10000, 10), Is.GreaterThan(0.0));
        }


        [Test]
        public void IrCalcularImpostoTest1()
        {
            Ir ir = new();            
            Assert.That(ir.CalcularImposto(10000, 5), Is.GreaterThan(0.0));
        }

        [Test]
        public void IrCalcularImpostoTest2()
        {
            Ir ir = new();
            Assert.That(ir.CalcularImposto(10000, 10), Is.GreaterThan(0.0));
        }

        [Test]
        public void IrCalcularImpostoTest3()
        {
            Ir ir = new();
            Assert.That(ir.CalcularImposto(10000, 15), Is.GreaterThan(0.0));
        }

        [Test]
        public void IrCalcularImpostoTest4()
        {
            Ir ir = new();
            Assert.That(ir.CalcularImposto(10000, 30), Is.GreaterThan(0.0));
        }






    }
}