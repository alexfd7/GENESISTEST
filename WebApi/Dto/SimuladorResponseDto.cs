using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Dto
{    
    [SwaggerSchema(Title = "SimuladorResponse", Description = "Estrutura de dados de resposta da simulação de CDB")]
    public class SimuladorResponseDto
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
        public decimal RendimentoLiquido { get; set; }
        public decimal RendimentoBruto { get; set; }
        public string? Mensagem { get; set; }
    }
}
