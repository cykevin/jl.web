using jl.web.Areas.backend.Models;
using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jl.web.Areas.backend.Controllers
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

        //新品上架
        public ActionResult New(ProductModel model)
        {
            if(ModelState.IsValid)
            {
                Product product = new Product();
                product.Alias = model.Alias;
                product.Description = model.Description;
                product.MarketPrice = model.MarketPrice;
                product.RetailPrice = model.RetailPrice;

                jlService.AddProduct(product);


            }
            

            return View();
        }

        //产品类别
        public ActionResult Categories()
        {
            return View();
        }
    }
}