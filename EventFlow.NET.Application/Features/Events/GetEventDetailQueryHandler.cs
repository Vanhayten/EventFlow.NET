
using AutoMapper;
using EventFlow.NET.Application.Contracts.Persistence;
using EventFlow.NET.Application.Features.Events.Queries.GetEventDetail;
using EventFlow.NET.Domain.Entities;
using MediatR;

namespace EventFlow.NET.Application.Features.Events
{
    public class GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryRepository) : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {

        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);

            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);

            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
