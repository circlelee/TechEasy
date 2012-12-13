using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TechEasy.Core.Helper
{
    public class FileHelper
    {
        public static string Read(String absolutePath)
        {
            return Read(absolutePath, Encoding.UTF8);
        }

        public static string Read(string absolutePath, Encoding encoding)
        {
            using (StreamReader reader = new StreamReader(absolutePath, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
