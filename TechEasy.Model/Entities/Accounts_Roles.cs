using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_Roles
    {
        public Accounts_Roles()
        {
            this.Accounts_Permissions = new List<Accounts_Permissions>();
            this.Accounts_Users = new List<Accounts_Users>();
        }

        public int RoleID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Accounts_Permissions> Accounts_Permissions { get; set; }
        public virtual ICollection<Accounts_Users> Accounts_Users { get; set; }
    }
}
