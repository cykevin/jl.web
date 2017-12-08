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
    public class SkinCareController : Controller
    {
        private IJLService jlService;

        public SkinCareController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        public ActionResult Index()
        {
            ArticleFilter af = new ArticleFilter();
            af.Status = Consts.ArticleStatus_Published;

            var pager = PageReq<ArticleFilter>.Create(af, 1,10);
            var article = jlService.ArticlePage(pager);
            return View(article);
        }

        // GET: SkinCare/page-1
        public ActionResult Page(int page = 1)
        {
            ArticleFilter af = new ArticleFilter();
            af.Status = Consts.ArticleStatus_Published;

            var pager = PageReq<ArticleFilter>.Create(af, page,10);
            var article = jlService.ArticlePage(pager);
            return View(article);
        }
        
        // skincare/1
        public ActionResult Detail(int id)
        {
            ArticleFilter af = new ArticleFilter();
            af.Status = Consts.ArticleStatus_Published;

            var pager = PageReq<ArticleFilter>.Create(af, id);
            var article = jlService.ArticlePage(pager);
            return View(article);
        }
    }
}