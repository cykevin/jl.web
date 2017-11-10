using JL.Core;
using JL.Web.Areas.backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Areas.backend.Controllers
{
    public class MaterialController : Controller
    {
        private IJLService jlService;

        public MaterialController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Material
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult New(MaterialModel model)
        {
            if(ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.Title = model.Title;
                material.MaterialType = model.Type;
                material.Description = model.Description;
                material.FileName = model.FileName;                
                material.Picture = model.Picture;
                material.Status = model.Status ? 0 : 1;

                jlService.AddMaterial(material);
            }

            return View();
        }
    }
}