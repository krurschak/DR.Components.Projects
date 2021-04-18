using DR.Components.Projects.Types;
using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Events
{
    public interface ProjectCreated : IEvent
    {
        Guid Id { get; }
        Guid CreatorUserId { get; }
        string Name { get; }
        string Description { get; }
        string IconClass { get; }
        string IconColor { get; }
        string IconBackgroundColor { get; }
        short Priority { get; }
        IEnumerable<Tag> Tags { get; }
    }
}
