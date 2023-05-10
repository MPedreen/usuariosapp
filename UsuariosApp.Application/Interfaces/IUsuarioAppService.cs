using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;

namespace UsuariosApp.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        AutenticarResponseDTO Autenticar(AutenticarRequestDTO dto);
        CriarContaResponseDTO CriarConta(CriarContaRequestDTO dto);
    }
}
