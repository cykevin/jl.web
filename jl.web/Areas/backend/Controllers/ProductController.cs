using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jl.web.Areas.backend.Controllers
{
    public class ProductController : Controller
    {
        // GET: backend/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}