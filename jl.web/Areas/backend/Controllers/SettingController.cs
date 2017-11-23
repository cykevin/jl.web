using JL.Web.Areas.backend.Models;
using System.Web.Mvc;
using JL.Infrastructure;
using JL.Core;
using System.Linq;
using JL.Web.Common;

namespace JL.Web.Areas.backend.Controllers
{
    public class SettingController : Controller
    {
        private IJLService jlService;

        public SettingController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Setting
        [HttpGet]
        public ActionResult Index()
        {
            var settings = jlService.GetSettingList();
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
                    jlService.SaveSetting(Consts.SettingItem_Keywords, model.Keywords);
                }
                if(!model.Description.IsNullOrEmpty())
                {
                    jlService.SaveSetting(Consts.SettingItem_Description, model.Description);
                }
                if(!model.Address.IsNullOrEmpty())
                {
                    jlService.SaveSetting(Consts.SettingItem_Address, model.Address);
                }
                if (!model.Copyright.IsNullOrEmpty())
                {
                    jlService.SaveSetting(Consts.SettingItem_Copyright, model.Copyright);
                }
                if (!model.IcpNO.IsNullOrEmpty())
                {
                    jlService.SaveSetting(Consts.SettingItem_Icpno, model.IcpNO);
                }
                if (!model.Phone.IsNullOrEmpty())
                {
                    jlService.SaveSetting(Consts.SettingItem_Phone, model.Phone);
                }

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View(model);
        }

    }
}