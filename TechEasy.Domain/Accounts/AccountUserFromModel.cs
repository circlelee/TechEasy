using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.Domain.Accounts
{
    public class AccountUserFromModel
    {
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
    }
}
