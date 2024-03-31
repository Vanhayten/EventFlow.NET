using MediatR;

namespace EventFlow.NET.Application.Features.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
