using jl.web.Models;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace jl.web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        // GET: Account

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                bool flag = Membership.ValidateUser(model.UserName, model.Password);
                if (flag)
                {
                    //var user = _userProfileService.GetByUsername(model.UserName);

                    //if (user != null)
                    //{
                    //    if (user.Status.HasValue &&
                    //        !user.Status.Value.Equals(JobStatus.Quit))
                    //    {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

                    //    if (Roles.IsUserInRole(model.UserName, BnuxqCRM.Common.Enums.RoleType.Sales.ToString()))
                    //    {
                    //        return RedirectToLocal(returnUrl, "Index", "Home", null);
                    //    }

                    //    if (Roles.IsUserInRole(model.UserName, BnuxqCRM.Common.Enums.RoleType.Boss.ToString()))
                    //    {
                    //        return RedirectToLocal(returnUrl, "Index", "Home", new { area = "Boss" });
                    //    }

                    //    if (Roles.IsUserInRole(model.UserName, BnuxqCRM.Common.Enums.RoleType.Manager.ToString()))
                    //    {
                    //        return RedirectToLocal(returnUrl, "Index", "Home", new { area = "Manager" });
                    //    }
                    //}
                    //}
                }
            }


            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            ModelState.AddModelError("", "提供的用户名或密码不正确。");
            return View(model);
        }

        [HttpPost]
        public ActionResult Reg(UserRegViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var token = WebSecurity.CreateUserAndAccount(model.UserName, model.Password, requireConfirmationToken: true);
                    Roles.AddUserToRole(model.UserName, JL.Core.Consts.Role_Admin);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
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

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
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

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
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
    }
}
