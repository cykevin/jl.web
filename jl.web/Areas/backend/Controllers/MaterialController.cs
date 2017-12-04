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

        #region list page


        // GET: backend/Material
        public ActionResult Index(MaterialSearchModel model, int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.AddTimeFrom = model.AddTimeFrom;
            filter.AddTimeTo = model.AddTimeTo;
            filter.MaterialType = model.MaterialType;
            filter.Title = model.Title;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }
        public ActionResult Picture(MaterialSearchModel model, int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.AddTimeFrom = model.AddTimeFrom;
            filter.AddTimeTo = model.AddTimeTo;
            filter.MaterialType = (int)MaterialType.Picture;
            filter.Title = model.Title;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }
        public ActionResult Video(MaterialSearchModel model,int page=1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.AddTimeFrom = model.AddTimeFrom;
            filter.AddTimeTo = model.AddTimeTo;
            filter.MaterialType = (int)MaterialType.Video;
            filter.Title = model.Title;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        #endregion

        #region new page

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
                material.MaterialType = model.FileType;
                material.Description = model.Description;

                material.Status = model.Status ? 0 : 1;
                material.AddTime = model.AddTime ?? DateTime.Now;

                // 生成缩略图
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    string picture, filename;
                    var success = FileHelper.SaveMaterial(Request.Files[0], material.MaterialType, out filename, out picture);

                    if (success)
                    {
                        material.Picture = picture;
                        material.FileName = filename;
                        material.Url = model.FileName;
                    }
                }

                jlService.AddMaterial(material);                

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }


        [HttpGet]
        public ActionResult NewPicture()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewPicture(MaterialModel model)
        {
            if (ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.Title = model.Title;
                material.MaterialType = (int)MaterialType.Picture;
                material.Description = model.Description;

                material.Status = model.Status ? 0 : 1;
                material.AddTime = model.AddTime ?? DateTime.Now;

                // 生成缩略图
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    string picture, filename;
                    var success = FileHelper.SaveMaterial(Request.Files[0], material.MaterialType, out filename, out picture);

                    if (success)
                    {
                        material.Picture = picture;
                        material.FileName = filename;
                        material.Url = model.FileName;
                    }

                    //for show
                    model.Picture = picture;
                    model.FileName = filename;
                    model.Url = filename;
                }

                jlService.AddMaterial(material);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }

        [HttpGet]
        public ActionResult NewVideo()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewVideo(MaterialModel model)
        {
            if (ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.Title = model.Title;
                material.MaterialType = (int)MaterialType.Video;
                material.Description = model.Description;
                

                material.Status = model.Status ? 0 : 1;
                material.AddTime = model.AddTime ?? DateTime.Now;

                // 生成缩略图
                // picture
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    string picture, filename;
                    var success = FileHelper.SaveMaterial(Request.Files[0], material.MaterialType, out filename, out picture);

                    if (success)
                    {
                        material.Picture = picture;
                        material.FileName = filename;
                        material.Url = model.FileName;
                    }

                    //for show
                    model.Picture = picture;
                    model.FileName = filename;
                    model.Url = filename;
                }

                jlService.AddMaterial(material);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }

        #endregion

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
            model.FileType = material.MaterialType;
            material.AddTime = model.AddTime ?? DateTime.Now;

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(MaterialModel model,int id)
        {
            if(ModelState.IsValid)
            {
                var material = new JL.Core.Models.Material();
                material.AutoId = id;
                material.Title = model.Title;
                material.MaterialType = model.FileType;
                material.Description = model.Description;

                material.Status = model.Status ? 0 : 1;

                // picture
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    string picture, filename;
                    var success = FileHelper.SaveMaterial(Request.Files[0], material.MaterialType, out filename, out picture);

                    if (success)
                    {
                        material.Picture = picture;
                        material.FileName = filename;
                        material.Url = model.FileName;
                    }

                    //for show
                    model.Picture = picture;
                    model.FileName = filename;
                    model.Url = filename;
                }

                jlService.UpdateMaterial(material);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View(model);
        }


        [HttpPost]
        public ActionResult Upload(int fileType)
        {
            // file
            if (Request.Files != null &&
                Request.Files.Count > 0)
            {
                string fileLink = "";
                try
                {
                    string picture, filename;
                    var success = FileHelper.SaveMaterial(Request.Files[0], fileType, out filename, out picture);                    
                }
                catch (Exception e)
                {
                    return Json(ResultObject.Failed(e.ToString()));
                }
                
                return Json(ResultObject<object>.Succeed(new { FileLink = fileLink }));
            }

            return Json(ResultObject.Failed());
        }

    }
}