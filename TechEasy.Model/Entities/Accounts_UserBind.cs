using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_UserBind
    {
        public int BindId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public int MediaUserID { get; set; }
        public string MediaNickName { get; set; }
        public int MediaID { get; set; }
        public Nullable<bool> iHome { get; set; }
        public Nullable<bool> Comment { get; set; }
        public Nullable<bool> GroupTopic { get; set; }
    }
}
