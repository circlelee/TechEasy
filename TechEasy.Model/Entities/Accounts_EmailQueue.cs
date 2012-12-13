using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_EmailQueue
    {
        public System.Guid EmailId { get; set; }
        public int EmailPriority { get; set; }
        public bool IsBodyHtml { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public System.DateTime NextTryTime { get; set; }
        public int NumberOfTries { get; set; }
    }
}
