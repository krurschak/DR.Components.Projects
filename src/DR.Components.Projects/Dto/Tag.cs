using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Components.Projects.Dto
{
    [Serializable]
    public class Tag
    {
        public string Class { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
