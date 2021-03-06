﻿using JL.Web.Areas.backend.Models;
using JL.Web.Common;
using JL.Core;
using JL.Core.Common;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Areas.backend.Controllers
{
    [Authorize(Roles = Consts.Role_Admin)]
    public class CategoryController : Controller
    {
        private IJLService jlService;

        public CategoryController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Category
        public ActionResult Index()
        {
            // search category within product
            PageReq pager = new PageReq();
            var pageData=jlService.ProductCategoryPage(pager);
            return View(pageData);
        }

        public ActionResult New(CategoryModel model)
        {
            if(ModelState.IsValid)
            {
                var pCategory = new ProductCategory();
                pCategory.Name = model.Name;
                pCategory.SortIndex = model.Sort;                
                pCategory.Alias = model.Alias;
                pCategory.Status = 1;

                var id = jlService.AddProductCategory(pCategory);
                model.Id = id;

                return Json(ResultObject<CategoryModel>.Succeed(model));
            }

            return Json(ModelState);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var category = jlService.GetProductCategory(id);
            if (category != null)
            {
                jlService.DeleteProductCategory(category);
                return Json(ResultObject.Succeed());
            }

            return Json(ResultObject.Failed());
        }
    }
}