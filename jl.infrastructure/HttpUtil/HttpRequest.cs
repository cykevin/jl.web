using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JL.Infrastructure.HttpUtil
{
    /// <summary>  
    /// Http请求参考类  
    /// </summary>  
    public class HttpRequest
    {
        public static readonly Version Version10 = new Version("1.0");
        public static readonly Version Version11 = new Version("1.1");

        /// <summary>  
        /// 请求URL必须填写  
        /// </summary>  
        public string Url { get; set; }

        /// <summary>  
        /// 请求方式默认为GET方式,当为POST方式时必须设置Postdata的值  
        /// </summary>  
        public string Method { get; set; } = "GET";

        /// <summary>  
        /// 默认请求超时时间  
        /// </summary>  
        public int Timeout { get; set; } = 100000;

        /// <summary>  
        /// 默认写入Post数据超时间  
        /// </summary>  
        public int ReadWriteTimeout { get; set; } = 30000;

        /// <summary>  
        ///  获取或设置一个值，该值指示是否与 Internet 资源建立持久性连接默认为true。  
        /// </summary>  
        public Boolean KeepAlive { get; set; } = true;

        /// <summary>  
        /// 请求标头值 默认为text/html, application/xhtml+xml, */*  
        /// </summary>  
        public string Accept { get; set; } = "text/html, application/xhtml+xml, */*";

        /// <summary>  
        /// 请求返回类型默认 text/html  
        /// </summary>  
        public string ContentType { get; set; } = "text/html";

        /// <summary>  
        /// 客户端访问信息默认Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)  
        /// </summary>  
        public string UserAgent { get; set; } = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";

        /// <summary>  
        /// 返回数据编码默认为NUll,可以自动识别,一般为utf-8,gbk,gb2312  
        /// </summary>  
        public Encoding Encoding { get; set; }

        /// <summary>  
        /// Post的数据类型  
        /// </summary>  
        public PostDataType PostDataType { get; set; } = PostDataType.String;

        /// <summary>  
        /// Post请求时要发送的字符串Post数据  
        /// </summary>  
        public string Postdata { get; set; } = string.Empty;

        /// <summary>  
        /// Post请求时要发送的Byte类型的Post数据  
        /// </summary>  
        public byte[] PostdataByte { get; set; }

        /// <summary>  
        /// 设置代理对象 
        /// </summary>  
        public IWebProxy WebProxy { get; set; }

        /// <summary>  
        /// Cookie对象集合  
        /// </summary>  
        public CookieCollection CookieCollection { get; set; }

        /// <summary>  
        /// 请求时的Cookie  
        /// </summary>  
        public string Cookie { get; set; }

        /// <summary>  
        /// 来源地址，上次访问地址  
        /// </summary>  
        public string Referer { get; set; } = string.Empty;

        /// <summary>  
        /// 证书绝对路径  
        /// </summary>  
        public string CerPath { get; set; } = string.Empty;

        /// <summary>  
        /// 设置返回类型String和Byte  
        /// </summary>  
        public ResultType ResultType { get; set; } = ResultType.String;

        /// <summary>  
        /// header对象  
        /// </summary>  
        public WebHeaderCollection Header { get; set; } = new WebHeaderCollection();

        /// <summary>  
        // 获取或设置用于请求的 HTTP 版本。返回结果:用于请求的 HTTP 版本。
        /// </summary>  
        public Version ProtocolVersion { get; set; } = Version11;

        /// <summary>  
        ///  获取或设置一个 System.Boolean 值，该值确定是否使用 100-Continue 行为。如果 POST 请求需要 100-Continue 响应，则为 true；否则为 false。默认值为 true。  
        /// </summary>  
        public bool Expect100Continue { get; set; } = true;

        /// <summary>  
        /// 设置509证书集合  
        /// </summary>  
        public X509CertificateCollection ClentCertificates { get; set; } = new X509CertificateCollection();

        /// <summary>  
        /// 设置或获取Post参数编码,默认的为Default编码  
        /// </summary>  
        public Encoding PostEncoding { get; set; }

        /// <summary>  
        /// Cookie返回类型,默认的是只返回字符串类型  
        /// </summary>  
        public ResultCookieType ResultCookieType { get; set; } = ResultCookieType.String;

        /// <summary>  
        /// 获取或设置请求的身份验证信息。  
        /// </summary>  
        public ICredentials Credentials { get; set; } = CredentialCache.DefaultCredentials;

        /// <summary>  
        /// 设置请求将跟随的重定向的最大数目  
        /// </summary>  
        public int MaximumAutomaticRedirections { get; set; }

        /// <summary>  
        /// 获取和设置IfModifiedSince，默认为当前日期和时间  
        /// </summary>  
        public DateTime? IfModifiedSince { get; set; }

        public bool AllowAutoRedirect { get; set; } = true;

        public int Connectionlimit { get; set; } = 1024;
    }
}
