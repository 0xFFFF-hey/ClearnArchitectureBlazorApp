using IMS.CoreBusiness.Entities;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IMS.UseCases.Inventories
{
	internal class ViewInventoriesByIdUseCase : IViewInventoriesByIdUseCase
	{
		private readonly IInventoryRepository inventoryRepository;
        public ViewInventoriesByIdUseCase(IInventoryRepository inventoryRepository)
        {
			this.inventoryRepository = inventoryRepository;

		}
        public async Task<Inventory> ExecuteAsync(int InventoryId)
		{
			return await inventoryRepository.GetInventoriesByIdAsync(InventoryId);
		}
	}
}
