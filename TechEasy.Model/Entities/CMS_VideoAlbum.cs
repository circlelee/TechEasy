using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_VideoAlbum
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string CoverVideo { get; set; }
        public string Description { get; set; }
        public int CreatedUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> LastUpdateUserID { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public short State { get; set; }
        public int Sequence { get; set; }
        public Nullable<short> Privacy { get; set; }
        public int PvCount { get; set; }
    }
}
