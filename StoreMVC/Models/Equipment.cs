using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreMVC.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Write equipment name")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Write manufacturer name")]
        [StringLength(100)]
        public string Manufacturer { get; set; }
        public DateTime DateAdded { get; set; }
        [StringLength(100)]
        public string PictureName { get; set; }
        public string Description { get; set; }
        public decimal EquipmentPrice { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        //wlasciwosc nawigacyjna
        public virtual Category Category { get; set; }
    }

}