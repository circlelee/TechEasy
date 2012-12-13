using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_PhotoAlbum
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string Description { get; set; }
        public Nullable<int> CoverPhoto { get; set; }
        public short State { get; set; }
        public int CreatedUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int PVCount { get; set; }
        public int Sequence { get; set; }
        public short Privacy { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
