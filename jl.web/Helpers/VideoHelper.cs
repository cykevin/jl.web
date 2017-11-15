using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Helpers
{
    public class VideoHelper
    {
        /// <summary>
        /// 生成视频的缩略图
        /// </summary>
        /// <param name="videoFilePath"></param>
        /// <returns></returns>
        public static string CatchVideoThumbnail(string videoFilePath)
        {
            // 视频物理地址
            var videoPsyPath = System.Web.Hosting.HostingEnvironment.MapPath(videoFilePath);
            var thumbnailSize = "400x225";

            // ffmpeg地址
            var virPath = System.Configuration.ConfigurationManager.AppSettings["ffmpegPath"];
            var psyPath= System.Web.Hosting.HostingEnvironment.MapPath(virPath);

            // 缩略图地址
            var dirVirPath = "~/materials/" + DateTime.Now.ToString("yyyyMMdd");
            var thumbnailFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "!" + thumbnailSize + ".jpg";
            var dirVirFullPath = dirVirPath + "/" + thumbnailFileName;
            var thumbnailFilePath = System.Web.Hosting.HostingEnvironment.MapPath(dirVirFullPath);
            
            var process = new System.Diagnostics.ProcessStartInfo(psyPath);
            process.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.Arguments = " -i " + videoPsyPath + " -y -f image2 -t 0.1 -s " + thumbnailSize + " " + thumbnailFilePath;

            System.Diagnostics.Process.Start(process);

            return dirVirFullPath;
        }
    }
}