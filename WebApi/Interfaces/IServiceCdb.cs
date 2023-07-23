using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IServiceCdb
    {
        public Cdb SimularCdb(decimal valorInicial, int prazo);
    }
}
