using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Components.Projects.Dto
{
    [Serializable]
    public class Task
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid CreatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDateUtc { get; set; }
        public short Priority { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
