using ClimaSprint2.Domain.Entities;
using ClimaSprint2.Domain.Interfaces.Dtos;

namespace ClimaSprint2.Domain.Interfaces
{
    public interface IClimaApplicationService
    {
        IEnumerable<ClimaEntity> ObterTodosClimas();
        ClimaEntity ObterClimaPorId(int id);
        ClimaEntity AdicionarClima(IClimaDto dto);
        ClimaEntity EditarClima(int id, IClimaDto dto);
        ClimaEntity RemoverClima(int id);
        Task<Endereco?> ObterEnderecoPorCepAsync(string cep);
    }
}
