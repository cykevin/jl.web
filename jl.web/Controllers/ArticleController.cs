using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IJLService jlService;

        public ArticleController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
    }
}