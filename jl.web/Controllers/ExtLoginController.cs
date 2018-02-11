using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    public class ExtLoginController : Controller
    {
        // GET: ExtLogin
        [HttpGet]
        public ActionResult Weixin()
        {
            var url = "https://open.weixin.qq.com/connect/qrconnect?appid=APPID&redirect_uri=REDIRECT_URI&response_type=code&scope=SCOPE&state=STATE#wechat_redirect";

            JL.Infrastructure.HttpUtil.HttpSender.Request("")
        }
    }
}