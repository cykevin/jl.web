﻿using JL.Web.Areas.backend.Models;
using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JL.Web.Helpers;
using JL.Web.Common;
using JL.Core.Common;
using JL.Infrastructure;

namespace JL.Web.Areas.backend.Controllers
{
    [Authorize(Roles = Consts.Role_Admin)]
    public class ProductController : Controller
    {
        private IJLService jlService;

        public ProductController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Product

        public ActionResult Index(ProductSearchModel searchTo, int page = 0)
        {
            var filter = new JL.Core.Filters.ProductFilter();
            filter.CategoryId = searchTo.CategoryId;
            filter.Title = searchTo.Title;
            var pager = PageReq<JL.Core.Filters.ProductFilter>.Create(filter, page);

            // search page 
            var data = jlService.ProductPage(pager);
            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0, "categoryid");
            ViewBag.productQuery = searchTo;
            ViewBag.ReturnUrl = Request.Url.PathAndQuery;
            return View(data);
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
                product.BriefIntroduction = model.BriefIntro;
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = jlService.GetProduct(id);
            ProductModel vo = new ProductModel();
            vo.Name = model.Name;
            vo.Picture = model.Picture;
            vo.MarketPrice = model.MarketPrice;
            vo.RetailPrice = model.RetailPrice;
            vo.SortIndex = model.SortIndex;
            vo.BriefIntro = model.BriefIntroduction;
            vo.Description = model.Description;
            vo.CategoryId = 0;
            vo.AddTime = model.AddTime;

            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0, "categoryid");
            return View(vo);
        }

        [ValidateInput(false)]
        public ActionResult Edit(ProductModel model,int id)
        {
            if(ModelState.IsValid)
            {
                var product = jlService.GetProduct(id);
                product.Alias = model.Alias;
                product.Name = model.Name;
                product.BriefIntroduction = model.BriefIntro;
                product.Description = model.Description;
                product.MarketPrice = model.MarketPrice??0;
                product.RetailPrice = model.RetailPrice??0;
                product.SortIndex = model.SortIndex?? product.SortIndex;
                product.AddTime = model.AddTime;
                // picture
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    var imgLink = FileHelper.SaveProductImage(Request.Files[0]);
                    product.Picture = imgLink;
                }

                jlService.UpdateProduct(product);

                ResultObject rutObj = ResultObject.Succeed();
                ViewData.Add("ResultObject", rutObj);

            }

            new ViewDataHelper(jlService).InitializeCategories(ViewData, 0, "categoryid");
            return View(model);
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
        
        public ActionResult Delete(string products, string returnUrl)
        {
            var idArray = products.Split(',')
                .Where(a => !string.IsNullOrEmpty(a))
                .Select(a => a.ToInt32()).Distinct();

            foreach (var id in idArray)
            {
                var article = jlService.GetProduct(id);
                if (article != null)
                {
                    jlService.DeleteProduct(article);
                }
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("index");
        }
    }
}