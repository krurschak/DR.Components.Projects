using DR.Components.Projects.Dto;
using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Projects.Commands
{
    public interface CreateProject : ICommand
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

        IEnumerable<string> AddedUserEmails { get; }
    }
}
