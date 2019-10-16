using System.Collections.Generic;

namespace StoreMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryPcitureName { get; set; }

        public virtual ICollection<Equipment> AllEquipment { get; set; }
    }
}