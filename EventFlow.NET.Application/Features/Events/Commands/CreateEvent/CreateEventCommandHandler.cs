using AutoMapper;
using EventFlow.NET.Application.Contracts.Persistence;
using EventFlow.NET.Domain.Entities;
using MediatR;

namespace EventFlow.NET.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository) : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository = eventRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);

            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request, cancellationToken);
            if (validationResult.Errors.Count > 0) throw new Exceptions.ValidationException(validationResult);

            @event = await _eventRepository.AddAsync(@event);

            return @event.EventId;
        }
    }
}