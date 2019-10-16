using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderState OrderState { get; set; } //stan zamowienia enum
        public decimal Value { get; set; }

        List<OrderItem> OrderItems { get; set; } //pozycjezamowienia
    }

    public enum OrderState
    {
        New,
        Completed
    }

}