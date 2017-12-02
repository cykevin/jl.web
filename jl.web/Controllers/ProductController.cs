using JL.Core;
using JL.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    public class ProductController : Controller
    {
        private IJLService jlService;

        public ProductController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Product
        public ActionResult Index(int id)
        {
            var product = jlService.GetProduct(id);

            return View(product);
        }
        
    }
}
