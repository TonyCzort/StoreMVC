
using StoreMVC.DAL;
using StoreMVC.Infrastructure;
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
            
            ICacheProvider cache = new DefaultCacheProvider();

            List<Category> categories;
            if (cache.IsSet(Const.CategoriesCacheKey))
            {
                categories = cache.Get(Const.CategoriesCacheKey) as List<Category>;
            }
            else
            {
                //unikalne zawsze, dobiera inne
                categories = db.Category.ToList();
               cache.Set(Const.CategoriesCacheKey, categories, 60);
            }
            
            List<Equipment> latest;
            if (cache.IsSet(Const.LatestCacheKey))
            {
                latest = cache.Get(Const.LatestCacheKey) as List<Equipment>;
            }
            else
            {
                latest = db.AllEquipment.Where(a => !a.Hidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
                cache.Set(Const.LatestCacheKey, latest, 60);
            }

            List<Equipment> bestseller;
            if (cache.IsSet(Const.BestsellerCacheKey))
            {
                bestseller = cache.Get(Const.BestsellerCacheKey) as List<Equipment>;
            }
            else
            {
                //uniqe, always selecting different objects
                bestseller = db.AllEquipment.Where(a => !a.Hidden && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();
                cache.Set(Const.BestsellerCacheKey, bestseller, 60);
            }


            //unikalne zawsze, dobiera inne
             bestseller = db.AllEquipment.Where(a => !a.Hidden && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();

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