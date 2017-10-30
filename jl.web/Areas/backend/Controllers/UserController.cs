using JL.Core;
using JL.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace jl.web.Areas.backend.Controllers
{
    public class UserController : Controller
    {
        private readonly IJLService jlService;

        public UserController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/User
        public ActionResult Index()
        {
            return View();
        }

        // GET: backend/User/5
        public ActionResult Index(int id)
        {
            return View();
        }

        // GET: backend/User/Create
        public string Create()
        {
            var username = "user001";
            var password = "666666";
            int number = 100;
            
            while (true)
            {
                var userTmp=Membership.GetUser(username);                
                if (userTmp == null)
                {
                    break;
                }
                else
                {
                    username = string.Format("user{0}", number);
                }

                number++;
            }
            var token = WebSecurity.CreateUserAndAccount(username, password, requireConfirmationToken: true);
            Roles.AddUserToRole(username, Consts.Role_User);

            var user = jlService.GetUser(username);

            return user.ToString() + " token:" + token;
        }

        public string Confirm(string username)
        {
            var confirmed = WebSecurity.IsConfirmed(username);
            return string.Format("{0} {1} confirmed.", username, confirmed ? "is" : "is not");
        }


        // POST: backend/User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: backend/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: backend/User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: backend/User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: backend/User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List(int id)
        {
            JL.Core.Common.PageReq req = new JL.Core.Common.PageReq();
            req.PageIndex = 1;
            req.PageSize = 5;
            req.OrderBy = "addtime asc";

            var pages = jlService.UserPage(req);

            return View(pages);
        }
    }
}
