﻿using JL.Core;
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

namespace JL.Web.Areas.backend.Controllers
{
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
            var pager = PageReq<ArticleFilter>.Create(filter, page);
            pager.OrderBy = "addtime";
            
            var data = jlService.ArticlePage(pager);
            ViewBag.articleQuery = filter;
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
                article.Content = model.Content;
                // picture
                if (Request.Files != null &&
                    Request.Files.Count > 0)
                {
                    var imgLink = FileHelper.SaveArticleImage(Request.Files[0]);
                    article.Picture = imgLink;
                }
                else
                {
                    article.Picture = model.Picture;
                }                

                jlService.UpdateArticle(article);
                ViewData.Add("ResultObject", ResultObject.Succeed());

                // for show
                model.Picture = article.Picture;
            }
            return View(model);
        }
    }
}