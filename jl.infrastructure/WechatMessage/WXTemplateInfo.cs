using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JL.Infrastructure.WechatMessage
{
    public class WXTemplateInfo
    {
        public string TemplateId { get; set; }
        public List<WXTemplateItem> Items { get; set; }

        public WXTemplateInfo()
        {
            Items = new List<WXTemplateItem>();
        }

        public void SaveXml()
        {
            XmlSerializer xmlSeri = new XmlSerializer(typeof(WXTemplateInfo));
            using (FileStream fs = new FileStream(TemplateId + ".xml", FileMode.Create))
            {
                xmlSeri.Serialize(fs, this);
            }
        }
    }

    
}
