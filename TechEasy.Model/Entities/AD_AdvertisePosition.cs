using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class AD_AdvertisePosition
    {
        public int AdvPositionId { get; set; }
        public string AdvPositionName { get; set; }
        public Nullable<int> ShowType { get; set; }
        public Nullable<int> RepeatColumns { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string AdvHtml { get; set; }
        public Nullable<bool> IsOne { get; set; }
        public Nullable<int> TimeInterval { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedUserID { get; set; }
    }
}
