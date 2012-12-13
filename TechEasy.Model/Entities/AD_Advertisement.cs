using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class AD_Advertisement
    {
        public int AdvertisementId { get; set; }
        public string AdvertisementName { get; set; }
        public Nullable<int> AdvPositionId { get; set; }
        public Nullable<int> ContentType { get; set; }
        public string FileUrl { get; set; }
        public string AlternateText { get; set; }
        public string NavigateUrl { get; set; }
        public string AdvHtml { get; set; }
        public Nullable<int> Impressions { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedUserID { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> DayMaxPV { get; set; }
        public Nullable<int> DayMaxIP { get; set; }
        public Nullable<decimal> CPMPrice { get; set; }
        public Nullable<int> AutoStop { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> EnterpriseID { get; set; }
    }
}
