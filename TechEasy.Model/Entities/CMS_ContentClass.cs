using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_ContentClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassIndex { get; set; }
        public int Sequence { get; set; }
        public Nullable<int> ParentId { get; set; }
        public short State { get; set; }
        public bool AllowSubclass { get; set; }
        public bool AllowAddContent { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public int ClassTypeID { get; set; }
        public short ClassModel { get; set; }
        public string PageModelName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedUserID { get; set; }
        public string Path { get; set; }
        public Nullable<int> Depth { get; set; }
        public string Remark { get; set; }
    }
}
