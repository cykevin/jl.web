using JL.Core;
using JL.Core.Common;
using JL.Core.Filters;
using JL.Web.Areas.backend.Models;
using JL.Web.Common;
using JL.Web.Helpers;
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
        public ActionResult Index(MaterialSearchModel model)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.AddTimeFrom = model.AddTimeFrom;
            filter.AddTimeTo = model.AddTimeTo;
            filter.MaterialType = model.MaterialType;
            filter.Title = model.Title;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(MaterialModel model)
        {
            if(ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.Title = model.Title;
                material.MaterialType = model.Type;
                material.Description = model.Description;
                material.FileName = model.FileName;
                material.Url = model.FileName;
                material.Picture = model.Picture;
                material.Status = model.Status ? 0 : 1;
                material.AddTime = model.AddTime ?? DateTime.Now;

                jlService.AddMaterial(material);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var material = jlService.GetMaterial(id);

            var model = new MaterialModel();
            model.Description = material.Description;
            model.FileName = material.FileName;
            model.Picture = material.Picture;
            model.Status = material.Status==0;
            model.Title = material.Title;
            model.Type = material.MaterialType;
            material.AddTime = model.AddTime ?? DateTime.Now;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(MaterialModel model,int id)
        {
            if(ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.AutoId = id;
                material.Title = model.Title;
                material.MaterialType = model.Type;
                material.Description = model.Description;
                material.FileName = model.FileName;
                material.Url = model.FileName;
                material.Picture = model.Picture;
                material.Status = model.Status ? 0 : 1;

                jlService.UpdateMaterial(material);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }


        [HttpPost]
        public ActionResult Upload()
        {
            // file
            if (Request.Files != null &&
                Request.Files.Count > 0)
            {
                string imgLink = "";
                try
                {
                    imgLink = FileHelper.SaveMaterial(Request.Files[0]);
                }
                catch (Exception e)
                {
                    return Json(ResultObject.Failed(e.ToString()));
                }

                return Json(ResultObject<string>.Succeed(imgLink));
            }

            return Json(ResultObject.Failed());
        }
    }
}