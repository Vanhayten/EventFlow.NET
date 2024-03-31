using AutoMapper;
using EventFlow.NET.Application.Contracts.Persistence;
using EventFlow.NET.Domain.Entities;
using MediatR;

namespace EventFlow.NET.Application.Features.Events
{
    public class GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository) : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository = eventRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
