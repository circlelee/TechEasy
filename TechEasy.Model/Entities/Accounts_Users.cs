using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_Users
    {
        public Accounts_Users()
        {
            this.Accounts_MailConfig = new List<Accounts_MailConfig>();
            this.SA_TreeFavorite = new List<SA_TreeFavorite>();
            this.Accounts_Roles = new List<Accounts_Roles>();
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string NickName { get; set; }
        public string TrueName { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string DepartmentID { get; set; }
        public Nullable<bool> Activity { get; set; }
        public string UserType { get; set; }
        public Nullable<int> Style { get; set; }
        public Nullable<int> User_iCreator { get; set; }
        public Nullable<System.DateTime> User_dateCreate { get; set; }
        public Nullable<System.DateTime> User_dateValid { get; set; }
        public Nullable<System.DateTime> User_dateExpire { get; set; }
        public Nullable<int> User_iApprover { get; set; }
        public Nullable<System.DateTime> User_dateApprove { get; set; }
        public Nullable<int> User_iApproveState { get; set; }
        public string User_cLang { get; set; }
        public virtual ICollection<Accounts_MailConfig> Accounts_MailConfig { get; set; }
        public virtual ICollection<SA_TreeFavorite> SA_TreeFavorite { get; set; }
        public virtual ICollection<Accounts_Roles> Accounts_Roles { get; set; }
    }
}
