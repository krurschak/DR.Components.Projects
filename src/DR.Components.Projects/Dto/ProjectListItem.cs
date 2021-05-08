using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Components.Projects.Dto
{
    [Serializable]
    public class ProjectListItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        public string IconColor { get; set; }
        public string IconBackgroundColor { get; set; }
        public short Priority { get; set; }
    }
}
