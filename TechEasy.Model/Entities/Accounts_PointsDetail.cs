using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_PointsDetail
    {
        public int PointsDetailID { get; set; }
        public string RuleAction { get; set; }
        public int UserID { get; set; }
        public int Score { get; set; }
        public string ExtData { get; set; }
        public int CurrentPoints { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Type { get; set; }
        public virtual Accounts_PointsRule Accounts_PointsRule { get; set; }
    }
}
