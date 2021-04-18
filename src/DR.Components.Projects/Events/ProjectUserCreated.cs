using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Events
{
    public interface ProjectUserCreated : IEvent
    {
        Guid UserId { get; }
        Guid ProjectId { get; }
        string UserEmail { get; }
    }
}
