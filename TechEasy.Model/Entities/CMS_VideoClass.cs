using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_VideoClass
    {
        public int VideoClassID { get; set; }
        public string VideoClassName { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int Sequence { get; set; }
        public string Path { get; set; }
        public int Depth { get; set; }
    }
}
