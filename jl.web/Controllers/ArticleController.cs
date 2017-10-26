﻿using JL.Core;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jl.web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IJLService jlService;

        public ArticleController(IJLService jlService)
        {
            this.jlService = jlService;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public string Publish()
        {
            Article article = new Article();
            article.AddTime = DateTime.Now;
            article.Title = "join us now!";
            article.Content = "welcome to wechat business";
            jlService.InsertArticle(article);

            return article.ToString();
        }

        public string delete(int id)
        {
            var article = jlService.GetArticle(id);
            jlService.DeleteArticle(article);

            return "deleted : " + article.ToString();
        }
    }
}