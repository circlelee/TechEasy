using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_FLinks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string LinkUrl { get; set; }
        public string LinkDesc { get; set; }
        public short State { get; set; }
        public int OrderID { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string TelPhone { get; set; }
        public short TypeID { get; set; }
    }
}
