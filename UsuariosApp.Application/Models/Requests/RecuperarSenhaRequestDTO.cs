using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.Application.Models.Requests
{
    public class RecuperarSenhaRequestDTO
    {
        [EmailAddress(ErrorMessage = "Endereço de email inválido.")]
        [Required(ErrorMessage = "Informe o email.")]
        public string? Email { get; set; }
    }
}