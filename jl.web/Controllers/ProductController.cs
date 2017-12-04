using JL.Core;
using JL.Core.Common;
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
        public ActionResult Index(int id = 0)
        {
            // category
            PageReq pager = new PageReq();
            var categoryData = jlService.ProductCategoryPage(pager);
            ViewBag.Categories = categoryData;

            if (id < 1)
            {
                var page = PageReq.Create();
                var products = jlService.ProductPage(page);
                var p = products.Data.FirstOrDefault();
                return View(p);
            }

            var product = jlService.GetProduct(id);

            return View(product);
        }

        // GET: Product
        public ActionResult Detail(int id = 0)
        {
            // category
            PageReq pager = new PageReq();
            var categoryData = jlService.ProductCategoryPage(pager);
            ViewBag.Categories = categoryData;

            if (id < 1)
            {
                var page = PageReq.Create();
                var products = jlService.ProductPage(page);
                var p = products.Data.FirstOrDefault();
                return View(p);
            }

            var product = jlService.GetProduct(id);

            return View(product);
        }


    }
}
