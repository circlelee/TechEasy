using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_MailConfig
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Mailaddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SMTPServer { get; set; }
        public Nullable<int> SMTPPort { get; set; }
        public Nullable<short> SMTPSSL { get; set; }
        public string POPServer { get; set; }
        public Nullable<int> POPPort { get; set; }
        public Nullable<short> POPSSL { get; set; }
        public virtual Accounts_Users Accounts_Users { get; set; }
    }
}
