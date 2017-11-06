using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JL.Web.Helpers
{
    public class FileHelper
    {
        public static string SaveBannerImage(HttpPostedFileBase file)
        {
            var dir = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/Banners");

            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            var ext = System.IO.Path.GetExtension(file.FileName);
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ext;

            var newFilePath = System.IO.Path.Combine(dir, fileName);
            file.SaveAs(newFilePath);

            return "~/Images/Banners/" + fileName;

        }

        public static string SaveProductImage(HttpPostedFileBase file)
        {
            if (file.ContentLength < 1)
                return null;

            var dirName = DateTime.Now.ToString("yyyyMMdd");

            var dir = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/Products/" + dirName);

            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            var ext = System.IO.Path.GetExtension(file.FileName);
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + ext;

            // 保存源图片文件
            var newFilePath = System.IO.Path.Combine(dir, fileName);
            file.SaveAs(newFilePath);

            // 保存3种大小的缩略图
            var thumbnail= System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss")+"!80x80" + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, 80, 80, "Cut");
            thumbnail = System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + "!250x250" + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, 250, 250, "Cut");
            thumbnail = System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + "!430x430" + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, 430, 430, "Cut");

            return "~/Images/Products/" + dirName + "/" + fileName;
        }

        public static string SaveArticleImage(HttpPostedFileBase file)
        {
            var dir = System.Web.Hosting.HostingEnvironment.MapPath("~/Images/Article");

            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            var ext = System.IO.Path.GetExtension(file.FileName);
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ext;

            var newFilePath = System.IO.Path.Combine(dir, fileName);
            file.SaveAs(newFilePath);

            return "~/Images/Article/" + fileName;
        }
    }
}