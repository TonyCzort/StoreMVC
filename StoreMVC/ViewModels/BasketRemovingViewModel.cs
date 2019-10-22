using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.ViewModels
{
    public class BasketRemovingViewModel
    {

        public decimal BasketFullPrice { get; set; }
        public int BasketPositionQuantity { get; set; }
        public int RemovePositionQuantity { get; set; }
        public int DeletingPositionId { get; set; }
    }
}