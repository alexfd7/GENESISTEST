using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Dto
{    

    [SwaggerSchema(Title = "SimuladorRequest", Description = "Estrutura de dados para solicitar simulação de CDB")]
    public class SimuladorRequestDto
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
    }
}
