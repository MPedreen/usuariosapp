using AutoMapper;
using UsuariosApp.Application.Models.Responses;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Profiles
{
    public class DomainModelToDTOProfile : Profile
    {
        public DomainModelToDTOProfile()
        {
            CreateMap<Usuario, CriarContaResponseDTO>();
            CreateMap<Usuario, AutenticarResponseDTO>();
            CreateMap<Usuario, RecuperarSenhaResponseDTO>();
        }
    }
}