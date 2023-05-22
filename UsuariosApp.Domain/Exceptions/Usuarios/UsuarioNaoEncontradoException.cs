namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    public class UsuarioNaoEncontradoException : Exception
    {
        public override string Message
            => "Usuário não encontrado.";
    }
}