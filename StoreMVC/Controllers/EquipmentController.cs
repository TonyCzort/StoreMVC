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

        public ActionResult List(string categoryName)
        {
           // var category = db.Category.Include("AllEquipment").Where(c => c.CategoryName.ToUpper() == categoryName.ToUpper()).Single();
            var category = db.Category.Include("AllEquipment").Where(c => c.CategoryName.ToUpper() == categoryName.ToUpper()).Single();
            var equipment = category.AllEquipment.ToList();
            return View(equipment);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //akcja wywołana tylko z poziomu innej akcji
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = db.Category.ToList();
            return PartialView("_CategoryMenu", categories);
        }
    }
}