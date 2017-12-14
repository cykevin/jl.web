using JL.Core;
using JL.Core.Common;
using JL.Core.Models;
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
    [Authorize(Roles = Consts.Role_Admin)]
    public class BannerController : Controller
    {
        private IJLService jlService;

        public BannerController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Banner
        public ActionResult Index()
        {
            var pager = PageReq.Create();

            // search page 
            var data = jlService.BannerPage(pager);
            
            return View(data);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(BannerModel model)
        {
            if (ModelState.IsValid)
            {
                // file
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    var picture = FileHelper.SaveBannerImage(Request.Files[0]);
                    model.Picture = picture;
                }

                var banner = new Banner();
                banner.BackgroundColor = model.BackgroundColor;
                banner.Desctiption = model.Desctiption;
                banner.Picture = model.Picture;
                banner.SortIndex = model.SortIndex;
                banner.Status = model.Status;
                banner.Title = model.Title;

                jlService.AddBanner(banner);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var banner = jlService.GetBanner(id);

            var model = new JL.Web.Areas.backend.Models.BannerModel();
            model.BackgroundColor = banner.BackgroundColor;
            model.Desctiption = banner.Desctiption;
            model.Picture = banner.Picture;
            model.SortIndex = banner.SortIndex;
            model.Status = banner.Status;
            model.Title = banner.Title;
            model.Url = banner.Url;

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(BannerModel model,int id)
        {
            if (ModelState.IsValid)
            {
                string picture = null;
                // file
                if (Request.Files != null &&
                    Request.Files.Count > 0)
                {
                    picture = FileHelper.SaveBannerImage(Request.Files[0]);
                    model.Picture = picture;
                }

                var banner = jlService.GetBanner(id);
                banner.BackgroundColor = model.BackgroundColor;
                banner.Desctiption = model.Desctiption;
                banner.Picture = model.Picture;
                banner.SortIndex = model.SortIndex;
                banner.Status = model.Status;
                banner.Title = model.Title;

                jlService.UpdateBanner(banner);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View(model);
        }
             


    }
}