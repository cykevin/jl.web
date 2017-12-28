using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Infrastructure.WechatMessage
{
    public class WXTemplateItem
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Value { get; set; }

        public WXTemplateItem()
        {
            this.Color = "#173177";
        }
    }
}
