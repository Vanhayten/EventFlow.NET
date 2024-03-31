using MediatR;

namespace EventFlow.NET.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {

    }
}
