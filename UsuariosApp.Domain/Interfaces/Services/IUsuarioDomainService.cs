using UsuariosApp.Domain.Models;

namespace UsuariosApp.Domain.Interfaces.Services
{
    public interface IUsuarioDomainService : IDisposable
    {
        Usuario Autenticar(string email, string senha);
        void CriarConta(Usuario usuario);
        Usuario RecuperarSenha(string email);
    }
}