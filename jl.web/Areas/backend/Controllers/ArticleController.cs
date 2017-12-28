using JL.Core;
using JL.Core.Common;
using JL.Core.Filters;
using JL.Web.Areas.backend.Models;
using JL.Web.Common;
using JL.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JL.Infrastructure;

namespace JL.Web.Areas.backend.Controllers
{
    [Authorize(Roles = Consts.Role_Admin)]
    public class ArticleController : Controller
    {
        private IJLService jlService;

        public ArticleController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: backend/Article
        public ActionResult Index(ArticleSearchModel model,int page=1)
        {
            ArticleFilter filter = new ArticleFilter();
            filter.Title = model.Title;
            filter.Status = Consts.ArticleStatus_All;
            var pager = PageReq<ArticleFilter>.Create(filter, page);
            pager.OrderBy = "addtime";
            
            var data = jlService.ArticlePage(pager);
            ViewBag.articleQuery = filter;
            ViewBag.ReturnUrl=Request.Url.PathAndQuery;
            return View(data);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult New(ArticleModel model)
        {
            if(ModelState.IsValid)
            {
                var article = new JL.Core.Models.Article();
                article.AddTime = model.AddTime ?? DateTime.Now;
                article.Content = model.Content;
                article.Brief = model.Brief;
                article.Title = model.Title;
                article.Status = model.IsPublished ? 0 : 1;
                // picture
                if (Request.Files != null &&
                    Request.Files.Count > 0)
                {
                    var imgLink = FileHelper.SaveArticleImage(Request.Files[0]);
                    article.Picture = imgLink;
                }
                jlService.AddArticle(article);
                ViewData.Add("ResultObject", ResultObject.Succeed());
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var article = jlService.GetArticle(id);

            ArticleModel model = new ArticleModel();
            model.AddTime = article.AddTime;
            model.Content = article.Content;
            model.Brief = article.Brief;
            model.Title = article.Title;
            model.Picture = article.Picture;
            model.IsPublished = article.Status == 0;
            
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(ArticleModel model,int id)
        {
            if(ModelState.IsValid)
            {
                var article = jlService.GetArticle(id);
                article.AddTime = model.AddTime ?? article.AddTime;
                article.Title = model.Title;
                article.Brief = model.Brief;
                article.Content = model.Content;
                article.Status = model.IsPublished ? 0 : 1;

                // picture
                if (Request.Files != null
                    && Request.Files.Count > 0
                    && Request.Files[0].ContentLength > 0)
                {
                    var imgLink = FileHelper.SaveArticleImage(Request.Files[0]);
                    article.Picture = imgLink;
                }

                jlService.UpdateArticle(article);
                ViewData.Add("ResultObject", ResultObject.Succeed());

                // for show
                model.Picture = article.Picture;
            }
            return View(model);
        }

        public ActionResult Delete(string articles, string returnUrl)
        {
            var idArray = articles.Split(',')
                .Where(a => !string.IsNullOrEmpty(a))
                .Select(a => a.ToInt32()).Distinct();

            foreach (var id in idArray)
            {
                var article = jlService.GetArticle(id);
                if (article != null)
                {
                    jlService.DeleteArticle(article);
                }
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("index");
        }

    }
}