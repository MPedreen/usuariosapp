namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    public class EmailJaCadastradoException : Exception
    {
        public override string Message
            => "O email informado já está cadastrado, tente outro.";
    }
}