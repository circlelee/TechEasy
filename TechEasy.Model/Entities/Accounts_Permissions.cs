using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_Permissions
    {
        public Accounts_Permissions()
        {
            this.Accounts_Actions_Permission = new List<Accounts_Actions_Permission>();
            this.Accounts_Roles = new List<Accounts_Roles>();
        }

        public int PermissionID { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public virtual ICollection<Accounts_Actions_Permission> Accounts_Actions_Permission { get; set; }
        public virtual Accounts_PermissionCategories Accounts_PermissionCategories { get; set; }
        public virtual ICollection<Accounts_Roles> Accounts_Roles { get; set; }
    }
}
