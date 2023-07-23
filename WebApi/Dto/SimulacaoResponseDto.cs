using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Dto
{    
    [SwaggerSchema(Title = "SimulacaoResponse", Description = "Estrutura de dados de resposta da simulação de CDB")]
    public class SimulacaoResponseDto
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
        public decimal RendimentoLiquido { get; set; }
        public decimal RendimentoBruto { get; set; }
    }
}
