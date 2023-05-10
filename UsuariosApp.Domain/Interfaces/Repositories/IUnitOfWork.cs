namespace UsuariosApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository? UsuarioRepository { get; }
        void SaveChanges();
    }
}