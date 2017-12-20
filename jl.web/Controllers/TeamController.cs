using JL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    public class TeamController : Controller
    {
        private IJLService jlService;

        public TeamController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Team
        public ActionResult Detail(int id = 0)
        {
            var pager = JL.Core.Common.PageReq.Create();
            var page = jlService.MemberPage(pager);

            if(id>0)
            {
                var member = jlService.GetMember(id);
                ViewBag.member = member;
            }

            return View(page.Data);
        }

        public ActionResult Index(int id = 0)
        {
            var pager = JL.Core.Common.PageReq.Create();
            var page = jlService.MemberPage(pager);

            if (id > 0)
            {
                var member = jlService.GetMember(id);
                ViewBag.member = member;
            }

            return View(page.Data);
        }
    }
}