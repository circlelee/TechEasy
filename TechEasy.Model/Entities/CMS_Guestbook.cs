using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_Guestbook
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedUserID { get; set; }
        public int ReplyCount { get; set; }
        public Nullable<int> ParentID { get; set; }
    }
}
