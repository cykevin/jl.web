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

        //新品上架
        public ActionResult New()
        {
            return View();
        }

        //产品类别
        public ActionResult Categories()
        {
            return View();
        }
    }
}