namespace UsuariosApp.Application.Interfaces.Identities
{
    public interface ITokenCreator
    {
        string Create(string userName, string userRole);
    }
}