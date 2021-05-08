using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Components.Projects.Dto
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string IconColor { get; set; }
        public string IconBackgroundColor { get; set; }
        public short Priority { get; set; }
        public IEnumerable<Guid> UserIds { get; set; }
    }
}
