using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TechEasy.Core.Helper;

namespace TechEasy.Core.IO
{
    internal class WindowsPath:PathTool
    {
        public override String CombineAbs(String[] arrPath)
        {

            if (arrPath.Length == 0) return "";

            String result = arrPath[0];
            for (int i = 1; i < arrPath.Length; i++)
            {
                if (StringHelper.IsNullOrEmpty(arrPath[i])) continue;
                result = StringHelper.Join(result, arrPath[i].Replace("/", "\\"), "\\");
            }
            return result;

        }

        public override String Map(String path)
        {
            bool isWeb = HttpContext.Current != null;
            if (StringHelper.IsNullOrEmpty(path)) return "";

            if (!isWeb)
            {
                return StringHelper.Join(AppDomain.CurrentDomain.BaseDirectory, path.Replace("/", "\\"), "\\");
            }
            else
            {
                string applicationPath = HttpContext.Current.Request.ApplicationPath;
                String str = path;
                if (path.ToLower().StartsWith(applicationPath) == false)
                    str = StringHelper.Join(applicationPath, path);

                return HttpContext.Current.Server.MapPath(str);
            }
        }
    }
}
