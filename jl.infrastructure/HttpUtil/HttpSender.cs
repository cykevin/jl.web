using JL.Infrastructure.Extensons;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace JL.Infrastructure.HttpUtil
{
    public class HttpSender
    {
        /// <summary>  
        /// 根据相传入的数据，得到相应页面数据  
        /// </summary>  
        /// <param name="item">参数类对象</param>  
        /// <returns>返回HttpResult类型</returns>  
        public static HttpResult Request(HttpRequest item)
        {
            HttpResult result = new HttpResult();
            HttpWebRequest request;
            HttpWebResponse response;
            try
            {
                //准备参数  
                request = GenerateRequest(item);
            }
            catch (Exception ex)
            {
                result.Cookie = string.Empty;
                result.Header = null;
                result.Html = ex.Message;
                result.StatusDescription = "配置参数时出错：" + ex.Message;
                //配置参数时出错  
                return result;
            }
            try
            {
                //请求数据  
                using (response = (HttpWebResponse)request.GetResponse())
                {
                    GetData(item, result, response);
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (response = (HttpWebResponse)ex.Response)
                    {
                        GetData(item, result, response);
                    }
                }
                else
                {
                    result.Html = ex.Message;
                }
            }
            catch (Exception ex)
            {
                result.Html = ex.Message;
            }
            return result;
        }

        public static HttpResult Request(string url)
        {
            return Request(new HttpRequest
            {
                Url = url
            });
        }

        public static HttpResult Request(string url, Encoding encoding)
        {
            return Request(new HttpRequest
            {
                Url = url,
                Encoding = encoding
            });
        }

        public static HttpResult Request(string url, System.Net.Http.HttpMethod method, Encoding encoding)
        {
            return Request(new HttpRequest
            {
                Url = url,
                Method = method.ToString(),
                Encoding = encoding
            });
        }

        private static void GetData(HttpRequest item, HttpResult result, HttpWebResponse response)
        {
            //获取StatusCode  
            result.StatusCode = response.StatusCode;
            //获取StatusDescription  
            result.StatusDescription = response.StatusDescription;
            //获取Headers  
            result.Header = response.Headers;
            //获取CookieCollection  
            if (response.Cookies != null)
            {
                result.CookieCollection = response.Cookies;
            }
            //获取set-cookie  
            if (response.Headers["set-cookie"] != null)
            {
                result.Cookie = response.Headers["set-cookie"];
            }

            //处理网页Byte  
            byte[] responseByte = ReadBytes(response);

            if (item.ResultType == ResultType.Byte)
            {
                result.ResultByte = responseByte;
            }
            else
            {
                if (responseByte != null && responseByte.Length > 0)
                {
                    if (item.Encoding != null)
                    {
                        result.Html = item.Encoding.GetString(responseByte);
                    }
                    else
                    {
                        //设置编码
                        var encoding = EncodingExtensions.GetEncoding(response.CharacterSet, responseByte);
                        //得到返回的HTML
                        result.Html = encoding.GetString(responseByte);
                    }
                }
                else
                {
                    //没有返回任何Html代码  
                    result.Html = string.Empty;
                }
            }
        }

        private static byte[] ReadBytes(HttpWebResponse response)
        {
            using (var responseSteam = response.GetResponseStream())
            using (var ms = new MemoryStream())
            {
                responseSteam?.CopyTo(ms);
                ms.Seek(0, SeekOrigin.Begin);

                var ms2 = new MemoryStream();

                try
                {
                    //GZIIP处理   
                    var stream = new GZipStream(ms, CompressionMode.Decompress);
                    stream.CopyTo(ms2);
                }
                catch
                {
                    ms2 = ms;
                }

                byte[] bytes = ms2.StreamToBytes();

#if NET_CORE
				ms2.Dispose();
#else
                ms2.Close();
#endif
                return bytes;
            }
        }

        private static HttpWebRequest GenerateRequest(HttpRequest item)
        {
            var request = (HttpWebRequest)WebRequest.Create(item.Url);

            SetCer(request, item);

            //设置Header参数  
            if (item.Header != null && item.Header.Count > 0)
            {
                foreach (string key in item.Header.AllKeys)
                {
#if NET_CORE
					request.Headers[key] = item.Header[key];
#else
                    request.Headers.Add(key, item.Header[key]);
#endif
                }
            }

            // 设置代理  
            SetProxy(request, item);

            if (item.ProtocolVersion != null)
            {
#if NET_CORE
				request.Headers["Version"] = item.ProtocolVersion.ToString();
#else
                request.ProtocolVersion = item.ProtocolVersion;
#endif
            }

#if !NET_CORE
            request.ServicePoint.Expect100Continue = item.Expect100Continue;
#endif

            //请求方式Get或者Post  
            request.Method = item.Method;
#if NET_CORE
			if (item.KeepAlive)
			{
				request.Headers["Connection"] = "Keep-Alive";
			}
			request.Headers["User-Agent"] = item.UserAgent;
			request.Headers["Referer"] = item.Referer;
#else
            request.Timeout = item.Timeout;
            request.KeepAlive = item.KeepAlive;
            request.ReadWriteTimeout = item.ReadWriteTimeout;
            if (item.IfModifiedSince != null)
            {
                request.IfModifiedSince = Convert.ToDateTime(item.IfModifiedSince);
            }

            request.UserAgent = item.UserAgent;

            request.Referer = item.Referer;

            request.AllowAutoRedirect = item.AllowAutoRedirect;

            if (item.MaximumAutomaticRedirections > 0)
            {
                request.MaximumAutomaticRedirections = item.MaximumAutomaticRedirections;
            }

            //设置最大连接  
            if (item.Connectionlimit > 0)
            {
                request.ServicePoint.ConnectionLimit = item.Connectionlimit;
            }
#endif
            //Accept  
            request.Accept = item.Accept;
            //ContentType返回类型  
            request.ContentType = item.ContentType;

            //设置安全凭证  
            request.Credentials = item.Credentials;
            //设置Cookie  
            SetCookie(request, item);

            //设置Post数据  
            SetPostData(request, item);

            return request;
        }

        private static void SetPostData(HttpWebRequest request, HttpRequest item)
        {
            //验证在得到结果时是否有传入数据  
            var postencoding = Encoding.UTF8;

            if (request.Method.Trim().ToLower().Contains("post"))
            {
                if (item.PostEncoding != null)
                {
                    postencoding = item.PostEncoding;
                }
                byte[] buffer = null;
                //写入Byte类型  
                if (item.PostDataType == PostDataType.Byte 
                    && item.PostdataByte != null 
                    && item.PostdataByte.Length > 0)
                {
                    //验证在得到结果时是否有传入数据  
                    buffer = item.PostdataByte;
                }
                //写入文件  
                else if (item.PostDataType == PostDataType.File 
                    && !string.IsNullOrEmpty(item.Postdata))
                {
                    StreamReader r = new StreamReader(File.OpenRead(item.Postdata), postencoding);
                    buffer = postencoding.GetBytes(r.ReadToEnd());
#if NET_CORE
					r.Dispose();
#else
                    r.Close();
#endif
                }
                //写入字符串  
                else if (!string.IsNullOrEmpty(item.Postdata))
                {
                    buffer = postencoding.GetBytes(item.Postdata);
                }
                if (buffer != null)
                {
#if NET_CORE
					request.Headers["Content-Length"] = buffer.Length.ToString();
					request.GetRequestStreamAsync().Result.Write(buffer, 0, buffer.Length);
#else
                    request.ContentLength = buffer.Length;
                    request.GetRequestStream().Write(buffer, 0, buffer.Length);
#endif
                }
            }
        }

        private static void SetCookie(HttpWebRequest request, HttpRequest item)
        {
            if (!string.IsNullOrEmpty(item.Cookie))
            {
                request.Headers[HttpRequestHeader.Cookie] = item.Cookie;
            }
            //设置CookieCollection
            if (item.ResultCookieType == ResultCookieType.CookieCollection)
            {
                request.CookieContainer = new CookieContainer();
                if (item.CookieCollection != null && item.CookieCollection.Count > 0)
                {
                    request.CookieContainer.Add(item.CookieCollection);
                }
            }
        }

        private static void SetProxy(HttpWebRequest request, HttpRequest item)
        {
            if (item.WebProxy != null)
            {
                request.Proxy = item.WebProxy;
            }
        }

        private static void SetCer(HttpWebRequest request, HttpRequest item)
        {
            if (!string.IsNullOrEmpty(item.CerPath))
            {
                //这一句一定要写在创建连接的前面。使用回调的方法进行证书验证。  
                ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;

                if (item.ClentCertificates != null && item.ClentCertificates.Count > 0)
                {
                    foreach (X509Certificate c in item.ClentCertificates)
                    {
                        request.ClientCertificates.Add(c);
                    }
                }

                //将证书添加到请求里  
                request.ClientCertificates.Add(new X509Certificate(item.CerPath));
            }
        }

        /// <summary>  
        /// 回调验证证书问题  
        /// </summary>  
        /// <param name="sender">流对象</param>  
        /// <param name="certificate">证书</param>  
        /// <param name="chain">X509Chain</param>  
        /// <param name="errors">SslPolicyErrors</param>  
        /// <returns>bool</returns>  
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; }
    }





    /// <summary>  
    /// Post的数据格式默认为string  
    /// </summary>  
    public enum PostDataType
    {
        /// <summary>  
        /// 字符串类型，这时编码Encoding可不设置  
        /// </summary>  
        String,
        /// <summary>  
        /// Byte类型，需要设置PostdataByte参数的值编码Encoding可设置为空  
        /// </summary>  
        Byte,
        /// <summary>  
        /// 传文件，Postdata必须设置为文件的绝对路径，必须设置Encoding的值  
        /// </summary>  
        File
    }

    /// <summary>  
    /// Cookie返回类型  
    /// </summary>  
    public enum ResultCookieType
    {
        /// <summary>  
        /// 只返回字符串类型的Cookie  
        /// </summary>  
        String,
        /// <summary>  
        /// CookieCollection格式的Cookie集合同时也返回String类型的cookie  
        /// </summary>  
        CookieCollection
    }

    /// <summary>  
    /// 返回类型  
    /// </summary>  
    public enum ResultType
    {
        /// <summary>  
        /// 表示只返回字符串 只有Html有数据  
        /// </summary>  
        String,
        /// <summary>  
        /// 表示返回字符串和字节流 ResultByte和Html都有数据返回  
        /// </summary>  
        Byte
    }
}

