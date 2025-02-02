using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double Price { get; set; }
        public List<Inventory> ProductInventories { get; set; } = new();

        // Business logic methods
        public bool IsEnoughInventoryAvailable(Inventory inventory, int quantity)
        {
            var productInventory = ProductInventories.FirstOrDefault(pi => pi.InventoryId == inventory.InventoryId);
            return productInventory != null && productInventory.Quantity >= quantity;
        }
    }
}
