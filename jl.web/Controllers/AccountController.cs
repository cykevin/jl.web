using JL.Web.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace JL.Web.Controllers
{
    public class AccountController : Controller
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("AccountController");

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        // GET: Account

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                bool flag = Membership.ValidateUser(model.UserName, model.Password);
                if (flag)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

                    return RedirectToLocal(returnUrl);
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            ModelState.AddModelError("", "提供的用户名或密码不正确。");
            return View(model);
        }

        public ActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg(UserRegViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existed = WebSecurity.UserExists(model.UserName);

                    var token = WebSecurity.CreateUserAndAccount(model.UserName, model.Password, new { Email = model.Email }, requireConfirmationToken: false);

                    Roles.AddUserToRole(model.UserName, JL.Core.Consts.Role_User);
                }

                return RedirectToAction("Info");
            }
            catch(Exception e)
            {
                logger.Error(JL.Utils.JsonHelper.ObjectToString(model), e);
                return View();
            }
        }

        public ActionResult Info()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Info(UserInfoViewModel model)
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            var username = WebSecurity.CurrentUserName;
            var userid = WebSecurity.CurrentUserId;

            try
            {
                var success = WebSecurity.ChangePassword(username, model.OldPassword, model.NewPassword);
                ViewBag.Success = success;
            }
            catch (Exception e)
            {
                logger.Error("ChangePassword", e);
            }
            
            return View();
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();

            return RedirectToAction("index", "home");
        }

        private ActionResult RedirectToLocal(string returnUrl, string action = "index", string controller = "home")
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
