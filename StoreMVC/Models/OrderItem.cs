namespace StoreMVC.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int EquipmentId { get; set; }
        public int Quantity { get; set; }
        public decimal OrderValue { get; set; }

        public virtual Equipment equipment { get; set; }
        public virtual Order order { get; set; }
    }
}