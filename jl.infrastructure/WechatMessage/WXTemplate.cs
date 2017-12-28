using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Infrastructure.WechatMessage
{
    /// <summary>
    /// 微信模板
    /// 模板Id
    /// Url
    /// 小程序
    /// 模板项列表
    /// </summary>
    internal class WXTemplate
    {
        public WXTemplate(string templateid) : this(templateid, null, null, null)
        {

        }

        public WXTemplate(string templateid, string url, string miniappid, string minipagepath)
        {
            this.template_id = template_id;
            this.url = url;
            this.miniprogram_appid = miniappid;
            this.miniprogram_pagepath = minipagepath;

            this.Items = new List<WXTemplateItem>();
        }
        
        public string template_id { get; set; }
        public string url { get; set; }

        public string miniprogram_appid { get; set; }
        public string miniprogram_pagepath { get; set; }

        public IList<WXTemplateItem> Items { get; set; }

        public string ToJsonString(string toUser)
        {
            JObject jObj = new JObject();
            jObj["touser"] = toUser;
            jObj["template_id"] = this.template_id;
            jObj["url"] = this.url;

            JObject miniprogram = new JObject();
            miniprogram.Add("miniprogram_appid", miniprogram_appid);
            miniprogram.Add("miniprogram_pagepath", miniprogram_pagepath);
            jObj["miniprogram"] = miniprogram;

            JObject data = new JObject();
            foreach (var item in Items)
            {
                var itemObj = new JObject();
                itemObj.Add("value", item.Value);
                itemObj.Add("color", item.Color);

                data.Add(item.Name, itemObj);
            }
            jObj.Add("data", data);

            return jObj.ToString();
        }
    }
}
