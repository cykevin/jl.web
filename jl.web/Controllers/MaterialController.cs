using JL.Core;
using JL.Core.Common;
using JL.Core.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    [Authorize]
    public class MaterialController : Controller
    {
        private IJLService jlService;

        public MaterialController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Material
        public ActionResult Index(int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();

            var pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        // 
        public ActionResult Picture(int page=1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.MaterialType = (int)MaterialType.Picture;

            var pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        public ActionResult Video(int page=1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.MaterialType = (int)MaterialType.Video;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }
    }
}