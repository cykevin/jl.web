using JL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    public class JoinController : Controller
    {
        private IJLService jlService;

        public JoinController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Models.FranchiseeViewModel model)
        {
            if (ModelState.IsValid)
            {
                JL.Core.Models.Franchisee franchisee = new Core.Models.Franchisee();
                franchisee.Name = model.Name;
                franchisee.Phone = model.Phone;
                franchisee.Remark = model.Remark;
                franchisee.Email = model.Email;
                franchisee.Address = model.Address;
                franchisee.ApplyTime = DateTime.Now;
                jlService.AddFranchisee(franchisee);
            }

            return View();
        }
    }
}