using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechEasy.Core.Helper
{
    public class StringHelper
    {
        private static Random r = new Random();

        public static bool IsNullOrEmpty(string target)
        {
            if (target != null)
                return target.Trim().Length == 0;
            return true;
        }

        /// <summary>
        /// 将对象转为字符串，如果对象为 null，则转为空字符串(string.Empty)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String ConverToNotNull(Object str)
        {
            if (str == null) return "";
            return str.ToString();
        }

        public static string ReturnJavascript(string source)
        {
            return "js~" + source;
        }

        public static string Join(string stra, string strb)
        {
            return Join(stra, strb, "/");
        }

        public static string Join(string stra, string strb, string separator)
        {
            return (Append(stra, separator) + TrimStart(strb, separator));
        }

        public static String Append(String srcString, String endString)
        {
            if (StringHelper.IsNullOrEmpty(srcString)) return endString;
            if (StringHelper.IsNullOrEmpty(endString)) return srcString;
            if (srcString.EndsWith(endString)) return srcString;
            return srcString + endString;
        }

        public static string ColorBoxClose()
        {
            return "$.fn.colorbox.close();";
        }


        public static Boolean HasText(String target)
        {
            return !IsNullOrEmpty(target);
        }

        public static String SubString(String str, int length)
        {
            if (str == null) return null;
            if (str.Length > length) return str.Substring(0, length);
            return str;
        }

        public static String TrimStart(String srcString, String trimString)
        {
            if (srcString == null) return null;
            if (trimString == null) return srcString;
            if (IsNullOrEmpty(srcString)) return String.Empty;
            if (srcString.StartsWith(trimString) == false) return srcString;
            return srcString.Substring(trimString.Length);
        }

        /// <summary>
        /// 从 srcString 的末尾剔除掉 trimString
        /// </summary>
        /// <param name="srcString"></param>
        /// <param name="trimString"></param>
        /// <returns></returns>
        public static String TrimEnd(String srcString, String trimString)
        {
            if (IsNullOrEmpty(trimString)) return srcString;
            if (srcString.EndsWith(trimString) == false) return srcString;
            if (srcString.Equals(trimString)) return "";
            return srcString.Substring(0, srcString.Length - trimString.Length);
        }

        /// <summary> 
        /// 取得HTML中所有图片的 URL。 
        /// </summary> 
        /// <param name="sHtmlText">HTML代码</param> 
        /// <returns>图片的URL列表</returns> 
        public static string GetHtmlImageUrlList(string sHtmlText)
        {
            // 定义正则表达式用来匹配 img 标签 
            Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""""]?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""""<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);

            // 搜刮匹配的字符串 
            MatchCollection matches = regImg.Matches(sHtmlText);
            StringBuilder sb = new StringBuilder();
            // 取得匹配项列表 
            foreach (Match match in matches)
                sb.Append(match.Groups["imgUrl"].Value + ";");
            string result = string.Empty;
            if (matches.Count > 0)
                result = StringHelper.TrimEnd(sb.ToString(), ";");
            return result;
        }

        public static string CutStringIntelligence(string input, int length)
        {
            return CutStringIntelligence(input, length, "...");
        }

        public static string CutStringIntelligence(string input, int length, string endStr)
        {
            string preStr = input;
            if (input.Length >= length)
                preStr = input.Substring(0, length);
            int indexLastLt = preStr.LastIndexOf('<');
            int indexLastGt = preStr.LastIndexOf('>');
            if (indexLastLt > -1)
            {
                if (indexLastLt > indexLastGt)
                {
                    string subtract = "";
                    if (input.Length > length)
                        subtract = input.Substring(length);
                    string pattern = @"[^>]+>";
                    var match = Regex.Match(subtract, pattern);
                    if (match != null)
                        preStr = preStr + match.Value;
                }
            }
            char[] coma = { ',', '，' };
            if (coma.Contains(preStr.Reverse().First()))
            {
                preStr = preStr.Substring(0, preStr.Length - 1);
            }
            return preStr + endStr;
        }

        public static string GetStringCount(string resouce, int l, string endStr)
        {
            byte[] encodedBytes = ASCIIEncoding.ASCII.GetBytes(resouce);
            int count = 0;
            int index = 0;
            StringBuilder starts = new StringBuilder();
            StringBuilder end = new StringBuilder();

            for (int i = 0, j = resouce.Length - 1; i < resouce.Length; i++, j--)
            {
                if ((int)encodedBytes[i] == 63)
                    count += 2;
                else
                    count += 1;
                if (count <= l / 2)
                    starts.Append(resouce.Substring(i, 1));

                if ((int)encodedBytes[j] == 63)
                    index += 2;
                else
                    index += 1;
                if (index <= l / 2 && j - 1 >= 0)
                    end.Append(resouce.Substring(j - 1, 1));
            }
            if (count <= l)
                return resouce;

            return starts.ToString() + endStr + string.Concat(end.ToString().Reverse());

        }

        /// <summary>
        /// 从字符串中截取指定长度的一段，如果源字符串被截取了，则结果末尾出现省略号...
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="length">需要截取的长度</param>
        /// <returns></returns>
        public static String CutString(Object str, int length)
        {
            return CutString(ConverToNotNull(str), length);
        }

        /// <summary>
        /// 从字符串中截取指定长度的一段，如果源字符串被截取了，则结果末尾出现省略号...
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="length">需要截取的长度</param>
        /// <returns></returns>
        public static String CutString(String str, int length)
        {
            if (str == null) return null;
            if (str.Length > length) return String.Format("{0}...", str.Substring(0, length));
            return str;
        }

        public static string GetFileName(string fileName)
        {
            if (fileName == null || fileName.Length < 1)
                return "";
            int Start = fileName.LastIndexOf('\\');
            return fileName.Substring(Start + 1);
        }

        public static string ResponseMessage()
        {
            return ResponseMessage("save success");
        }

        public static string ResponseMessage(string message, bool notUse = true)
        {
            string str = string.Format("$('#inline_content').html('{0}');", message);
            if (notUse)
                return str;
            else
                return str + "$.fn.colorbox({ inline: true, initialWidth: '400px', width: '400px', initialHeight: '100px', height: '100px', href: '#inline_content' });";

        }

        public static string GetRandomColor()
        {
            string[] colorArray = { 
                                      "side_color_blue",
                                      "side_color_blueDark",
                                      "side_color_green",
                                      "side_color_greenDark",
                                      "side_color_yellow",
                                      "side_color_red",
                                      "side_color_orange",
                                      "side_color_pink",
                                      "side_color_darken",
                                      "side_color_purple"
                                  };
            int i = r.Next(0, colorArray.Length);
            return colorArray[i];
        }

    }
}
