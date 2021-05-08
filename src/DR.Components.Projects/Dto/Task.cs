using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Components.Projects.Dto
{
    [Serializable]
    public class TaskListItem
    {
        public Guid Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid CreatorUserId { get; set; }
        public Guid AssignedToUserId { get; set; }
        public string Name { get; set; }
        public DateTime DueDateUtc { get; set; }
        public short Priority { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
