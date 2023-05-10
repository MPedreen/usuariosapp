using UsuariosApp.Domain.Models;

namespace UsuariosApp.Domain.Interfaces.Services
{
    public interface IUsuarioDomainService : IDisposable
    {
        void CriarConta(Usuario usuario);
    }
}
