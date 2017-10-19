using jl.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace jl.web.Controllers
{
    public class HiController : Controller
    {
        // GET: Hi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hi/5
        public ActionResult Index(int id)
        {
            return View();
        }
        
        public ActionResult Reg()
        {
            return View();
        }


        // GET: Hi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hi/Edit/5
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

        // GET: Hi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hi/Delete/5
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
