using LQVLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LQVLesson08CF.Controllers
{
    public class LQVCategoryController : Controller
    {
        private static LQVBookStore _LQVBookstore;
        public LQVCategoryController()
        {
            _LQVBookstore = new LQVBookStore();
        }
        // GET: LQVCategory
        public ActionResult LQVIndex()
        {
            var LQVCategory = _LQVBookstore.LQVCategories.ToList();
            return View(LQVCategory);
        }
        [HttpGet]
        public ActionResult LQVCreate()
        {
            var LQVCategory = new LQVCategory();
            return View();
        }
        [HttpPost]
        public ActionResult LQVCreate(LQVCategory LQVCategory)
        {
            _LQVBookstore.LQVCategories.Add(LQVCategory);
            _LQVBookstore.SaveChanges();
          
            return RedirectToAction("LQVIndex");
        }
    }
}