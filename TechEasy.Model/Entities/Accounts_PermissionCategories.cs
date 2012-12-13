using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_PermissionCategories
    {
        public Accounts_PermissionCategories()
        {
            this.Accounts_Permissions = new List<Accounts_Permissions>();
        }

        public int CategoryID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Accounts_Permissions> Accounts_Permissions { get; set; }
    }
}
