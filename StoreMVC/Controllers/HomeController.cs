using StoreMVC.DAL;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private EquipmentContext db = new EquipmentContext();
        
        public ActionResult Index()
        {
            var categoryList = db.Category.ToList();

            return View();
        }

        public ActionResult StaticSites(string name)
        {
            return View(name);
        }
    }
}