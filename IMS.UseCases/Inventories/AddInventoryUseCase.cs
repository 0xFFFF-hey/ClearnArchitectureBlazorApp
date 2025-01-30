using IMS.CoreBusiness;
using IMS.UseCases.Inventories.DTOs;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
	internal class AddInventoryUseCase : IAddInventoryUseCase
	{
		private readonly IInventoryRepository _inventoryRepository;
        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
			_inventoryRepository = inventoryRepository;

		}
        public Task ExecuteAsync(InventoryDto inventoryDto)
		{
			var inventory = new Inventory
			{
				InventoryName = inventoryDto.InventoryName,
				Quantity = inventoryDto.Quantity,
				Price = inventoryDto.Price
			};
			return _inventoryRepository.AddInventoryAsync(inventory);
		}
	}
}
