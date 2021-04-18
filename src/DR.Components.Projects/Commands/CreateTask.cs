using DR.Components.Projects.Types;
using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Commands
{
    public interface CreateTask : ICommand
    {
        Guid Id { get; }
        Guid? ProjectId { get; }
        Guid CreatorUserId { get; }
        string State { get; }
        string Name { get; }
        string Description { get; }
        Guid? AssignedToUserId { get; }
        DateTime? DueDateUtc { get; }
        short Priority { get; }
        Guid DependsOnTaskId { get; set; }
        IEnumerable<Tag> Tags { get; }
    }
}
