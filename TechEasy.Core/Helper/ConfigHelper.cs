using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Configuration;
using TechEasy.Core.Common;

namespace TechEasy.Core.Helper
{
    public class ConfigHelper
    {
        private static readonly char defaultSeparator = ':';

        private static string ConfigRoot = GetConfigRoot();

        public static string AppConfigPath = GetAppConfigPath();

        private char separator = defaultSeparator;

        private static Object objLock = new object();

        private static string GetConfigRoot()
        {
            string root = GetAppSettings("configroot");
            if (StringHelper.IsNullOrEmpty(root)) return "/ConfigRoot/";
            return root.EndsWith("/") ? root : root + "/";
        }

        public static string GetAppConfigPath()
        {
            string config = GetAppSettings("SpiderConfig");
            return GetAppConfigPath(config);
        }

        public static string GetAppConfigPath(string config)
        {
            if (StringHelper.IsNullOrEmpty(config))
                return PathHelper.Map(StringHelper.Join(ConfigRoot, "Spider.config"));
            else
                return PathHelper.Map(StringHelper.Join(ConfigRoot, config));
        }

        public static string GetAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string ReadToFile(string absolutePath)
        {
            return ReadToFile(absolutePath, Encoding.UTF8);
        }

        public static string ReadToFile(string absolutePath, Encoding encoding)
        {
            using (StreamReader reader = new StreamReader(absolutePath, encoding))
            {
                return reader.ReadToEnd();
            }
        }

        public static Dictionary<string, string> Read(string absPath)
        {
            return Read(absPath, defaultSeparator);
        }

        public static Dictionary<string, string> Read(string absPath, char separator)
        {
            if (StringHelper.IsNullOrEmpty(absPath))
                throw new IOException("config path is empty");
            ConfigHelper cfg = new ConfigHelper();
            try
            {
                cfg.Content = FileHelper.Read(absPath);
            }
            catch (IOException)
            {
                cfg.Content = "";
            }
            return cfg.ToConfigDic(separator);

        }

        public static void WriteWithLock(string absolutePath, string fileContent)
        {
            lock (objLock)
            {
                Write(absolutePath, fileContent, Encoding.UTF8);
            }
        }

        public static void Write(string absolutePath, string fileContent)
        {
            Write(absolutePath, fileContent, Encoding.UTF8);
        }

        public static void Write(string absolutePath, string fileContent, Encoding encoding)
        {
            using (StreamWriter writer = new StreamWriter(absolutePath, false, encoding))
            {
                writer.Write(fileContent);
            }
        }

        public static String[] ReadAllLines(String absolutePath)
        {
            return ReadAllLines(absolutePath, Encoding.UTF8);
        }

        public static String[] ReadAllLines(string absolutePath, Encoding encoding)
        {
            ArrayList list = new ArrayList();
            using (StreamReader reader = new StreamReader(absolutePath, encoding))
            {
                String str;
                while ((str = reader.ReadLine()) != null)
                {
                    list.Add(str);
                }
            }
            return (String[])list.ToArray(typeof(String));
        }

        private Dictionary<String, String> configdictionary;
        public Dictionary<string, string> ConfigDictionary
        {
            get
            {
                if (configdictionary == null && StringHelper.HasText(Content))
                    ToConfigDic(GetSeparator());
                return configdictionary;
            }
            set { configdictionary = value; }

        }

        public Dictionary<string, string> ToConfigDic(char separator)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] arrLine = Content.Split(new char[] { '\n', '\r' });
            foreach (var item in arrLine)
            {
                if (StringHelper.IsNullOrEmpty(item)) continue;
                if (item.StartsWith("//") || item.StartsWith("#")) continue;

                string[] arrPair = item.Split(new char[] { separator }, 2);
                if (arrPair.Length < 2) continue;
                char[] arrTrim = new char[] { '"', '\'' };

                string itemKey = arrPair[0].Trim().TrimStart(arrTrim).TrimEnd(arrTrim).Trim();
                string itemValue = arrPair[1].Trim().TrimStart(arrTrim).TrimEnd(arrTrim).Trim();
                result[itemKey] = itemValue;
            }
            configdictionary = result;
            return result;
        }

        public void ToConfigString()
        {
            StringBuilder sb = new StringBuilder();

            char s = GetSeparator();
            foreach (KeyValuePair<String, String> pair in this.ConfigDictionary)
            {
                sb.Append(pair.Key);
                sb.Append(" ");
                sb.Append(s);
                sb.Append(" ");
                sb.Append(pair.Value);
                sb.Append(Environment.NewLine);
            }

            content = sb.ToString();
        }

        private string content;

        public string Content
        {
            get
            {
                if (configdictionary != null && content == null)
                    ToConfigString();
                return content;
            }
            set
            {
                content = value;
            }
        }

        private char GetSeparator()
        {
            return separator;
        }

        public void SetSeparator(char separator)
        {
            this.separator = separator;
        }

        public static int GetConfigInt(string key)
        {
            int num = 0;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    num = int.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return num;
        }

        public static string GetConfigString(string key)
        {
            string cacheKey = "AppSettings-" + key;
            object cache = DataCache.GetCache(cacheKey);
            if (cache == null)
            {
                try
                {
                    cache = ConfigurationManager.AppSettings[key];
                    if (cache != null)
                    {
                        DataCache.SetCache(cacheKey, cache, DateTime.Now.AddMinutes(180.0), TimeSpan.Zero);
                    }
                }
                catch
                {
                }
            }
            return cache.ToString();
        }

        public static bool GetConfigBool(string key)
        {
            bool flag = false;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    flag = bool.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return flag;
        }

        public static decimal GetConfigDecimal(string key)
        {
            decimal num = 0M;
            string configString = GetConfigString(key);
            if ((configString != null) && (string.Empty != configString))
            {
                try
                {
                    num = decimal.Parse(configString);
                }
                catch (FormatException)
                {
                }
            }
            return num;
        }
    }
}

