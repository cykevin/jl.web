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
            return View();
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

                jlService.AddProductCategory(pCategory);
            }

            return View();
        }
    }
}