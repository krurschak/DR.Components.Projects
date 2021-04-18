using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Events
{
    public interface ProjectUserAdded : IEvent
    {
        Guid UserId { get; }
        Guid ProjectId { get; }
        string UserEmail { get; }
        public short Priority { get; set; }
    }
}
