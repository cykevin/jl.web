using JL.Web.Areas.backend.Models;
using System.Web.Mvc;
using JL.Infrastructure;
using JL.Core;

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
            return View();
        }

        [HttpPost]
        public ActionResult Index(SettingModel model)
        {
            if(ModelState.IsValid)
            {
                if(!model.Keywords.IsNullOrEmpty())
                {
                    jlService.
                }
            }
            return View();
        }

    }
}