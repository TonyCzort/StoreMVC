using StoreMVC.DAL;
using StoreMVC.Models;
using StoreMVC.ViewModels;
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
            var categories = db.Category.ToList();

            var latest = db.AllEquipment.Where(a => !a.Hidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
            //unikalne zawsze, dobiera inne
            var bestseller = db.AllEquipment.Where(a => !a.Hidden && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel()
            {
                Categories = categories,
                Latest = latest,
                Bestsellers = bestseller
            };

            return View(vm);
        }

        public ActionResult StaticSites(string name)
        {
            return View(name);
        }

        
    }
}