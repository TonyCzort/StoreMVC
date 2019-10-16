using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public DateTime DateAdded { get; set; }
        public string PictureName { get; set; }
        public string Description { get; set; }
        public decimal EquipmentPrice { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        //wlasciwosc nawigacyjna
        public virtual Category Category { get; set; }
    }

}