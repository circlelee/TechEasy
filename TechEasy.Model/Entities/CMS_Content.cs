using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_Content
    {
        public int ContentID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbImageUrl { get; set; }
        public string NormalImageUrl { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedUserID { get; set; }
        public Nullable<int> LastEditUserID { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public string LinkUrl { get; set; }
        public int PvCount { get; set; }
        public short State { get; set; }
        public int ClassID { get; set; }
        public string Keywords { get; set; }
        public int Sequence { get; set; }
        public bool IsRecomend { get; set; }
        public bool IsHot { get; set; }
        public bool IsColor { get; set; }
        public bool IsTop { get; set; }
        public string Attachment { get; set; }
        public string Remary { get; set; }
        public int TotalComment { get; set; }
        public int TotalSupport { get; set; }
        public int TotalFav { get; set; }
        public int TotalShare { get; set; }
        public string BeFrom { get; set; }
    }
}
