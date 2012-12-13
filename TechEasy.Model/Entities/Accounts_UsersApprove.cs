using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_UsersApprove
    {
        public int ApproveID { get; set; }
        public int UserID { get; set; }
        public string TrueName { get; set; }
        public string IDCardNum { get; set; }
        public string FrontView { get; set; }
        public string RearView { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public int Status { get; set; }
        public int ApproveUserID { get; set; }
        public Nullable<int> UserType { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
    }
}
