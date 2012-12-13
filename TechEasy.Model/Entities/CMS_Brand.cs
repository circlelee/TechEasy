using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class CMS_Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public string BrandDesc { get; set; }
        public int EnterpriseID { get; set; }
        public short State { get; set; }
        public int Orders { get; set; }
    }
}
