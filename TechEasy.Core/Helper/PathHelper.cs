using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Core.IO;

namespace TechEasy.Core.Helper
{
    public class PathHelper
    {
        public static string Map(string relativePath)
        {
            return PathTool.GetInstance().Map(relativePath);
        }
    }
}
