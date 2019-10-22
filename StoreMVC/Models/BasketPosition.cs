using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Models
{
    public class BasketPosition
    {
        public Equipment Equipment { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}