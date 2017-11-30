using JL.Web.Areas.backend.Models;
using JL.Web.Helpers;
using JL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JL.Core.Providers;
using JL.Core;
using JL.Web.Common;
using JL.Core.Common;

namespace JL.Web.Areas.backend.Controllers
{
    public class MemberController : Controller
    {
        private IJLService jlService;

        public MemberController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Member
        public ActionResult Index(MemberSearchModel searchTo, int page = 0)
        {
            var filter = new JL.Core.Filters.MemberFilter();
            filter.NickName = searchTo.NickName;
            filter.JoinTimeFrom = searchTo.JoinTimeFrom;
            filter.JoinTimeTo = searchTo.JoinTimeTo;
            var pager = PageReq<JL.Core.Filters.MemberFilter>.Create(filter, page);

            // search page 
            var data = jlService.MemberPage(pager);
            ViewBag.productQuery = searchTo;
            return View(data);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(MemberModel model,string cutPara)
        {
            if(ModelState.IsValid)
            {
                string fileLink = "";

                // file
                if (Request.Files != null &&
                    Request.Files.Count > 0)
                {

                    int x = 0, y = 0, width = 0, height = 0;
                    if (!string.IsNullOrEmpty(cutPara))
                    {
                        var paras = cutPara.Split(',').Select(s => s.ToDouble()).ToArray();

                        if (paras.Length == 4)
                        {
                            x = (int)paras[0];
                            y = (int)paras[1];
                            width = (int)paras[2];
                            height = (int)paras[3];

                            fileLink = FileHelper.SaveMemberImage(Request.Files[0], x, y, width, height);
                        }
                    }
                }

                // info
                var member = new JL.Core.Models.Member();
                member.Address = model.Address;
                member.Description = model.Description;
                member.Email = model.Email;
                member.JoinTime = model.JoinTime??DateTime.Now;
                member.NickName = model.NickName;
                member.Phone = model.Phone;
                member.Picture = fileLink;
                member.QQ = model.QQ;
                member.RealName = model.Name;
                member.Status = model.Status;
                member.Weixin = model.Weixin;
                member.Words = model.Words;
                jlService.AddMember(member);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }            

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var member = jlService.GetMember(id);

            var model = new MemberModel();
            model.Address = member.Address;
            model.Description = member.Description;
            model.Email = member.Email;
            model.JoinTime = member.JoinTime;
            model.Name = member.RealName;
            model.NickName = member.NickName;
            model.Phone = member.Phone;
            model.Picture = member.Picture;
            model.QQ = member.QQ;
            model.Status = member.Status;

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(MemberModel model, int id, string cutPara)
        {
            if (ModelState.IsValid)
            {
                string fileLink = "";

                // file
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {

                    int x = 0, y = 0, width = 0, height = 0;
                    if (!string.IsNullOrEmpty(cutPara))
                    {
                        var paras = cutPara.Split(',').Select(s => s.ToDouble()).ToArray();

                        if (paras.Length == 4)
                        {
                            x = (int)paras[0];
                            y = (int)paras[1];
                            width = (int)paras[2];
                            height = (int)paras[3];

                            fileLink = FileHelper.SaveMemberImage(Request.Files[0], x, y, width, height);
                            model.Picture = fileLink;
                        }
                    }
                }

                // info
                var member = jlService.GetMember(id);
                if (fileLink != "")
                {
                    member.Picture = fileLink;
                }
                member.Address = model.Address;
                member.Description = model.Description;
                member.Email = model.Email;
                member.JoinTime = model.JoinTime ?? DateTime.Now;
                member.NickName = model.NickName;
                member.Phone = model.Phone;
                member.QQ = model.QQ;
                member.RealName = model.Name;
                member.Status = model.Status;
                member.Weixin = model.Weixin;
                member.Words = model.Words;
                jlService.UpdateMember(member);

                ViewData.Add("ResultObject", ResultObject.Succeed());
            }

            return View(model);
        }
    }
}