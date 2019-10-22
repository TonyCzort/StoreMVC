using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.ViewModels
{
    public class BasketViewModel
    {

        public List<BasketPosition> BasketPositions { get; set; }
        public decimal FullPrice { get; set; }
    }
}