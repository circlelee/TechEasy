using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_Actions_Permission
    {
        public int ActionID { get; set; }
        public string Description { get; set; }
        public Nullable<int> PermissionID { get; set; }
        public virtual Accounts_Permissions Accounts_Permissions { get; set; }
    }
}
