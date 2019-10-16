using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreMVC.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Write category name")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Write category description")]
        public string CategoryDescription { get; set; }
        public string CategoryPcitureName { get; set; }


        //do kategorii wiele różnych
        public virtual ICollection<Equipment> AllEquipment { get; set; }
    }
}