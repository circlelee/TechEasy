using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_PrototypeStore
    {
        public int PrototypeStoreID { get; set; }
        public string PrototypeStoreName { get; set; }
        public string PrototypeStoreDesc { get; set; }
        public string PrototypeStoreAddress { get; set; }
        public string PrototypeStoreTel { get; set; }
        public int BrandID { get; set; }
        public short State { get; set; }
        public int Orders { get; set; }
    }
}
