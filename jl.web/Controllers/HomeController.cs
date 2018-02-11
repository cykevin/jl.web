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
    public class HomeController : Controller
    {
        private ISettingService settingService;
        private IJLService jlService;

        public HomeController(ISettingService settingService,
            IJLService jlService)
        {
            this.settingService = settingService;
            this.jlService = jlService;
        }

        public ActionResult Index()
        {
            // 新品推荐
            var recommendProducts = jlService.GetProductsRecommends();
            ViewBag.RecommendProducts = recommendProducts;

            // 产品中心
            ProductFilter filter = new ProductFilter();
            filter.Status = 0;
            var productCenter = jlService.ProductPage(PageReq<ProductFilter>.Create(filter, pageSize: 6));
            ViewBag.ProductCenter = productCenter.Data;

            // 套装系列
            var pager = PageReq.Create(pageSize: 5);
            jlService.ProductCategoryPage(pager);

            // members
            MemberFilter mf = new MemberFilter();
            var members = jlService.MemberPage(PageReq<MemberFilter>.Create(mf, pageSize: 5));
            ViewBag.Members = members.Data;

            // 资讯中心
            ArticleFilter af = new ArticleFilter();
            af.Status = Consts.ArticleStatus_Published;
            var articlePager = PageReq<ArticleFilter>.Create(af, pageSize: 8);
            articlePager.OrderBy = " order by addtime desc ";
            var articles = jlService.ArticlePage(articlePager);
            ViewBag.Articles = articles.Data;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var setting = settingService.GetSetting(Consts.SettingItem_Contact);

            ViewBag.content = setting.Value;
            return View();
        }
    }
}