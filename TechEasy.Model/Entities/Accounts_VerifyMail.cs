using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_VerifyMail
    {
        public string UserName { get; set; }
        public string KeyValue { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public Nullable<int> ValidityType { get; set; }
    }
}
