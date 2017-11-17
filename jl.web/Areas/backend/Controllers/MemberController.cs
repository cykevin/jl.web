using JL.Web.Areas.backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Areas.backend.Controllers
{
    public class MemberController : Controller
    {
        // GET: backend/Member
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(MemberModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(MemberModel model, int id)
        {

            return View();
        }


    }
}