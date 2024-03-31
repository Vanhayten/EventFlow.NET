﻿
using EventFlow.NET.Application.Features.Events.Queries.GetEventDetail;

namespace EventFlow.NET.Application.Features.Events
{
    public class EventDetailVm
    {
        public Guid EventId { get; set; }
        public required string Name { get; set; }
        public DateTime Date {  get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
