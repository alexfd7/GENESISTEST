using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Dto
{    

    [SwaggerSchema(Title = "SimulacaoRequest", Description = "Estrutura de dados para solicitar simulação de CDB")]
    public class SimulacaoRequestDto
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
    }
}
