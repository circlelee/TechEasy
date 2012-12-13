using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;
using TechEasy.Core.Helper;

namespace TechEasy.Core.Common
{
    public class PageLoader
    {
        public static readonly String AgentIE6 = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
        public static readonly String AgentIE8 = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0)";

        private static Encoding encoding = Encoding.Default;
        private string pageEncoding = encoding.BodyName;
        private bool isSetEncoding = false;
        private string agentInfo = AgentIE6;

        public string Url { get; set; }

        public string AgentInfo
        {
            get { return agentInfo; }
            set { agentInfo = value; }
        }

        public string PageEncoding
        {
            get { return pageEncoding; }
            set { pageEncoding = value; }
        }

        public string DownLoad()
        {
            if (isSetEncoding)
                return DownLoad(Url, agentInfo, pageEncoding);
            return DownLoad(Url, agentInfo);
        }

        public static string DownLoad(string url)
        {
            return DownLoad(url, AgentIE6);
        }

        public static string DownLoad(string url, string agenetInfo)
        {
            return DownLoad(url, agenetInfo, "");
        }

        public static string DownLoad(string url, string agenetInfo, string encoding)
        {
            string str;
            try
            {
                WebResponse res = GetResponse(url, agenetInfo);

                Encoding ec;
                if (StringHelper.HasText(encoding))
                    ec = Encoding.GetEncoding(encoding);
                else
                    ec = GetEncoding(res);
                StreamReader reader = new StreamReader(res.GetResponseStream(), GetEncoding(res));
                str = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return str;
        }

        private static Encoding GetEncoding(WebResponse response)
        {
            try
            {
                string contentType = response.ContentType;
                if (contentType == null)
                    return encoding;
                string[] strArray = contentType.ToLower(CultureInfo.InvariantCulture).Split(new char[] { ';', '=', ' ' });
                bool isFind = false;
                foreach (var item in strArray)
                {
                    if (item == "charset") isFind = true;
                    else if (isFind) return Encoding.GetEncoding(item);
                }

            }
            catch (Exception exception)
            {
                if (((exception is ThreadAbortException) || (exception is StackOverflowException)) || (exception is OutOfMemoryException))
                {
                    throw;
                }
            }
            return encoding;
        }

        private static WebResponse GetResponse(string url, string agentInfo)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = agentInfo;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return request.GetResponse();
        }

        //public static String ProcessPic(string pageBody, string siteUrl)
        //{

        //    if (StringHelper.IsNullOrEmpty(pageBody)) return "";

        //    MatchCollection matchs = Regex.Matches(pageBody, RegPattern.Img, RegexOptions.Singleline);
        //    for (int i = 0; i < matchs.Count; i++)
        //    {

        //        string picUrl = matchs[i].Groups[1].Value;

        //        if (!picUrl.ToLower().EndsWith("jpg") && !picUrl.ToLower().EndsWith("jpeg") && !picUrl.ToLower().EndsWith("gif") && !picUrl.ToLower().EndsWith("bmp") && !picUrl.ToLower().EndsWith("png")) continue;

        //        string newPicUrl = downPic(picUrl.Trim(), siteUrl);
        //        pageBody = pageBody.Replace(picUrl, newPicUrl);

        //    }

        //    return pageBody;
        //}


        //private static string downPic(string picUrl, string siteUrl)
        //{


        //    // 1、修改图片网址为可下载网址
        //    if (picUrl.ToLower().StartsWith("http") == false)
        //    {
        //        picUrl = strUtil.Join(siteUrl, picUrl);
        //    }

        //    // 2、图片保存的路径
        //    string picExt = Path.GetExtension(picUrl).ToLower();
        //    if (string.IsNullOrEmpty(picExt)) picExt = ".jpg";

        //    string absPathDisk = PathHelper.Map(strUtil.Join(sys.Path.DiskUpload, picDirName));
        //    String picName = Img.GetPhotoName(absPathDisk, picExt);
        //    logger.Info("picSavePath=" + picName);

        //    // 3、下载图片
        //    WebClient client = new WebClient();
        //    client.Headers.Add("user-agent", AgentIE6);
        //    try
        //    {
        //        String savePath = Path.Combine(absPathDisk, picName);
        //        client.DownloadFile(picUrl, savePath);
        //    }
        //    catch
        //    {
        //        return picUrl;
        //    }

        //    // 4、图片的网址
        //    picName = picName.Replace("\\", "/");
        //    return strUtil.Join(strUtil.Join(sys.Path.Upload, picDirName), picName);
        //}
    }
}
