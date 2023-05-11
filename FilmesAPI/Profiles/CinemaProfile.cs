using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(dto => dto.ReadEnderecoDto, opt => opt.MapFrom(c => c.Endereco));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
