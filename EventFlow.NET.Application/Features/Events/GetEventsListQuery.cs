using MediatR;

namespace EventFlow.NET.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
