using jl.web.Areas.backend.Models;
using JL.Core;
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
                //jlService.add
            }

            return View();
        }
    }
}