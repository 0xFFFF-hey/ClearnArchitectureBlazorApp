using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
		
        [Required]
		[StringLength(150)]
		public string InventoryName { get; set; } = string.Empty;

		[Range(0, int.MaxValue, ErrorMessage = "Quantity must be greator or equal to 0.")]
		public int Quantity { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Price must be greator or equal to 0.")]
		public double Price { get; set; }

		// Business logic methods
		public bool IsInStock() => Quantity > 0;
        public void UpdateQuantity(int quantity) => Quantity += quantity;
    }
}
