using JL.Core;
using JL.Core.Filters;
using JL.Web.Areas.backend.Models;
using JL.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Areas.backend.Controllers
{
    [Authorize(Roles = Consts.Role_Admin)]
    public class FranchiseeController : Controller
    {
        private IJLService jlService;

        public FranchiseeController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Franchisee
        public ActionResult Index(FranchiseeSearchModel model,int page = 1)
        {
            JL.Core.Filters.FranchiseeFilter filter = new Core.Filters.FranchiseeFilter();
            filter.Email = model.Email;
            filter.Name = model.Name;
            filter.Phone = model.Phone;

            var pager = Core.Common.PageReq<FranchiseeFilter>.Create(filter, page);

            var data = jlService.FranchiseePage(pager);

            ViewBag.franchiseeQuery = model;

            return View(data);
        }
        
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(FranchiseeModel model)
        {
            if(ModelState.IsValid)
            {
                var fran = new Core.Models.Franchisee();
                fran.Name = model.Name;
                fran.Email = model.Email;
                fran.Weixin = model.Weixin;
                fran.Phone = model.Phone;
                fran.ApplyTime = model.ApplyTime ?? DateTime.Now;
                fran.ProcessTime = DateTime.Now;
                fran.Address = model.Address;
                fran.Status = 1;

                jlService.AddFranchisee(fran);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var fran = jlService.GetFranchisee(id);

            var model = new backend.Models.FranchiseeModel();
            model.Address = fran.Address;
            model.ApplyTime = fran.ApplyTime;
            model.Email = fran.Email;
            model.Name = fran.Name;
            model.Phone = fran.Phone;
            model.Weixin = fran.Weixin;
            model.Status = fran.Status;

            return View(model);
        }

        public ActionResult Edit(FranchiseeModel model, int id)
        {
            if(ModelState.IsValid)
            {
                var fran = jlService.GetFranchisee(id);
                
                fran.Address = model.Address;
                fran.ApplyTime = model.ApplyTime??DateTime.Now;
                fran.Email = model.Email;
                fran.Name = model.Name;
                fran.Phone = model.Phone;
                fran.Weixin = model.Weixin;
                fran.Status = model.Status;

                jlService.UpdateFranchisee(fran);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View();
        }
    }
}