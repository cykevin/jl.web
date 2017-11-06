using JL.Web.Areas.backend.Models;
using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JL.Web.Helpers;

namespace JL.Web.Areas.backend.Controllers
{
    public class ProductController : Controller
    {
        private IJLService jlService;

        public ProductController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0);
            return View();
        }

        //新品上架
        [HttpPost]
        public ActionResult New(ProductModel model)
        {

            if(ModelState.IsValid)
            {
                Product product = new Product();
                product.Alias = model.Alias;
                product.Description = model.Description;
                product.MarketPrice = model.MarketPrice;
                product.RetailPrice = model.RetailPrice;
                product.MarketPrice = model.MarketPrice;
                product.RetailPrice = model.RetailPrice;
                product.Picture = model.Picture;

                jlService.AddProduct(product);

            }
            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0);
            return View();
        }

        //产品类别
        public ActionResult Categories()
        {
            return View();
        }
    }
}