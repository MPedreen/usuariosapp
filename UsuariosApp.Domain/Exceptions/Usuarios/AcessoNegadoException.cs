namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    public class AcessoNegadoException : Exception
    {
        public override string Message
            => "Acesso negado. Usuário inválido.";
    }
}