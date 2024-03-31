using AutoMapper;
using EventFlow.NET.Application.Contracts.Persistence;
using EventFlow.NET.Domain.Entities;
using MediatR;
using System;

namespace EventFlow.NET.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler(IMapper mapper, IAsyncRepository<Event> eventRepository) : IRequestHandler<UpdateEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository = eventRepository;
        private readonly IMapper _mapper = mapper;

        public async Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventRepository.GetByIdAsync(request.EventId);

            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event));

            await _eventRepository.UpdateAsync(eventToUpdate);
        }

    }
}