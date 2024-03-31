
namespace EventFlow.NET.Application.Features.Events
{
    public class EventListVm
    {
        public Guid EventId { get; set; }
        public required string Name { get; set; }
        public DateTime Date {  get; set; }
        public string? ImageUrl { get; set; }

    }
}
