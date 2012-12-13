using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_PhotoClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string Path { get; set; }
        public Nullable<int> Depth { get; set; }
    }
}
