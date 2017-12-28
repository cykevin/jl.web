using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jl.web;
using JL.Infrastructure.WechatMessage;

namespace jl.web.test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TemplateTest()
        {
            WXTemplateInfo wxinfo = new WXTemplateInfo();
            wxinfo.TemplateId = "bmdLCp745NMy5tV_b3VyG9tia05Iv-IPwHKT0XC8FJA";
            wxinfo.Items.Add(new WXTemplateItem { Name = "first" });
            wxinfo.Items.Add(new WXTemplateItem { Name = "keyword1" });
            wxinfo.Items.Add(new WXTemplateItem { Name = "keyword2" });
            wxinfo.Items.Add(new WXTemplateItem { Name = "keyword3" });
            wxinfo.Items.Add(new WXTemplateItem { Name = "remark" });

            wxinfo.SaveXml();
        }
    }
}
