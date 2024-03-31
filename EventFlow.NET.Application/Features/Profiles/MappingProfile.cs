
using AutoMapper;
using EventFlow.NET.Application.Features.Events;
using EventFlow.NET.Application.Features.Events.Queries.GetEventDetail;
using EventFlow.NET.Domain.Entities;

namespace EventFlow.NET.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
