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
	public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
	{
		private readonly IInventoryRepository inventoryRepository;
        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
			this.inventoryRepository = inventoryRepository;

		}
        public async Task<Inventory> ExecuteAsync(int InventoryId)
		{
			return await inventoryRepository.GetInventoriesByIdAsync(InventoryId);
		}
	}
}
