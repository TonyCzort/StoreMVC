using StoreMVC.DAL;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Infrastructure
{
    public class BasketManager
    {
        private EquipmentContext db;
        private ISessionManager session;

        public BasketManager(ISessionManager session, EquipmentContext db)
        {
            this.session = session;
            this.db = db;

          
        }


        public List<BasketPosition> GetBasket()
        {
            List<BasketPosition> basket;
            if (session.Get<List<BasketPosition>>(Const.BasketSessionKey) == null)
            {
                basket = new List<BasketPosition>();
            }
            else
            {
                basket = session.Get<List<BasketPosition>>(Const.BasketSessionKey) as List<BasketPosition>;
            }

            return basket;
        }

        public void AddToBasket(int equipmentId)
        {
            var basket = GetBasket();
            var basketPosition = basket.Find(b => b.Equipment.EquipmentId == equipmentId);

            if (basketPosition !=null)
            {
                basketPosition.Quantity++;
            }
            else
            {
                var equipmentToAdd = db.AllEquipment.Where(c => c.EquipmentId == equipmentId).SingleOrDefault();
                if (equipmentToAdd != null)
                {
                    var newBasketPosition = new BasketPosition()
                    {
                        Equipment = equipmentToAdd,
                        Quantity = 1,
                        Value = equipmentToAdd.EquipmentPrice
                    };
                    basket.Add(newBasketPosition);
                }

            }
            session.Set(Const.BasketSessionKey, basket);
        }

        public int DeleteFromBasket(int equipmentId)
        {
            var basket = GetBasket();
            var basketPosition = basket.Find(b => b.Equipment.EquipmentId == equipmentId);

            if (basketPosition != null)
            {
                if (basketPosition.Quantity >1)
                {
                    basketPosition.Quantity--;
                    return basketPosition.Quantity;
                }
                else
                {
                    basket.Remove(basketPosition);
                }
            }
            return 0;
        }

        public decimal GetBasketValue()
        {
            var basket = GetBasket();
            return basket.Sum(b => (b.Quantity * b.Equipment.EquipmentPrice));
        }

        public int GetQuantityOfBasketPosition()
        {
            var basket = GetBasket();
            int quantity = basket.Sum(b => b.Quantity);
            return quantity;
        }

        public Order CreateOrder(Order newOrder, string userId)
        {
            var basket = GetBasket();
            newOrder.DateAdded = DateTime.Now;
            // newOrder.userId = userId;
            db.Orders.Add(newOrder);
            if (newOrder.OrderItems == null)
                            newOrder.OrderItems = new List<OrderItem>();
            decimal basketValue = 0;
            foreach (var basketElement in basket)
            {
                var newOrderPosition = new OrderItem()
                {
                    EquipmentId = basketElement.Equipment.EquipmentId,
                    Quantity = basketElement.Quantity,
                    OrderValue = basketElement.Equipment.EquipmentPrice
                };

                basketValue += (basketElement.Quantity * basketElement.Equipment.EquipmentPrice);
                newOrder.OrderItems.Add(newOrderPosition);
            }
            newOrder.Value = basketValue;
            db.SaveChanges();

            return newOrder;
        }

        public void EmptyBasket()
        {
            session.Set<List<BasketPosition>>(Const.BasketSessionKey, null);
        }
    }
}