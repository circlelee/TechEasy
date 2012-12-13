using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TechEasy.Core.IO
{
    public abstract class PathTool
    {
        public abstract String CombineAbs(String[] arrPath);
        public abstract String Map(String path);

        public static PathTool GetInstance()
        {
            return new WindowsPath();
        }

        public static String GetBinDirectory()
        {
            bool isweb = HttpContext.Current != null;
            if (isweb)
            {
                return HttpRuntime.BinDirectory;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
