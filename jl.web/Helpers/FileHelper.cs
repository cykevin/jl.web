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
            if (file.ContentLength < 1)
                return null;

            var dirName = DateTime.Now.ToString("yyyyMMdd");
            var virtualPath = "~/Images/Articles/" + dirName;

            var dir = System.Web.Hosting.HostingEnvironment.MapPath(virtualPath);

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

            var size = ImageHelper.MapPictureEnumsToSize(PictureEnums.Article, PictureSize.Small);
            var wh = size.Split('x').Select(i => Convert.ToInt32(i)).ToArray();
            var thumbnail = System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + size + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, wh[0], wh[1], "Cut");

            size = ImageHelper.MapPictureEnumsToSize(PictureEnums.Article, PictureSize.Middle);
            wh = size.Split('x').Select(i => Convert.ToInt32(i)).ToArray();
            thumbnail = System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + size + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, wh[0], wh[1], "Cut");

            size = ImageHelper.MapPictureEnumsToSize(PictureEnums.Article, PictureSize.Big);
            wh = size.Split('x').Select(i => Convert.ToInt32(i)).ToArray();
            thumbnail = System.IO.Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + size + ext);
            ImageHelper.MakeThumbnail(newFilePath, thumbnail, wh[0], wh[1], "Cut");

            return virtualPath + "/" + fileName;
        }        

        public static string SaveMaterial(HttpPostedFileBase file)
        {
            // 保存文件到目录/material/2017xxxx/
            if (file.ContentLength < 1)
                return null;
            
            var dirName = DateTime.Now.ToString("yyyyMMdd");
            var virtualPath = "~/materials/" + dirName;

            var dir = System.Web.Hosting.HostingEnvironment.MapPath(virtualPath);

            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            var ext = System.IO.Path.GetExtension(file.FileName);
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + ext;

            // 保存源文件
            var newFilePath = System.IO.Path.Combine(dir, fileName);
            file.SaveAs(newFilePath);

            return virtualPath + "/" + fileName;
        }
    }
}