
using AutoMapper;
using EventFlow.NET.Application.Features.Categories.Queries.GetCategoriesList;
using EventFlow.NET.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using EventFlow.NET.Application.Features.Events.Queries.GetEventDetail;
using EventFlow.NET.Application.Features.Events.Queries.GetEventsList;
using EventFlow.NET.Domain.Entities;

namespace EventFlow.NET.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
