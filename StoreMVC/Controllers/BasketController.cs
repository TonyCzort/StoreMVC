using StoreMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.DAL;
using StoreMVC.ViewModels;

namespace StoreMVC.Controllers
{
    public class BasketController : Controller
    {
        private BasketManager basketManager;
        private ISessionManager sessionManager { get; set; }
        private EquipmentContext db;

        public BasketController()
        {
            db = new EquipmentContext();
            sessionManager = new SessionManager();
            basketManager = new BasketManager(sessionManager, db);
        }

        // GET: Basket
        public ActionResult Index()
        {
            var basketPosition = basketManager.GetBasket();
            var fullPrice = basketManager.GetBasketValue();
            BasketViewModel basketVM = new BasketViewModel()
            {
                BasketPositions = basketPosition,
                FullPrice = fullPrice
            };
            return View(basketVM);
        }

        public ActionResult AddToBasket(int id)
        {
            basketManager.AddToBasket(id);

            return RedirectToAction("Index");
        }

        public int GetQuantityFromBasket()
        {
            return basketManager.GetQuantityOfBasketPosition();
        }

        public ActionResult DeleteFromBasket(int equipmentId)
        {
            int positionQuantity = basketManager.DeleteFromBasket(equipmentId);
            int basketPositionQuantity = basketManager.GetQuantityOfBasketPosition();
            decimal basketValue = basketManager.GetBasketValue();

            var result = new BasketRemovingViewModel
            {
                DeletingPositionId = equipmentId,
                RemovePositionQuantity = positionQuantity,
                BasketFullPrice = basketValue,
                BasketPositionQuantity = basketPositionQuantity,

            };
            return Json(result);
        }
    }
}