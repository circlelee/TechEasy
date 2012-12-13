using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_UserRank
    {
        public int RankId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Point { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAgentRank { get; set; }
        public Nullable<int> NumberOfMemberRanks { get; set; }
        public bool IsMemberCreated { get; set; }
        public Nullable<int> CreatorUserId { get; set; }
        public string PriceType { get; set; }
        public string PriceOperations { get; set; }
        public decimal PriceValue { get; set; }
    }
}
