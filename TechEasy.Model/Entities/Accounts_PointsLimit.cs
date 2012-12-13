using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_PointsLimit
    {
        public Accounts_PointsLimit()
        {
            this.Accounts_PointsRule = new List<Accounts_PointsRule>();
        }

        public int PointsLimitID { get; set; }
        public string Name { get; set; }
        public int Cycle { get; set; }
        public string CycleUnit { get; set; }
        public int MaxTimes { get; set; }
        public virtual ICollection<Accounts_PointsRule> Accounts_PointsRule { get; set; }
    }
}
