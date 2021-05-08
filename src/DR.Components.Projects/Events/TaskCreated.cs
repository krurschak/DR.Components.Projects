using DR.Components.Projects.Dto;
using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Events
{
    public interface TaskCreated : IEvent
    {
        Guid Id { get; }
        Guid? ProjectId { get; }
        Guid CreatorUserId { get; }
        Guid AssignedToUserId { get; }
        string State { get; }
        string Name { get; }
        string Description { get; }
        short Priority { get; }
        DateTime DueToUtc { get; }
        Guid DependsOnTaskId { get; }
        IEnumerable<Tag> Tags { get; }
    }
}
