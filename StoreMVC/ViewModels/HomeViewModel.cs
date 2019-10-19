using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Equipment> Latest { get; set; }
        public IEnumerable<Equipment> Bestsellers { get; set; }
    }

}