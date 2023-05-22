using UsuariosApp.Application.Models.Producers;

namespace UsuariosApp.Application.Interfaces.Producers
{
    public interface IUsuarioMessageProducer
    {
        void Send(UsuarioMessageDTO dto);
    }
}
