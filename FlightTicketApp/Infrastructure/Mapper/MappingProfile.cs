using AutoMapper;
using Entities;

namespace FlightTicketApp;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<FlightDto, Flight>().ReverseMap();
    }
}
