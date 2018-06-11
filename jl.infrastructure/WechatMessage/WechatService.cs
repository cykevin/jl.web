using JL.Infrastructure.HttpUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JL.Infrastructure.WechatMessage
{
    class WechatService
    {
        enum TemplateService
        {
            Login,
            Binded
        }

        private string SendTemplateMessage(string content)
        {
            // load template
            string Access_Token = GetAccessToken();

            string posturl = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + Access_Token;

            var result = Http.Post(posturl, content, Encoding.Default);

            return result;
        }

        private string GenTemplateData(string templateid,string toUser,string url)
        {
            throw new NotImplementedException();
            //WXTemplate template = new WXTemplate(templateid);
            //template.url = url;
            
        }


        private string GetAccessToken()
        {
            return null;
        }
    }
}
