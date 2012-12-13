using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_PointsRule
    {
        public Accounts_PointsRule()
        {
            this.Accounts_PointsDetail = new List<Accounts_PointsDetail>();
        }

        public string RuleAction { get; set; }
        public int PointsLimitID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Accounts_PointsDetail> Accounts_PointsDetail { get; set; }
        public virtual Accounts_PointsLimit Accounts_PointsLimit { get; set; }
    }
}
