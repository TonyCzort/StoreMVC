using StoreMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMVC.Controllers
{
    public class EquipmentController : Controller
    {

        
        private EquipmentContext db = new EquipmentContext();

        // GET: Equipment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName, string searchQuery = null)
        {
           
            var category = db.Category.Include("AllEquipment").Where(c => c.CategoryName.ToUpper() == categoryName.ToUpper()).Single();

            var equipment = category.AllEquipment.Where(a => (searchQuery == null ||
            a.Title.ToLower().Contains(searchQuery.ToLower()) ||
            a.Manufacturer.ToLower().Contains(searchQuery.ToLower()))&&
            !a.Hidden);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_EquipmentList", equipment);
            }

            return View(equipment);
        }

        public ActionResult Details(int id)
        {
            var equipment = db.AllEquipment.Find(id);
            return View(equipment);
        }
        //akcja wywołana tylko z poziomu innej akcji
        [ChildActionOnly]
        //trzyma dane, nie odswieza z bazy zawsze
        [OutputCache(Duration = 60000)]
        
        public ActionResult CategoryMenu()
        {
            
            var categories = db.Category.ToList();
            return PartialView("_CategoryMenu", categories);
        }

        public ActionResult EquipmentTips(string term)
        {
            var equipment = db.AllEquipment.Where(a => !a.Hidden && a.Title.ToLower().Contains(term.ToLower()))
                .Take(5).Select(a => new { label = a.Title });
            
            return Json(equipment, JsonRequestBehavior.AllowGet);
        }

    }
}