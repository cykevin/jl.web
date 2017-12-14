using JL.Core;
using JL.Core.Common;
using JL.Core.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Controllers
{
    [Authorize]
    public class MaterialController : Controller
    {
        private IJLService jlService;

        public MaterialController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Material
        public ActionResult Index(int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();

            var pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        // 
        public ActionResult Picture(int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.MaterialType = (int)MaterialType.Picture;

            var pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        public ActionResult Video(int page = 1)
        {
            MaterialFilter filter = new MaterialFilter();
            filter.MaterialType = (int)MaterialType.Video;

            PageReq<MaterialFilter> pager = PageReq<MaterialFilter>.Create(filter, page);
            var data = jlService.MaterialPage(pager);

            return View(data);
        }

        public ActionResult Download(int id)
        {
            if (id>0)
            {
                var material = jlService.GetMaterial(id);                

                if (material != null)
                {
                    // 下载量加1
                    jlService.IncrementPageViews(id);

                    var filePath = Server.MapPath(material.FileName);
                    var mime = MimeMapping.GetMimeMapping(filePath);

                    var bytes = GetFile(filePath);
                    return File(bytes, mime);
                }
            }

            return HttpNotFound();
        }

        private byte[] GetFile(string s)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }
    }
}