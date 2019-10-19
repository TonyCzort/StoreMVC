using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMVC.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: Equipment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName)
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View();
        }
    }
}