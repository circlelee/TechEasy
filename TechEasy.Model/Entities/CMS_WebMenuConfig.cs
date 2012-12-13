using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_WebMenuConfig
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public string NavURL { get; set; }
        public string MenuTitle { get; set; }
        public Nullable<int> MenuType { get; set; }
        public Nullable<int> Target { get; set; }
        public Nullable<bool> IsUsed { get; set; }
        public int Sequence { get; set; }
        public int Visible { get; set; }
    }
}
