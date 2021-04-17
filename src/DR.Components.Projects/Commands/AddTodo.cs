using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Todo.Commands
{
    public interface AddTodo
        : ICommand
    {
        Guid Id { get; }
        Guid ProjectId { get; }
        Guid CreatorId { get; }
        string Name { get; }
        string Description { get; }
        Guid? AssignedUserId { get; }
        DateTime? DueDateUtc { get; }
        short Priority { get; }
    }
}
