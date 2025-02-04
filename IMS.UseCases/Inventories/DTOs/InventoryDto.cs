using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories.DTOs
{
	public class InventoryDto
	{
		public string InventoryName { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public double Price { get; set; }
	}
}
