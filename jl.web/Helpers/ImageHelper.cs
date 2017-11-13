using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace JL.Web.Helpers
{
    public class ImageHelper
    {
        /// <summary> 
        /// 生成缩略图 
        /// </summary> 
        /// <param name="originalImagePath">源图路径（物理路径）</param> 
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param> 
        /// <param name="width">缩略图宽度</param> 
        /// <param name="height">缩略图高度</param> 
        /// <param name="mode">生成缩略图的方式:HW,W,H,Cut</param>     
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            Image originalImage = Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                 
                    break;
                case "W"://指定宽，高按比例                     
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例 
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                 
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }
            
            Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;            
            g.Clear(Color.Transparent);            
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);
            try
            {
                //以jpg格式保存缩略图 
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            {
                throw;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }

        #region 图片地址展示 

        private static string MapPictureEnumsToDirName(JL.Web.PictureEnums type)
        {
            var dirName = "products";
            switch (type)
            {
                case PictureEnums.Product:
                    dirName = "products";
                    break;
                case PictureEnums.Article:
                    dirName = "articles";
                    break;
                case PictureEnums.User:
                    dirName = "users";
                    break;
            }
            return dirName;
        }
        public static string MapPictureEnumsToSize(JL.Web.PictureEnums type,PictureSize size)
        {
            switch (type)
            {
                case PictureEnums.Product:
                    if (size == PictureSize.Big) return "430x430";
                    if (size == PictureSize.Middle) return "250x250";
                    if (size == PictureSize.Small) return "80x80";
                    if (size == PictureSize.Big) return null;
                    break;
                case PictureEnums.Article:
                    if (size == PictureSize.Big) return "440x330";
                    if (size == PictureSize.Middle) return "220x165";
                    if (size == PictureSize.Small) return "100x80";
                    if (size == PictureSize.Big) return null;
                    break;
                case PictureEnums.User:
                    if (size == PictureSize.Big) return "440x330";
                    if (size == PictureSize.Middle) return "220x165";
                    if (size == PictureSize.Small) return "100x80";
                    if (size == PictureSize.Big) return null;
                    break;
            }
            return null;
        }

        public static string GenPictureUrlSmall(string path, JL.Web.PictureEnums type = PictureEnums.Product)
        {
            var size = MapPictureEnumsToSize(type, PictureSize.Small);
            if (string.IsNullOrEmpty(path))
            {
                return "/images/" + MapPictureEnumsToDirName(type) + "/default!" + size + ".jpg";
            }                

            if (path[0] == '~')
            {
                path = path.Substring(1);
                var extIndex = path.LastIndexOf('.');
                var pre = path.Substring(0, extIndex);
                var ext = path.Substring(extIndex);

                return pre + size + ext;
            }

            return path;
        }

        public static string GenPictureUrlMiddle(string path, JL.Web.PictureEnums type = PictureEnums.Product)
        {
            var size = MapPictureEnumsToSize(type, PictureSize.Small);
            if (string.IsNullOrEmpty(path))
            {
                return "/images/" + MapPictureEnumsToDirName(type) + "/default!" + size + ".jpg";
            }

            if (path[0] == '~')
            {
                path = path.Substring(1);
                var extIndex = path.LastIndexOf('.');
                var pre = path.Substring(0, extIndex);
                var ext = path.Substring(extIndex);

                return pre + size + ext;
            }

            return path;
        }
        public static string GenPictureUrlBig(string path, JL.Web.PictureEnums type = PictureEnums.Product)
        {
            var size = MapPictureEnumsToSize(type, PictureSize.Small);
            if (string.IsNullOrEmpty(path))
            {
                return "/images/" + MapPictureEnumsToDirName(type) + "/default!" + size + ".jpg";
            }

            if (path[0] == '~')
            {
                path = path.Substring(1);
                var extIndex = path.LastIndexOf('.');
                var pre = path.Substring(0, extIndex);
                var ext = path.Substring(extIndex);

                return pre + size + ext;
            }

            return path;
        }
        public static string GenPictureUrlSource(string path, JL.Web.PictureEnums type = PictureEnums.Product)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (path[0] == '~')
            {
                return "http://www.jl.com" + path.Substring(1);
            }

            return path;
        }

        public static string GenMaterialUrlSource(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (path[0] == '~')
            {
                return "http://www.jl.com" + path.Substring(1);
            }

            return path;
        }

        #endregion
    }
}