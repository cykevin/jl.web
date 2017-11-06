using JL.Web.Areas.backend.Models;
using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JL.Web.Helpers;
using JL.Web.Common;

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
            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0, "categoryid");
            return View();
        }

        //新品上架
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.Name = model.Name;
                product.Alias = model.Alias;
                product.Description = model.Description;
                product.MarketPrice = model.MarketPrice ?? product.MarketPrice;
                product.RetailPrice = model.RetailPrice ?? product.RetailPrice;

                if (Request.Files != null &&
            Request.Files.Count > 0)
                {
                    var imgLink = FileHelper.SaveProductImage(Request.Files[0]);
                    product.Picture = imgLink;
                }

                var productId = jlService.AddProduct(product);
                if (model.CategoryId > 0)
                {
                    jlService.ProductToCategory(productId, new int[] { model.CategoryId.Value });
                }

                ResultObject rutObj = ResultObject.Succeed();
                ViewData.Add("ResultObject", rutObj);
            }

            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0, "categoryid");
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files != null &&
            Request.Files.Count > 0)
            {
                var imgLink = FileHelper.SaveProductImage(Request.Files[0]);

                return Json(ResultObject<string>.Succeed(imgLink));
            }

            return Json(ResultObject.Failed());
        }
             
        //产品类别
        public ActionResult Categories()
        {
            return View();
        }
    }
}