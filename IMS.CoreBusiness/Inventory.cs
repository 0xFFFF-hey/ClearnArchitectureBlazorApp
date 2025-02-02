namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; } = string.Empty;
        public int Quantity { get; set; } 
        public double Price { get; set; }

        // Business logic methods
        public bool IsInStock() => Quantity > 0;
        public void UpdateQuantity(int quantity) => Quantity += quantity;
    }
}
