using JL.Web.Areas.backend.Models;
using System.Web.Mvc;
using JL.Infrastructure;
using JL.Core;
using System.Linq;
using JL.Web.Common;
using JL.Web.Models;
using WebMatrix.WebData;
using System;

namespace JL.Web.Areas.backend.Controllers
{
    [Authorize(Roles = Consts.Role_Admin)]
    public class SettingController : Controller
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("SettingController");

        private ISettingService settingService;

        public SettingController(ISettingService settingService)
        {
            this.settingService = settingService;
        }

        // GET: backend/Setting
        [HttpGet]
        public ActionResult Index()
        {
            var settings = settingService.GetSettingList();
            SettingModel model = new SettingModel();

            if(settings!=null)
            {
                var keywords = settings.FirstOrDefault(s =>string.Equals(s.Key, Consts.SettingItem_Keywords));
                var description = settings.FirstOrDefault(s =>string.Equals(s.Key, Consts.SettingItem_Description));
                var address = settings.FirstOrDefault(s => string.Equals(s.Key, Consts.SettingItem_Address));
                var copyright = settings.FirstOrDefault(s => string.Equals(s.Key, Consts.SettingItem_Copyright));
                var icpno = settings.FirstOrDefault(s => string.Equals(s.Key, Consts.SettingItem_Icpno));

                if (keywords != null)
                    model.Keywords = keywords.Value;
                if (description != null)
                    model.Description = description.Value;
                if (address != null)
                    model.Address = address.Value;
                if (copyright != null)
                    model.Copyright = copyright.Value;
                if (icpno != null)
                    model.IcpNO = icpno.Value;
            }

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(SettingModel model)
        {
            if(ModelState.IsValid)
            {
                if(!model.Keywords.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Keywords, model.Keywords);
                }
                if(!model.Description.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Description, model.Description);
                }
                if(!model.Address.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Address, model.Address);
                }
                if (!model.Copyright.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Copyright, model.Copyright);
                }
                if (!model.IcpNO.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Icpno, model.IcpNO);
                }
                if (!model.Phone.IsNullOrEmpty())
                {
                    settingService.SaveSetting(Consts.SettingItem_Phone, model.Phone);
                }

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View(model);
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

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Contact(ContactModel model)
        {
            if(!string.IsNullOrEmpty(model.Content))
            {
                settingService.SaveSetting(Consts.SettingItem_Contact, model.Content);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View();
        }
    }
}