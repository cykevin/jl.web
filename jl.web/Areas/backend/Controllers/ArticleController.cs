using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Areas.backend.Controllers
{
    public class ArticleController : Controller
    {
        // GET: backend/Article
        public ActionResult Index()
        {
            return View();
        }
    }
}