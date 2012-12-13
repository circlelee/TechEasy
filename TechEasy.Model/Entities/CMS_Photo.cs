using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_Photo
    {
        public int PhotoID { get; set; }
        public string PhotoName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int AlbumID { get; set; }
        public short State { get; set; }
        public int CreatedUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int PVCount { get; set; }
        public int ClassID { get; set; }
        public string ThumbImageUrl { get; set; }
        public string NormalImageUrl { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<bool> IsRecomend { get; set; }
        public Nullable<int> CommentCount { get; set; }
        public string Tags { get; set; }
    }
}
