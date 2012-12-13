using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_Comment
    {
        public int ID { get; set; }
        public Nullable<int> ContentId { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedUserID { get; set; }
        public int ReplyCount { get; set; }
        public int ParentID { get; set; }
        public short TypeID { get; set; }
        public bool State { get; set; }
        public bool IsRead { get; set; }
    }
}
