using MediatR.Library.Entity;

namespace Sample.API.Mappers;

public class PersonMapperProfile : Profile
{
    public PersonMapperProfile()
    {
        CreateMap<PersonEntity, CreatePersonCommand>().ReverseMap();
    }
}