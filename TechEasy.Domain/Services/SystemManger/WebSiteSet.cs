using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.Domain.Services.SystemManger
{
    public class WebSiteSet
    {
        private ApplicationKeyType applicationKeyType;
        public const string BASE_HOST = "BaseHost";
        public const string KEY_PAGEFOOTJS = "PageFootJs";
        public const string KEY_WORDS = "Keywords";
        public const string LOGO_PATH = "LogoPath";
        public const string WEB_DESCRIPTION = "Description";
        public const string WEB_NAME = "WebName";
        public const string WEB_POWERBY = "WebPowerBy";
        public const string WEB_RECORD = "WebRecord";
        public const string WEB_TITLE = "Title";

        public WebSiteSet(ApplicationKeyType key)
        {
            this.applicationKeyType = key;
        }

        public string BaseHost { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string LogoPath { get; set; }
        public string PageFootJs { get; set; }
        public string WebName { get; set; }
        public string WebPowerBy { get; set; }
        public string WebRecord { get; set; }
        public string WebTitle { get; set; }



    }
}
