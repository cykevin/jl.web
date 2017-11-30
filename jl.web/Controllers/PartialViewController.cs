using JL.Core;
using JL.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    [ChildActionOnly]
    public class PartialViewController : Controller
    {
        private IJLService jlService;

        public PartialViewController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Banner
        public ActionResult Banner()
        {
            //banner
            var pager = PageReq.Create();
            var banners = jlService.Banners();
            var bannerVo = banners.OrderBy(b => b.SortIndex);
            return PartialView(bannerVo);
        }
    }
}