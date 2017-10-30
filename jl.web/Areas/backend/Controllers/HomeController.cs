using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jl.web.Areas.backend.Controllers
{
    public class HomeController : Controller
    {
        // GET: backend
        public ActionResult Index()
        {
            return View();
        }

        // GET: backend/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: backend/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: backend/Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: backend/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: backend/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: backend/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: backend/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
