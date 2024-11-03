using ClimaSprint2.Domain.Entities;

namespace ClimaSprint2.Domain.Interfaces
{
    public interface IClimaService
    {
        Task<Endereco?> ObterEnderecoPorCepAsync(string cep);
    }
}
