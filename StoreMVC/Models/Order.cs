using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreMVC.Models
{
    public class Order
    {

        public int OrderId { get; set; }
        [Required(ErrorMessage = "Write name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Write surname")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Write Street Name")]
        [StringLength(100)]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "Write city")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Write postal code")]
        [StringLength(6)]
        public string PostalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderState OrderState { get; set; } //stan zamowienia enum
        public decimal Value { get; set; }

        public List<OrderItem> OrderItems { get; set; } //pozycjezamowienia
    }

    public enum OrderState
    {
        New,
        Completed
    }

}